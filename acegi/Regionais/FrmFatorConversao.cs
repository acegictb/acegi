using acegi.Dao;
using acegi.Model;
using acegi.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acegi.Regionais
{
    public partial class FrmFatorConversao : Form
    {

        private const string actionEdit = "Resources\\Icons\\s_b_dpch.gif";
        private const string actionSave = "Resources\\Icons\\s_f_save.gif";
        private const string actionClose = "Resources\\Icons\\s_b_clos.gif";
        private const string actionDelete = "Resources\\Icons\\s_b_dele.gif";
        private const string iconSystem = "Resources\\Icons\\s_system.gif";
        private const string iconPosn = "Resources\\Icons\\s_b_posn.gif";
        private const string actionOK = "Resources\\Icons\\s_f_okay.gif";
        private const string actionErr = "Resources\\Icons\\s_m_erro.gif";

        private Principal principal;

        private FatorConversaoDAO fatorDAO;
        private CategoriaCambioDAO categoriaDAO;
        private MoedaDAO moedaDAO;

        private Thread popula_dados;

        private Boolean IsEdit;

        private Boolean IsInsert;

        private int row_current;

        private IList<FatorConversao> fatoresEditados;

        private IList<FatorConversao> fatoresInseridos;

        public FrmFatorConversao(Principal principal)
        {
            InitializeComponent();
            FormUtil.Resize(principal, this);

            this.principal = principal;

            Image image = Image.FromFile(iconSystem);
            Bitmap bitmap = new Bitmap(image);
            this.Icon = Icon.FromHandle(bitmap.GetHicon());

            image = Image.FromFile(actionEdit);
            BtnEdit.Image = image;

            image = Image.FromFile(actionSave);
            BtnSave.Image = image;

            image = Image.FromFile(actionClose);
            BtnClose.Image = image;

            image = Image.FromFile(actionDelete);
            BtnDelete.Image = image;

            BtnEdit.Enabled = true;
            BtnNew.Enabled = false;
            BtnSave.Enabled = false;
            BtnDelete.Enabled = false;
            DataFator.Visible = false;
            fatorDAO = new FatorConversaoDAO();
            categoriaDAO = new CategoriaCambioDAO();
            moedaDAO = new MoedaDAO();
            this.Cursor = Cursors.WaitCursor;

            this.principal.exibirExecucao("Carregando fatores de moedas...");
            popula_dados = new Thread(new ThreadStart(Inicializa));
            popula_dados.IsBackground = true;
            popula_dados.Start();
            popula_dados.Join();
            this.principal.HideExecucao();

            this.principal = principal;

            fatoresEditados = new List<FatorConversao>();
            fatoresInseridos = new List<FatorConversao>();

            IsEdit = false;
            IsInsert = false;
        }

        private void Inicializa()
        {
            lock (popula_dados)
            {
                InvokeInicializa();
            }

        }

        delegate void InicializaCallback();
        private void InvokeInicializa()
        {
            if (InvokeRequired)
            {
                InicializaCallback callback = InvokeInicializa;
                Invoke(callback);
            }
            else
            {
                DataFator.Cursor = Cursors.WaitCursor;
                this.PopulaDados();
                DataFator.Cursor = Cursors.Default;
                this.Cursor = Cursors.Default;
                DataFator.Focus();
            }
        }

        private void FrmFatorConversao_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Escape)
                {
                    if (this.IsEdit || this.IsInsert)
                    {
                        DataFator.AllowUserToAddRows = false;
                        BtnEdit.Enabled = true;
                        BtnNew.Enabled = false;
                        BtnSave.Enabled = false;
                        BtnDelete.Enabled = false;

                        if (IsInsert)
                        {
                            int rows = row_current + (DataFator.Rows.Count - row_current);

                            for (int i = row_current; i < rows; i++)
                            {
                                DataFator.Rows[i].Selected = true;
                            }


                            UtilObject.DeleteSelected(DataFator);
                        }

                        for (int i = 0; i < DataFator.Rows.Count; i++)
                        {
                            DataFator.Rows[i].Cells[0].ReadOnly = true;
                            DataFator.Rows[i].Cells[0].Style.BackColor = Color.LightSlateGray;
                            DataFator.Rows[i].Cells[1].ReadOnly = true;
                            DataFator.Rows[i].Cells[1].Style.BackColor = Color.LightSlateGray;
                            DataFator.Rows[i].Cells[2].ReadOnly = true;
                            DataFator.Rows[i].Cells[2].Style.BackColor = Color.LightSlateGray;
                            DataFator.Rows[i].Cells[3].ReadOnly = true;
                            DataFator.Rows[i].Cells[3].Style.BackColor = Color.LightGray;
                            DataFator.Rows[i].Cells[4].ReadOnly = true;
                            DataFator.Rows[i].Cells[4].Style.BackColor = Color.LightGray;
                            DataFator.Rows[i].Cells[6].ReadOnly = true;
                            DataFator.Rows[i].Cells[6].Style.BackColor = Color.LightGray;

                        }
                        row_current = 0;
                        IsEdit = false;
                        IsInsert = false;
                    }
                    else
                    {
                        this.Close();
                    }
                }
           }
            catch (Exception ex)
            {
                MessageBoxEx.Show(this, ex.Message, "Erro Fatores Conversão",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(this, ex.Message, "Erro Fatores Conversão",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PopulaDados()
        {
            try
            {
                IList<FatorConversao> fatores = fatorDAO.FindAll();

                if (fatores != null && fatores.Count > 0)
                {
                    DataFator.Rows.Clear();

                   for (int i = 0; i < fatores.Count; i++)
                    {
                        DataFator.Rows.Add();
                        if (fatores[i].Categoria != null && fatores[i].Categoria.Id > 0)
                        {
                            CategoriaCambio categoria = categoriaDAO.FindByID(fatores[i].Categoria.Id);
                            DataFator.Rows[i].Cells[0].Value = categoria.Kurst;
                        }
                        
                        DataFator.Rows[i].Cells[0].ReadOnly = true;
                        DataFator.Rows[i].Cells[0].Style.BackColor = Color.LightSlateGray;
                        DataFator.Rows[i].Cells[1].Value = fatores[i].Fcurr;
                        DataFator.Rows[i].Cells[1].ReadOnly = true;
                        DataFator.Rows[i].Cells[1].Style.BackColor = Color.LightSlateGray;
                        DataFator.Rows[i].Cells[2].Value = fatores[i].Waers;
                        DataFator.Rows[i].Cells[2].ReadOnly = true;
                        DataFator.Rows[i].Cells[2].Style.BackColor = Color.LightSlateGray;
                        DataFator.Rows[i].Cells[3].Value = fatores[i].ValDesde;
                        DataFator.Rows[i].Cells[3].ReadOnly = true;
                        DataFator.Rows[i].Cells[3].Style.BackColor = Color.LightGray;
                        DataFator.Rows[i].Cells[4].Value = fatores[i].Fator_Ori;
                        DataFator.Rows[i].Cells[4].ReadOnly = true;
                        DataFator.Rows[i].Cells[4].Style.BackColor = Color.LightGray;
                        DataFator.Rows[i].Cells[6].Value = fatores[i].Fator_Dst;
                        DataFator.Rows[i].Cells[6].ReadOnly = true;
                        DataFator.Rows[i].Cells[6].Style.BackColor = Color.LightGray;

                    }
                }
                DataFator.Visible = true;
            }
            catch(Exception ex)
            {
                DataFator.Cursor = Cursors.Default;
                this.Cursor = Cursors.Default;
                MessageBoxEx.Show(this, ex.Message, "Erro Fatores Conversão",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (IsEdit)
            {
                IsEdit = false;
                BtnDelete.Enabled = false;
                BtnNew.Enabled = false;
                BtnSave.Enabled = false;

                for (int i = 0; i < DataFator.Rows.Count; i++)
                {
                    DataFator.Rows[i].Cells[4].ReadOnly = true;
                    DataFator.Rows[i].Cells[4].Style.BackColor = Color.LightGray;
                    DataFator.Rows[i].Cells[6].ReadOnly = true;
                    DataFator.Rows[i].Cells[6].Style.BackColor = Color.LightGray;
                }
            }
            else
            {
                IsEdit = true;
                BtnDelete.Enabled = true;
                BtnNew.Enabled = true;
                BtnSave.Enabled = true;

                for(int i=0; i < DataFator.Rows.Count; i++)
                {
                    DataFator.Rows[i].Cells[4].ReadOnly = false;
                    DataFator.Rows[i].Cells[4].Style.BackColor = Color.White;
                    DataFator.Rows[i].Cells[6].ReadOnly = false;
                    DataFator.Rows[i].Cells[6].Style.BackColor = Color.White;
                }
            }
            this.Cursor = Cursors.Default;

            row_current = 0;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                row_current = 0;

                this.IsInsert = true;
                this.IsEdit = true;

                BtnEdit.Enabled = true;
                BtnNew.Enabled = false;
                BtnSave.Enabled = true;
                BtnDelete.Enabled = true;

                DataFator.AllowUserToAddRows = true;

                row_current = DataFator.Rows.Count - 1;

                for (int i = 0; i < 10; i++)
                {
                    DataFator.Rows.Add();
                    DataFator.Rows[i].Cells[0].ReadOnly = false;
                    DataFator.Rows[i].Cells[1].ReadOnly = false;
                    DataFator.Rows[i].Cells[2].ReadOnly = false;
                    DataFator.Rows[i].Cells[3].ReadOnly = false;
                    DataFator.Rows[i].Cells[4].ReadOnly = false;
                    DataFator.Rows[i].Cells[6].ReadOnly = false;
                }

                DataFator.CurrentCell = DataFator.Rows[row_current].Cells[0];
                DataFator.Rows[row_current].Selected = true;
                DataFator.FirstDisplayedScrollingRowIndex = row_current;
                DataFator.Update();
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(this, ex.Message, "Erro Fatores Conversão",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (IsEdit)
                {
                    for(int i=0; i < fatoresEditados.Count; i++)
                    {
                        fatorDAO.FindByID(fatoresEditados[i].Id);
                        fatorDAO.Merge(fatoresEditados[0]);
                    }
                    fatoresEditados = new List<FatorConversao>();
                }

                if (IsInsert)
                {

                }

                var message = "Fator(es) salvo(s) com sucesso...";
                this.principal.exibirMessage(actionOK, message, "S");
                FormUtil.GetMessage(actionOK, message);
                this.principal.HideExecucao();

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBoxEx.Show(this, ex.Message, "Erro Fatores Conversão",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DataFator_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Boolean ja_inserido = false;
            try
            {
                if (IsEdit)
                {
                    if (fatoresEditados == null)
                        fatoresEditados = new List<FatorConversao>();

                    string kurst = DataFator.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string fcurr = DataFator.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string waers = DataFator.Rows[e.RowIndex].Cells[2].Value.ToString();

                    FatorConversao fator = fatorDAO.FindByFator(kurst, fcurr, waers);

                    if (fator != null)
                    {

                        fator.Fator_Ori = Convert.ToDecimal(DataFator.Rows[e.RowIndex].Cells[4].Value.ToString());
                        fator.Fator_Dst = Convert.ToDecimal(DataFator.Rows[e.RowIndex].Cells[6].Value.ToString());

                        for (int i = 0; i < fatoresEditados.Count; i++)
                        {
                            if (fatoresEditados[i].Fcurr == fcurr && fatoresEditados[i].Waers == waers
                                && fatoresEditados[i].Kurst == kurst)
                            {
                                fatoresEditados[i].Fator_Ori = fator.Fator_Ori;
                                fatoresEditados[i].Fator_Dst = fator.Fator_Dst;
                                ja_inserido = true;
                                break;
                            }
                        }
                        if (!ja_inserido)
                        {
                            fatoresEditados.Add(fator);
                            ja_inserido = false;
                        }
                    }
                    else{

                    }
                    
                }
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(this, ex.Message, "Erro Fatores Conversão",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
