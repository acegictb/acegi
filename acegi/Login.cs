using acegi.Dao;
using acegi.MODEL;
using acegi.Util;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace acegi
{
    public partial class Login : Form
    {
        private bool isLogin;

        private UsuarioDAO usuarioDAO;

        private const string iconSystem = "Resources\\Icons\\s_system.gif";

        public bool IsLogin { get => isLogin; set => isLogin = value; }

        private MaterialSkinManager material;
        public Login()
        {
            InitializeComponent();
            Image image = Image.FromFile(iconSystem);
            Bitmap bitmap = new Bitmap(image);
            this.Icon = Icon.FromHandle(bitmap.GetHicon());
            usuarioDAO = new UsuarioDAO();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            isLogin = false;
            this.Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            ActionLogin();
        }

        private void ValSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ActionLogin();
            }
        }

        private void ActionLogin()
        {
            try
            {
                Usuario usuario = usuarioDAO.FindByUsuario(ValUsuario.Text.Trim());
                if (usuario != null)
                {
                    if (usuario.Senha == ValSenha.Text.Trim())
                    {
                        isLogin = true;
                        this.Close();
                        UtilObject.Serialize<Usuario>("\\usuarios.dat", usuario);
                    }
                    else
                    {
                        isLogin = false;
                    }
                }

                if (!isLogin)
                    MessageBoxEx.Show(this, "Usuário ou senhá incorreta!", "Erro Autenticação",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(this, ex.Message, "Erro Autenticação",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
