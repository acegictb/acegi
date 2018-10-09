using acegi.Dao;
using acegi.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace acegi.Util
{
    public partial class DlgFormIdiomas : Form
    {
        private const string actionUp = "Resources\\Icons\\s_tot_up.gif";
        private const string actionDown = "Resources\\Icons\\s_tot_do.gif";
        private const string actionOK = "Resources\\Icons\\s_f_okay.gif";
        private const string actionFilter = "Resources\\Icons\\s_b_filt.gif";
        private const string actionClose = "Resources\\Icons\\s_b_clos.gif";
        private const string iconSystem = "Resources\\Icons\\s_system.gif";

        private IdiomaDAO idiomaDAO;

        private IList<Idioma> idiomas;

        public string CodIdioma;
        public DlgFormIdiomas()
        {
            try
            {
                InitializeComponent();

                this.Cursor = Cursors.WaitCursor;

                Image image = Image.FromFile(iconSystem);
                Bitmap bitmap = new Bitmap(image);
                this.Icon = Icon.FromHandle(bitmap.GetHicon());

                image = Image.FromFile(actionDown);
                BtnColapse.Image = image;
                image = Image.FromFile(actionOK);
                BtnOK.Image = image;
                image = Image.FromFile(actionFilter);
                BtnFiltrar.Image = image;
                image = Image.FromFile(actionClose);
                BtnSair.Image = image;
                
                SplitDlgFilter.Panel1Collapsed = true;
                SplitDlgFilter.Panel2Collapsed = false;
                idiomaDAO = new IdiomaDAO();
                
                idiomas = idiomaDAO.FindByCountAndFilter(50, "", "");
                if (idiomas != null)
                {
                    for (int i = 0; i < idiomas.Count; i++)
                    {
                        DataGridViewRow row = (DataGridViewRow)DataIdiomas.Rows[0].Clone();
                        row.Cells[0].Value = idiomas[i].Langu;
                        row.Cells[0].ReadOnly = true;
                        row.Cells[0].Style.BackColor = Color.LightSlateGray;
                        row.Cells[1].Value = idiomas[i].Denominacao;
                        row.Cells[1].ReadOnly = true;
                        row.Cells[1].Style.BackColor = Color.LightGray;
                        DataIdiomas.Rows.Add(row);
                    }
                }
                this.Cursor = Cursors.Default;
                this.CodIdioma = "";
                ValIdioma.Clear();
                ValDescricao.Clear();
                ValLinhas.Text = "50";

                DataIdiomas.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(this, ex.Message, "Erro Pesquisa Idiomas",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnColapse_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (SplitDlgFilter.Panel1Collapsed)
                {
                    SplitDlgFilter.Panel1Collapsed = false;
                    Image image = Image.FromFile(actionUp);
                    BtnColapse.Image = image;
                    ValIdioma.Focus();
                }
                else
                {
                    SplitDlgFilter.Panel1Collapsed = true;
                    Image image = Image.FromFile(actionDown);
                    BtnColapse.Image = image;
                }

                SplitDlgFilter.Panel2Collapsed = false;
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(this, ex.Message, "Erro Pesquisa Idiomas",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                int count = Int32.Parse(ValLinhas.Text);
                idiomas = idiomaDAO.FindByCountAndFilter(count, ValIdioma.Text.ToString(), ValDescricao.Text.ToString());
                DataIdiomas.Rows.Clear();
                if (idiomas != null)
                {
                    for (int i = 0; i < idiomas.Count; i++)
                    {
                        DataIdiomas.Rows.Add();
                        DataIdiomas.Rows[i].Cells[0].Value = idiomas[i].Langu;
                        DataIdiomas.Rows[i].Cells[0].ReadOnly = true;
                        DataIdiomas.Rows[i].Cells[0].Style.BackColor = Color.LightSlateGray;
                        DataIdiomas.Rows[i].Cells[1].Value = idiomas[i].Denominacao;
                        DataIdiomas.Rows[i].Cells[1].ReadOnly = true;
                        DataIdiomas.Rows[i].Cells[1].Style.BackColor = Color.LightGray;
                    }
                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBoxEx.Show(this, ex.Message, "Erro Pesquisa Idiomas",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                for (int i = 0; i < DataIdiomas.Rows.Count; i++)
                {
                    if (DataIdiomas.Rows[i].Selected)
                    {
                        this.CodIdioma = DataIdiomas.Rows[i].Cells[0].Value.ToString();
                        break;
                    }
                }
                this.Cursor = Cursors.Default;
                this.Close();
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBoxEx.Show(this, ex.Message, "Erro Pesquisa Idiomas",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(this, ex.Message, "Erro Pesquisa Idiomas",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DlgFormIdiomas_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(this, ex.Message, "Erro Pesquisa Idiomas",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
