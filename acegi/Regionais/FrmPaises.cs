using acegi.Dao;
using acegi.Model;
using acegi.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace acegi.Regionais
{
    public partial class FrmPaises : Form
    {
        private const string actionEdit = "Resources\\Icons\\s_b_dpch.gif";
        private const string actionSave = "Resources\\Icons\\s_f_save.gif";
        private const string actionClose = "Resources\\Icons\\s_b_clos.gif";
        private const string actionDelete = "Resources\\Icons\\s_b_dele.gif";
        private const string actionBack = "Resources\\Icons\\s_f_back.gif";
        private const string actionF4Idioma = "Resources\\Icons\\s_f4help.gif";
        private const string iconSystem = "Resources\\Icons\\s_system.gif";
        private const string iconPosn = "Resources\\Icons\\s_b_posn.gif";
        private const string actionOK = "Resources\\Icons\\s_f_okay.gif";
        private const string actionErr = "Resources\\Icons\\s_m_erro.gif";

        private IList<Pais> paises;

        private PaisDAO paisDAO;

        private IdiomaDAO idiomaDAO;

        private Boolean IsInsert = false;

        private Boolean IsEdit = false;

        private Principal principal;

        private FormUtil FrmUtil;

        public FrmPaises(Principal principal)
        {
            try
            {
                this.principal = principal;
                FrmUtil = new FormUtil(principal);
                InitializeComponent();
                Image image = Image.FromFile(iconSystem);
                Bitmap bitmap = new Bitmap(image);
                this.Icon = Icon.FromHandle(bitmap.GetHicon());

                FormUtil.Resize(principal, this);

                splitPais.Panel1Collapsed = false;
                splitPais.Panel2Collapsed = true;
                splitPais.Refresh();
                idiomaDAO = new IdiomaDAO();
                paisDAO = new PaisDAO();

                PopulaData();

                image = Image.FromFile(actionEdit);
                BtnEdit.Image = image;

                image = Image.FromFile(actionSave);
                BtnSave.Image = image;

                image = Image.FromFile(actionClose);
                BtnClose.Image = image;

                image = Image.FromFile(actionDelete);
                BtnDelete.Image = image;

                image = Image.FromFile(actionBack);
                BtnVoltar.Image = image;

                image = Image.FromFile(iconPosn);
                ValPosicionar.Image = image;

                image = Image.FromFile(actionF4Idioma);
                BtnF4Pais.Image = image;

                BtnVoltar.Visible = false;
                BtnEdit.Enabled = true;
                BtnNew.Enabled = false;
                BtnSave.Enabled = false;
                BtnDelete.Enabled = false;
                BtnF4Pais.Enabled = false;

                IsEdit = false;
                IsInsert = false;

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(this, ex.Message, "Erro Paises",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(this, ex.Message, "Erro Paises",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            splitPais.Panel1Collapsed = true;
            splitPais.Panel2Collapsed = false;
            BtnF4Pais.Enabled = true;
            BtnEdit.Visible = false;
            BtnSave.Enabled = true;
            BtnDelete.Enabled = false;
            BtnVoltar.Visible = true;
            ValPais.Enabled = true;
            ValNome.Enabled = true;
            ValCodIso.Enabled = true;
            ValIdioma.Enabled = true;
            ValIdioma.Text = "";
            ValPais.Text = "";
            ValNome.Text = "";
            ValCodIso.Text = "";
            splitPais.Refresh();
            ValPais.Focus();
            IsInsert = true;
        }

        private void FrmPaises_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Escape)
                {
                    BtnVoltar.Visible = false;
                    BtnEdit.Visible = true;
                    if (this.IsEdit || this.IsInsert )
                    {
                        if (splitPais.Panel1Collapsed == true)
                        {
                            splitPais.Panel1Collapsed = false;
                            splitPais.Panel2Collapsed = true;
                            BtnSave.Enabled = false;
                            BtnNew.Enabled = true;
                            BtnDelete.Enabled = true;
                            splitPais.Refresh();
                        }
                        else
                        {
                            BtnNew.Enabled = false;
                            BtnSave.Enabled = false;
                            BtnDelete.Enabled = false;
                            BtnF4Pais.Enabled = false;
                            IsEdit = false;
                            IsInsert = false;
                            
                        }
                    }
                    else
                    {
                        if (splitPais.Panel1Collapsed == true)
                        {
                            splitPais.Panel1Collapsed = false;
                            splitPais.Panel2Collapsed = true;
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(this, ex.Message, "Erro Paises",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            BtnVoltar.Visible = false;
            BtnEdit.Visible = true;
            IsInsert = false;
            splitPais.Panel1Collapsed = false;
            splitPais.Panel2Collapsed = true;

            if (IsEdit)
            {
                BtnDelete.Enabled = true;
                BtnNew.Enabled = true;
                BtnSave.Enabled = false;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            BtnEdit.Visible = true;

            if (IsEdit)
            {
                IsEdit = false;
                BtnF4Pais.Enabled = false;
                BtnSave.Enabled = false;
                BtnDelete.Enabled = false;
                BtnNew.Enabled = false;
            }
            else
            {
                IsEdit = true;
                BtnF4Pais.Enabled = true;
                if (splitPais.Panel1Collapsed)
                {
                    BtnSave.Enabled = true;
                    BtnNew.Enabled = false;
                }
                else
                {
                    BtnSave.Enabled = false;
                    BtnNew.Enabled = true;
                }
                BtnDelete.Enabled = true;
                BtnNew.Enabled = true;
            }

        }

        private void DataPais_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Pais pais = paisDAO.FindByLand(DataPais.Rows[e.RowIndex].Cells[0].Value.ToString());

                if (pais != null)
                {
                    ValPais.Text = pais.Land;
                    ValCodIso.Text = pais.PaisIso;
                    ValIdioma.Text = pais.Langu;
                    ValNome.Text = pais.Nome;
                    if (pais.Idioma != null)
                    {
                        Idioma idioma = idiomaDAO.FindByID(pais.Idioma.Id);
                        if (idioma != null)
                            ValIdioma.Text = idioma.Langu;
                    }

                    splitPais.Panel1Collapsed = true;
                    splitPais.Panel2Collapsed = false;

                    if (this.IsEdit || this.IsInsert)
                    {
                        ValPais.Enabled = true;
                        ValCodIso.Enabled = true;
                        ValIdioma.Enabled = true;
                        ValNome.Enabled = true;

                        if (IsEdit)
                        {
                            BtnSave.Enabled = true;
                            ValPais.Enabled = false;
                            ValCodIso.Enabled = false;
                            BtnSave.Enabled = true;
                            ValNome.Focus();
                        }
                        if (IsInsert)
                        {
                            BtnSave.Enabled = true;
                            ValPais.Focus();
                        }
                    }
                    else
                    {
                        ValPais.Enabled = false;
                        ValCodIso.Enabled = false;
                        ValIdioma.Enabled = false;
                        ValNome.Enabled = false;
                    }

                    BtnEdit.Visible = false;
                    BtnVoltar.Visible = true;
                    BtnDelete.Enabled = false;
                    BtnNew.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(this, ex.Message, "Erro Paises",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (ValidaDados())
                {
                    Pais pais = paisDAO.FindByLand(ValPais.Text.ToString());
                    if (pais == null)
                        pais = new Pais();

                    if (ValIdioma.Text != "")
                    {
                        Idioma idioma = idiomaDAO.FindByLangu(ValIdioma.Text.ToString());
                        if (idioma != null)
                        {
                            pais.Idioma = idioma;
                        }
                    }

                    pais.Land = ValPais.Text.ToString();
                    pais.PaisIso = ValCodIso.Text.ToString();
                    pais.Nome = ValNome.Text.ToString();

                    if (pais.Id == 0)
                    {
                        paisDAO.Persist(pais);
                    }
                    else
                    {
                        paisDAO.Merge(pais);
                    }

                    this.Cursor = Cursors.Default;
                    var message = "Pais "+pais.Nome+" salvo com sucesso...";
                    this.principal.exibirMessage(actionOK, message, "S");

                    FormUtil.GetMessage(actionOK, message);
                    this.principal.HideExecucao();

                    if (pais.Id == 0)
                        ValPais.Focus();

                    if (pais.Id > 0)
                        ValNome.Focus();

                    this.PopulaData();

                }
                else
                {
                    this.Cursor = Cursors.Default;
                }
                
                
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;

                MessageBoxEx.Show(this, ex.Message, "Erro Paises",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private Boolean ValidaDados()
        {
            if(ValPais.Text == "")
            {
                this.principal.exibirMessage(actionErr, "Código do pais é obrigatório...", "E");
                return false;
            }

            if (ValCodIso.Text == "")
            {
                this.principal.exibirMessage(actionErr, "Código ISO do pais é obrigatório...", "E");
                return false;
            }

            return true;
        }

        private void BtnF4Pais_Click(object sender, EventArgs e)
        {
            try
            {
                DlgFormIdiomas DlgFilter = new DlgFormIdiomas();
                Point point = new Point(this.principal.Location.X + 100, this.principal.Location.Y + 100);
                DlgFilter.Location = point;
                DlgFilter.StartPosition = FormStartPosition.Manual;
                DlgFilter.ShowDialog();
                if (DlgFilter.CodIdioma != "")
                {
                    Idioma idioma = idiomaDAO.FindByLangu(DlgFilter.CodIdioma);
                    if (idioma != null)
                    {
                        ValIdioma.Text = idioma.Langu;
                        ValIdioma.Text = DlgFilter.CodIdioma;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(this, ex.Message, "Erro Paises",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBoxEx.Show(DataPais, "Deseja excluir registros!", "Confirmação",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    this.Cursor = Cursors.WaitCursor;
                    for (int i = 0; i < DataPais.Rows.Count; i++)
                    {
                        if (DataPais.Rows[i].Selected)
                        {
                            Pais pais = paisDAO.FindByLand(DataPais.Rows[i].Cells[0].Value.ToString());
                            if (pais != null)
                            {
                                paisDAO.Delete(pais);
                            }
                        }
                    }

                    PopulaData();
                    this.Cursor = Cursors.Default;

                    if (splitPais.Panel1Collapsed)
                    {
                        splitPais.Panel1Collapsed = false;
                        splitPais.Panel2Collapsed = true;
                    }

                    MessageBoxEx.Show(DataPais, "Pais(s) excluido(s) com sucesso!", "Atenção", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    
                    DataPais.Focus();
                }
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBoxEx.Show(this, ex.Message, "Erro Paises",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulaData()
        {
            try {
                this.Cursor = Cursors.WaitCursor;
                DataPais.Rows.Clear();
                paises = paisDAO.FindAll();
                for (int i = 0; i < paises.Count; i++)
                {
                    DataPais.Rows.Add();
                    DataPais.Rows[i].Cells[0].Value = paises[i].Land;
                    DataPais.Rows[i].Cells[0].ReadOnly = true;
                    DataPais.Rows[i].Cells[0].Style.BackColor = Color.LightSlateGray;
                    DataPais.Rows[i].Cells[1].Value = paises[i].Nome;
                    DataPais.Rows[i].Cells[1].ReadOnly = true;
                    DataPais.Rows[i].Cells[1].Style.BackColor = Color.LightGray;
                }
                DataPais.Rows[0].Selected = true;
                DataPais.AllowUserToAddRows = false;
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBoxEx.Show(this, ex.Message, "Erro Paises",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValPosicionar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                DlgPaisPosiciona DlgFilter = new DlgPaisPosiciona(this.principal);
                Point point = new Point(this.principal.Location.X + 100, this.principal.Location.Y + 300);
                DlgFilter.Location = point;
                DlgFilter.StartPosition = FormStartPosition.Manual;
                DlgFilter.ShowDialog();

                if (DlgFilter.CodPais != "")
                {
                    for (int i = 0; i < DataPais.Rows.Count; i++)
                    {
                        if (DataPais.Rows[i].Cells[0].Value.ToString() == DlgFilter.CodPais)
                        {
                            DataPais.CurrentCell = DataPais.Rows[i].Cells[0];
                            DataPais.Rows[i].Selected = true;
                            DataPais.FirstDisplayedScrollingRowIndex = i;
                            DataPais.Update();
                            break;
                        }
                    }
                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBoxEx.Show(this, ex.Message, "Erro Paises",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
