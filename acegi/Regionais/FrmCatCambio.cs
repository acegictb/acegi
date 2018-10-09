using acegi.Dao;
using acegi.Model;
using acegi.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace acegi.Regionais
{
    public partial class FrmCatCambio : Form
    {

        private const string actionEdit = "Resources\\Icons\\s_b_dpch.gif";
        private const string actionSave = "Resources\\Icons\\s_f_save.gif";
        private const string actionClose = "Resources\\Icons\\s_b_clos.gif";
        private const string actionDelete = "Resources\\Icons\\s_b_dele.gif";
        private const string iconSystem = "Resources\\Icons\\s_system.gif";
        private const string iconPosn = "Resources\\Icons\\s_b_posn.gif";
        private const string actionOK = "Resources\\Icons\\s_f_okay.gif";
        private const string actionUp = "Resources\\Icons\\s_tot_up.gif";
        private const string actionDown = "Resources\\Icons\\s_tot_do.gif";
        private const string actionErr = "Resources\\Icons\\s_m_erro.gif";
        private const string actionFilter = "Resources\\Icons\\s_b_filt.gif";

        private Principal principal;

        private Boolean IsEdit;

        private Boolean IsInsert;

        private FormUtil FrmUtil;

        private IList<CategoriaCambio> catCambios;

        private CategoriaCambioDAO catCambioDAO;

        public FrmCatCambio(Principal principal)
        {
            this.principal = principal;
            InitializeComponent();

            this.Cursor = Cursors.WaitCursor;

            catCambioDAO = new CategoriaCambioDAO();

            SplitCatCambio.Panel1Collapsed = true;
            SplitCatCambio.Panel2Collapsed = false;
            SplitCatCambio.Refresh();

            this.IsEdit = false;
            this.IsInsert = false;

            Image image = Image.FromFile(iconSystem);
            Bitmap bitmap = new Bitmap(image);
            this.Icon = Icon.FromHandle(bitmap.GetHicon());

            FormUtil.Resize(principal, this);

            image = Image.FromFile(actionEdit);
            BtnEdit.Image = image;

            image = Image.FromFile(actionSave);
            BtnSave.Image = image;

            image = Image.FromFile(actionClose);
            BtnClose.Image = image;

            image = Image.FromFile(actionDelete);
            BtnDelete.Image = image;

            image = Image.FromFile(actionUp);
            BtnFrmFiltro.Image = image;

            image = Image.FromFile(actionFilter);
            BtnFiltro.Image = image;

            BtnEdit.Enabled = true;
            BtnNew.Enabled = false;
            BtnSave.Enabled = false;
            BtnDelete.Enabled = false;

            this.principal = principal;

            FrmUtil = new FormUtil(principal);

            PopulaDados();

            this.Cursor = Cursors.Default;

        }

        private void FrmCatCambio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Escape)
                {
                    if (this.IsEdit || this.IsInsert)
                    {
                        BtnDelete.Enabled = false;
                        BtnNew.Enabled = false;
                        BtnSave.Enabled = false;
                        this.IsInsert = false;
                        this.IsEdit = false;
                        this.PopulaDados();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(this, ex.Message, "Erro Categoria Cambio",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(this, ex.Message, "Erro Categoria Cambio",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulaDados()
        {
            this.Cursor = Cursors.WaitCursor;
            DataCatCambio.Rows.Clear();
            catCambios = catCambioDAO.FindAll();
            for (int i = 0; i < catCambios.Count; i++)
            {
                DataCatCambio.Rows.Add();
                DataCatCambio.Rows[i].Cells[0].Value = catCambios[i].Kurst;
                DataCatCambio.Rows[i].Cells[0].ReadOnly = true;
                DataCatCambio.Rows[i].Cells[0].Style.BackColor = Color.LightSlateGray;
                DataCatCambio.Rows[i].Cells[1].Value = catCambios[i].Descricao;
                if (this.IsEdit)
                {
                    DataCatCambio.Rows[i].Cells[1].ReadOnly = false;
                    DataCatCambio.Rows[i].Cells[1].Style.BackColor = Color.White;
                }
                else
                {
                    DataCatCambio.Rows[i].Cells[1].ReadOnly = true;
                    DataCatCambio.Rows[i].Cells[1].Style.BackColor = Color.LightGray;
                }
            }
            DataCatCambio.AllowUserToAddRows = false;
            this.Cursor = Cursors.Default;
            DataCatCambio.Focus();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (this.IsEdit)
            {
                this.IsEdit = false;
                BtnNew.Enabled = false;
                BtnDelete.Enabled = false;
                BtnSave.Enabled = false;
            }
            else
            {
                this.IsEdit = true;
                BtnNew.Enabled = true;
                BtnDelete.Enabled = true;
                BtnSave.Enabled = true;
            }

            for (int i = 0; i < DataCatCambio.Rows.Count; i++)
            {
                if (this.IsEdit)
                {
                    DataCatCambio.Rows[i].Cells[1].ReadOnly = false;
                    DataCatCambio.Rows[i].Cells[1].Style.BackColor = Color.White;
                }
                else
                {
                    DataCatCambio.Rows[i].Cells[1].ReadOnly = true;
                    DataCatCambio.Rows[i].Cells[1].Style.BackColor = Color.LightGray;
                }
            }

        }

        private void BtnFrmFiltro_Click(object sender, EventArgs e)
        {
            try
            {
                if (SplitCatCambio.Panel1Collapsed)
                {
                    SplitCatCambio.Panel1Collapsed = false;
                    Image image = Image.FromFile(actionDown);
                    BtnFrmFiltro.Image = image;
                    ValCategoria.Focus();
                }
                else
                {
                    SplitCatCambio.Panel1Collapsed = true;
                    Image image = Image.FromFile(actionUp);
                    BtnFrmFiltro.Image = image;
                }

                SplitCatCambio.Panel2Collapsed = false;

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(this, ex.Message, "Erro Categoria cambio",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsInsert)
                {
                    UtilObject.DeleteSelected(DataCatCambio);
                }
                else
                {

                    DialogResult result = MessageBoxEx.Show(DataCatCambio, "Deseja excluir registros!", "Confirmação",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        this.Cursor = Cursors.WaitCursor;

                        IList<int> indexes = new List<int>();

                        for (int i = 0; i < DataCatCambio.Rows.Count; i++)
                        {
                            if (DataCatCambio.Rows[i].Selected)
                            {
                                CategoriaCambio categoria = catCambioDAO.FindByCategoria(DataCatCambio.Rows[i].Cells[0].Value.ToString());
                                if (categoria != null)
                                {
                                    catCambioDAO.Delete(categoria);
                                }
                            }
                        }
                        UtilObject.DeleteSelected(DataCatCambio);
                        this.Cursor = Cursors.Default;
                    }
                }

            }
            catch(Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBoxEx.Show(this, ex.Message, "Erro Categoria cambio",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                IList<CategoriaCambio> categorias = new List<CategoriaCambio>();

                for (int i = 0; i < DataCatCambio.Rows.Count; i++)
                {
                    if (DataCatCambio.Rows[i].Cells[0].Value != null && DataCatCambio.Rows[i].Cells[1].Value != null)
                    {
                        CategoriaCambio categoria = catCambioDAO.FindByCategoria(DataCatCambio.Rows[i].Cells[0].Value.ToString());
                        if (categoria == null)
                        {
                            categoria = new CategoriaCambio();
                        }

                        categoria.Kurst = DataCatCambio.Rows[i].Cells[0].Value.ToString();
                        categoria.Descricao = DataCatCambio.Rows[i].Cells[1].Value.ToString();

                        categorias.Add(categoria);
                    }
                }

                if(categorias.Count > 0)
                {
                    for(int i = 0; i < categorias.Count; i++)
                    {
                        CategoriaCambio categoria = catCambioDAO.FindByCategoria(categorias[i].Kurst);
                        if (categoria == null)
                            categoria = new CategoriaCambio();

                        categoria.Kurst = categorias[i].Kurst;
                        categoria.Descricao = categorias[i].Descricao;

                        if (categoria.Id > 0)
                        {
                            catCambioDAO.Merge(categoria);
                        }
                        else
                        {
                            catCambioDAO.Persist(categoria);
                        }

                    }

                    this.Cursor = Cursors.Default;
                    var message = "Idioma(s) salvo com sucesso...";
                    this.principal.exibirMessage(actionOK, "Idioma(s) salvo com sucesso...", "S");
                    FormUtil.GetMessage(actionOK, message);
                    this.principal.HideExecucao();
                }
                else
                {
                    this.Cursor = Cursors.Default;
                    var message = "Dados nao salvo, campos obrigatórios...";
                    this.principal.exibirMessage(actionErr, message, "S");

                    FormUtil.GetMessage(actionErr, message);
                    this.principal.HideExecucao();
                }
                
            }
            catch(Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBoxEx.Show(this, ex.Message, "Erro Categoria cambio",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnFiltro_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                IList<CategoriaCambio> categorias = catCambioDAO.FindByCategoriaDescricao(ValCategoria.Text.ToString(),
                    ValDescricao.Text.ToString());

                if(categorias != null && categorias.Count > 0)
                {
                    DataCatCambio.Rows.Clear();
                    for (int i = 0; i < categorias.Count; i++)
                    {
                        DataCatCambio.Rows.Add();
                        DataCatCambio.Rows[i].Cells[0].Value = categorias[i].Kurst;
                        DataCatCambio.Rows[i].Cells[0].ReadOnly = true;
                        DataCatCambio.Rows[i].Cells[0].Style.BackColor = Color.LightSlateGray;
                        DataCatCambio.Rows[i].Cells[1].Value = categorias[i].Descricao;
                        if (this.IsEdit)
                        {
                            DataCatCambio.Rows[i].Cells[1].ReadOnly = false;
                            DataCatCambio.Rows[i].Cells[1].Style.BackColor = Color.White;
                        }
                        else
                        {
                            DataCatCambio.Rows[i].Cells[1].ReadOnly = true;
                            DataCatCambio.Rows[i].Cells[1].Style.BackColor = Color.LightGray;
                        }
                    }
                    DataCatCambio.Focus();
                }

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBoxEx.Show(this, ex.Message, "Erro Categoria cambio",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {

            /*DataTable dt = new DataTable();

            String BASE_ICMS = "(PR00)/(( 100.0000 - ALIQ_ICMS)/100.0000)";

            double PR00 = 250000.4400;
            double ALIQ_ICMS = 18.0000;

            BASE_ICMS = BASE_ICMS.Replace("PR00", PR00.ToString()).Replace(",",".");
            BASE_ICMS = BASE_ICMS.Replace("ALIQ_ICMS", ALIQ_ICMS.ToString()).Replace(",", ".");

            Expression evaluation = new Expression(BASE_ICMS);

            Double base_icms = (Double)evaluation.Evaluate();

            double valores = Math.Round(base_icms, 4);

            MessageBoxEx.Show(this, valores.ToString(), valores.ToString(),
                           MessageBoxButtons.OK, MessageBoxIcon.Error);*/

            try
            {
                this.IsInsert = true;
                this.IsEdit = false;

                BtnEdit.Enabled = true;
                BtnNew.Enabled = false;
                BtnSave.Enabled = true;
                BtnDelete.Enabled = true;

                DataCatCambio.AllowUserToAddRows = true;
                DataCatCambio.Rows.Clear();
                for (int i = 0; i < 10; i++)
                {
                    DataCatCambio.Rows.Add();
                    DataCatCambio.Rows[i].Cells[0].ReadOnly = false;
                    DataCatCambio.Rows[i].Cells[1].ReadOnly = false;
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(DataCatCambio, ex.Message, "Erro Categoria cambio",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
