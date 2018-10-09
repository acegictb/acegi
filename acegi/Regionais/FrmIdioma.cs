using acegi.Dao;
using acegi.Model;
using acegi.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace acegi.Regionais
{
    public partial class FrmIdioma : Form
    {
        private const string actionEdit = "Resources\\Icons\\s_b_dpch.gif";
        private const string actionSave = "Resources\\Icons\\s_f_save.gif";
        private const string actionClose = "Resources\\Icons\\s_b_clos.gif";
        private const string actionDelete = "Resources\\Icons\\s_b_dele.gif";
        private const string iconSystem = "Resources\\Icons\\s_system.gif";
        private const string iconPosn = "Resources\\Icons\\s_b_posn.gif";
        private const string actionOK = "Resources\\Icons\\s_f_okay.gif";
        private const string actionErr = "Resources\\Icons\\s_m_erro.gif";

        private IdiomaDAO idiomaDAO;

        private IList<Idioma> idiomas;

        private Principal principal;

        private FormUtil FrmUtil;

        private Boolean IsEdit;

        private Boolean IsInsert;

        public FrmIdioma(Principal principal)
        {
            try
            {
                InitializeComponent();

                this.IsEdit = false;
                this.IsInsert = false;

                Image image = Image.FromFile(iconSystem);
                Bitmap bitmap = new Bitmap(image);
                this.Icon = Icon.FromHandle(bitmap.GetHicon());

                FormUtil.Resize(principal, this);

                idiomaDAO = new IdiomaDAO();

                idiomas = idiomaDAO.FindAllIdioma();

                image = Image.FromFile(actionEdit);
                BtnEdit.Image = image;

                image = Image.FromFile(iconPosn);
                ValPosicionar.Image = image;

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

                this.principal = principal;
               
                PopulaDados();
               
                FrmUtil = new FormUtil(principal);

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(DataIdioma, ex.Message, "Erro Idiomas",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNew_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.IsInsert = true;
                this.IsEdit = false;

                BtnEdit.Enabled = true;
                BtnNew.Enabled = false;
                BtnSave.Enabled = true;
                BtnDelete.Enabled = true;

                DataIdioma.AllowUserToAddRows = true;
                DataIdioma.Rows.Clear();
                for (int i = 0; i < 10; i++)
                {
                    DataIdioma.Rows.Add();
                    DataIdioma.Rows[i].Cells[0].ReadOnly = false;
                    DataIdioma.Rows[i].Cells[1].ReadOnly = false;
                    DataIdioma.Rows[i].Cells[2].ReadOnly = false;
                }
            }catch(Exception ex)
            {
                MessageBoxEx.Show(DataIdioma, ex.Message, "Erro Idiomas",
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
                MessageBoxEx.Show(DataIdioma, ex.Message, "Erro Idiomas",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsEdit)
                {
                    this.IsEdit = false;
                }
                else {
                    this.IsEdit = true;
                }
                
                this.IsInsert = false;

                if (this.IsEdit || this.IsInsert)
                {
                    for (int i = 0; i < DataIdioma.Rows.Count; i++)
                    {
                        if (DataIdioma.Rows[i].Cells[1].ReadOnly)
                        {
                            DataIdioma.Rows[i].Cells[2].ReadOnly = false;
                            DataIdioma.Rows[i].Cells[2].Style.BackColor = Color.White;
                            BtnEdit.Enabled = true;
                            BtnNew.Enabled = true;
                            BtnSave.Enabled = true;
                            BtnDelete.Enabled = true;
                        }
                        else
                        {
                            DataIdioma.Rows[i].Cells[1].ReadOnly = true;
                            DataIdioma.Rows[i].Cells[1].Style.BackColor = Color.LightGray;
                            BtnEdit.Enabled = true;
                            BtnNew.Enabled = true;
                            BtnSave.Enabled = false;
                            BtnDelete.Enabled = false;
                        }
                    }
                }
                else
                {
                    PopulaDados();
                    BtnEdit.Enabled = true;
                    BtnNew.Enabled = false;
                    BtnSave.Enabled = false;
                    BtnDelete.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(DataIdioma, ex.Message, "Erro Idiomas",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                IList<Idioma> idiomas = new List<Idioma>();

                for (int i = 0; i < DataIdioma.Rows.Count; i++)
                {
                    if(DataIdioma.Rows[i].Cells[0].Value != null && DataIdioma.Rows[i].Cells[1].Value != null
                        && DataIdioma.Rows[i].Cells[2].Value != null)
                    {

                        Idioma idioma = idiomaDAO.FindByLangu(DataIdioma.Rows[i].Cells[1].Value.ToString());
                        if(idioma == null)
                        {
                            idioma = new Idioma();
                        }

                        idioma.Spras = DataIdioma.Rows[i].Cells[0].Value.ToString();
                        idioma.Langu = DataIdioma.Rows[i].Cells[1].Value.ToString();
                        idioma.Denominacao = DataIdioma.Rows[i].Cells[2].Value.ToString();

                        idiomas.Add(idioma);
                    }
                   
                }

                if (idiomas != null && idiomas.Count > 0)
                {

                    for (int i = 0; i < idiomas.Count; i++)
                    {
                        if (idiomas[i].Id > 0)
                        {
                            idiomaDAO.Merge(idiomas[i]);
                        }
                        else
                        {
                            idiomaDAO.Persist(idiomas[i]);
                        }
                    }

                    var message = "Idioma(s) salvo com sucesso...";
                    this.principal.exibirMessage(actionOK, message, "S");
                    FormUtil.GetMessage(actionOK, message);
                    this.principal.HideExecucao();
                }
                else
                {
                    var message = "Dados nao salvo, campos obrigatórios...";
                    this.principal.exibirMessage(actionErr, message, "E");
                    FormUtil.GetMessage(actionErr, message);
                    this.principal.HideExecucao();
                }

                this.Cursor = Cursors.Default;
                DataIdioma.Focus();

            }
            catch(Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBoxEx.Show(DataIdioma, ex.Message, "Erro Idiomas",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataIdioma_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            for (int i = 0; i < DataIdioma.Rows.Count; i++)
            {
                if (DataIdioma.Rows[i].Cells[0].Value == null && DataIdioma.Rows[i].Cells[1].Value != null)
                {
                    e.Cancel = true;
                }

                if(DataIdioma.Rows[i].Cells[0].Value != null && DataIdioma.Rows[i].Cells[1].Value == null)
                {
                    e.Cancel = true;
                }
            }

            DataIdioma.Focus();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsInsert)
                {
                    for (int i = 0; i < DataIdioma.Rows.Count; i++)
                    {
                        if (DataIdioma.Rows[i].Selected)
                        {
                            UtilObject.DeleteSelected(DataIdioma);
                        }
                    }
                }
                else
                {

                    DialogResult result = MessageBoxEx.Show(DataIdioma, "Deseja excluir registros!", "Confirmação",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        IList<Idioma> ids = new List<Idioma>();

                        for (int i = 0; i < DataIdioma.Rows.Count; i++)
                        {
                            if (DataIdioma.Rows[i].Selected)
                            {
                                Idioma idioma = idiomaDAO.FindByLangu(DataIdioma.Rows[i].Cells[1].Value.ToString());
                                if (idioma != null)
                                {
                                    idiomaDAO.Delete(idioma);
                                }
                            }
                        }

                        UtilObject.DeleteSelected(DataIdioma);

                        this.principal.exibirMessage(actionOK, "Idioma(s) excluido com sucesso...", "S");
                        this.Cursor = Cursors.Default;
                    }
                }
            }
            catch(Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBoxEx.Show(DataIdioma, ex.Message, "Erro Idiomas",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DataIdioma.Focus();
        }

        private void FrmIdioma_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Escape)
                {
                    if (this.IsEdit || this.IsInsert)
                    {
                        PopulaDados();
                        
                        DataIdioma.AllowUserToAddRows = false;
                        BtnEdit.Enabled = true;
                        BtnNew.Enabled = false;
                        BtnSave.Enabled = false;
                        BtnDelete.Enabled = false;
                        this.IsEdit = false;
                        this.IsInsert = false;
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(DataIdioma, ex.Message, "Erro Idiomas",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ValPosicionar_Click(object sender, EventArgs e)
        {
            try
            {
                DlgIdiomaPosiciona DlgFilter = new DlgIdiomaPosiciona(this.principal);
                Point point = new Point(this.principal.Location.X + 100, this.principal.Location.Y + 300);
                DlgFilter.Location = point;
                DlgFilter.StartPosition = FormStartPosition.Manual;
                DlgFilter.ShowDialog();

                if (DlgFilter.CodIdioma != "")
                {
                    for(int i = 0; i < DataIdioma.Rows.Count; i++)
                    {
                        if(DataIdioma.Rows[i].Cells[0].Value.ToString() == DlgFilter.CodIdioma)
                        {
                            DataIdioma.CurrentCell = DataIdioma.Rows[i].Cells[0];
                            DataIdioma.Rows[i].Selected = true;
                            DataIdioma.FirstDisplayedScrollingRowIndex = i;
                            DataIdioma.Update();
                            break;
                        }
                    }
                }

            } catch(Exception ex)
            {
                MessageBoxEx.Show(DataIdioma, ex.Message, "Erro Idiomas",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulaDados()
        {
            this.Cursor = Cursors.WaitCursor;
            DataIdioma.Rows.Clear();
            
            idiomas = idiomaDAO.FindAllIdioma();
            for (int i = 0; i < idiomas.Count; i++)
            {
                DataIdioma.Rows.Add();
                DataIdioma.Rows[i].Cells[0].Value = idiomas[i].Spras;
                DataIdioma.Rows[i].Cells[0].ReadOnly = true;
                DataIdioma.Rows[i].Cells[0].Style.BackColor = Color.LightSlateGray;
                DataIdioma.Rows[i].Cells[1].Value = idiomas[i].Langu;
                DataIdioma.Rows[i].Cells[1].ReadOnly = true;
                DataIdioma.Rows[i].Cells[1].Style.BackColor = Color.LightSlateGray;
                DataIdioma.Rows[i].Cells[2].Value = idiomas[i].Denominacao;
                DataIdioma.Rows[i].Cells[2].ReadOnly = true;
                DataIdioma.Rows[i].Cells[2].Style.BackColor = Color.LightGray;
            }
            DataIdioma.AllowUserToAddRows = false;
            this.Cursor = Cursors.Default;
            DataIdioma.Focus();
        }

        
    }
}
