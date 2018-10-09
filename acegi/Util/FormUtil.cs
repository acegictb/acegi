using acegi.Dao;
using acegi.Model;
using acegi.MODEL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace acegi.Util
{
    public class FormUtil
    {
        public const string actionTcode = "Resources\\Icons\\s_f_okay.gif";
        public const string iconSystem = "Resources\\Icons\\s_system.gif";
        public const string actionExec = "Resources\\Icons\\s_b_exec.gif";
        private const string actionErr = "Resources\\Icons\\s_m_erro.gif";

        private FuncaoMenuDAO FuncaoMenuDAO;

        private FuncaoSubMenuDAO SubMenuDAO;

        private IList<FuncaoMenu> FuncoesMenu;

        public Form FormPrincipal;

        private object sender;

        public IList<FuncaoSubMenu> transacoes;

        public FormUtil(Form principal)
        {
            this.FormPrincipal = principal;
            FuncaoMenuDAO = new FuncaoMenuDAO();
            SubMenuDAO = new FuncaoSubMenuDAO();
        }

        public void CallTransacao(Principal Parent, string transacao)
        {
            Boolean tcode = false;

            this.FormPrincipal.Cursor = Cursors.WaitCursor;

            for(int i = 0; i < transacoes.Count; i++)
            {
                if(transacoes[i].Transacao == transacao)
                {
                    tcode = true;
                    break;
                }
            }

            if (tcode) { 
                FuncaoSubMenu SubMenu = SubMenuDAO.FindByTransacao(transacao);
                if (SubMenu != null)
                {
                    if (SubMenu.Acao.ToString() != "")
                    {
                        foreach (Form form in this.FormPrincipal.MdiChildren)
                        {
                            form.Close();
                        }
                        Form frmShow = (Form)GetInstance(SubMenu.Acao.ToString());
                        frmShow.MdiParent = Parent;
                        frmShow.WindowState = FormWindowState.Maximized;
                        int x = 1;
                        int y = 2;
                        frmShow.Location = new Point(x, y);
                        frmShow.ControlBox = false;
                        this.FormPrincipal.Cursor = Cursors.Default;
                        frmShow.Show();
                        frmShow.Focus();
                    }
                }
            }
            else
            {
                this.FormPrincipal.Cursor = Cursors.Default;
                Parent.exibirMessage(actionErr, "Transação " + transacao + " não existe!", "E");
            }
        }
        public void MenuStripDB(Form Parent, MenuStrip MnuStrip)
        {
            MnuStrip = new MenuStrip();
            Parent.Controls.Add(MnuStrip);
            transacoes = new List<FuncaoSubMenu>();
            Usuario usuario = UtilObject.Deserialize<Usuario>("\\usuarios.dat");
            if (usuario != null)
            {
                FuncoesMenu = FuncaoMenuDAO.FindByUsuario(usuario.Bname);

                if (FuncoesMenu != null && FuncoesMenu.Count > 0)
                {
                    for (int i = 0; i < FuncoesMenu.Count; i++)
                    {
                        FuncaoMenu FncMenu = FuncoesMenu[i];

                        ToolStripMenuItem item = new ToolStripMenuItem(FncMenu.Menu)
                        {
                            Name = FncMenu.Menu,
                            Text = FncMenu.Descricao
                        };

                        if (FncMenu.FuncoesSubMenu != null && FncMenu.FuncoesSubMenu.Count > 0)
                        {
                            for (int j = 0; j < FncMenu.FuncoesSubMenu.Count; j++)
                            {
                                FuncaoSubMenu sub = FncMenu.FuncoesSubMenu[j];
                                if (sub.Superior == "")
                                {
                                    ToolStripMenuItem ItemAux = new ToolStripMenuItem
                                    {
                                        Name = sub.SubMenu,
                                        Text = sub.Descricao
                                    };
                                    item.DropDownItems.Add(ItemAux);
                                   
                                }
                                else
                                {

                                    SetToolsMenu(item.DropDownItems, sub);
                                }
                            }

                            MnuStrip.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void SetToolsMenu(ToolStripItemCollection menus, FuncaoSubMenu sub)
        {
            foreach (object obj in menus)
            {
                if (obj.GetType().Equals(typeof(ToolStripMenuItem)))
                {
                    ToolStripMenuItem subMenu = (ToolStripMenuItem)obj;

                    if (subMenu.Name == sub.Superior)
                    {
                        ToolStripMenuItem ItemMenu = (ToolStripMenuItem)subMenu;
                        if (sub.Acao != null && sub.Acao != "")
                        {
                            ToolStripMenuItem SSMenu = new ToolStripMenuItem(sub.Acao.ToString(), null,
                                new EventHandler(ChildClick))
                            {
                                Name = sub.Acao,
                                Text = sub.Descricao
                            };
                            ItemMenu.DropDownItems.Add(SSMenu);
                            if (sub.Transacao != "")
                                transacoes.Add(sub);
                        }
                        else
                        {
                            ToolStripMenuItem SSMenu = new ToolStripMenuItem
                            {
                                Name = sub.SubMenu,
                                Text = sub.Descricao
                            };
                            ItemMenu.DropDownItems.Add(SSMenu);
                            if (sub.Transacao != "")
                                transacoes.Add(sub);
                        }
                    }
                    else if (subMenu.HasDropDownItems)
                    {
                        SetToolsMenu(subMenu.DropDownItems, sub);
                    }
                   
                }
            }
        }
    
        private void ChildClick(object sender, EventArgs e)
        {
            this.sender = sender;
            if (sender.ToString() != "")
            {
                String acao = ((ToolStripMenuItem)sender).Name;


                foreach (Form form in this.FormPrincipal.MdiChildren)
                {
                    form.Close();
                }

                Form frmShow = (Form)GetInstance(acao);
                frmShow.MdiParent = this.FormPrincipal;
                frmShow.WindowState = FormWindowState.Maximized;
                int x = 1;
                int y = 2;
                frmShow.Location = new Point(x, y);
                frmShow.ControlBox = false;

                frmShow.Show();
                frmShow.Focus();
            }
        
        }

        public object GetInstance(string strFullyQualifiedName)
        {
            Type type = Type.GetType(strFullyQualifiedName);
            if (type != null)
                return Activator.CreateInstance(type,FormPrincipal);
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                type = asm.GetType(strFullyQualifiedName);
                if (type != null)
                    return Activator.CreateInstance(type, FormPrincipal);
            }
            return null;
        }

        public static void Resize(Principal principal, Form form)
        {
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
            form.Size = new Size(principal.Width - 20, principal.Height- 130);
        }

        public IList<FuncaoSubMenu> GetTransacoes()
        {
            return this.transacoes;
        }

        public static void GetMessage(String acao, String message)
        {
            IList<String> messages = new List<String>();
            messages.Add(message);
            MessageForm dlg = new MessageForm(acao, messages);
            dlg.ShowDialog();
        }

    }

}
