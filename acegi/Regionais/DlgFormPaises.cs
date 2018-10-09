using acegi.Dao;
using acegi.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace acegi.Util
{
    partial class DlgFormPaises : Form
    {
        private const string actionUp = "Resources\\Icons\\s_tot_up.gif";
        private const string actionDown = "Resources\\Icons\\s_tot_do.gif";
        private const string actionOK = "Resources\\Icons\\s_f_okay.gif";
        private const string actionClose = "Resources\\Icons\\s_b_clos.gif";
        private const string actionFilter = "Resources\\Icons\\s_b_filt.gif";

        private PaisDAO paisDAO;

        private IList<Pais> paises;

        public string CodPais;
        public DlgFormPaises()
        {
            InitializeComponent();
            this.Cursor = Cursors.WaitCursor;
            Image image = Image.FromFile(actionDown);
            BtnColapse.Image = image;
            image = Image.FromFile(actionOK);
            BtnOK.Image = image;
            image = Image.FromFile(actionClose);
            BtnSair.Image = image;
            image = Image.FromFile(actionFilter);
            BtnFiltrar.Image = image;
            SplitDlgFilter.Panel1Collapsed = true;
            SplitDlgFilter.Panel2Collapsed = false;

            paisDAO = new PaisDAO();
            paises = paisDAO.FindByCountAndFilter(50, "", "");
            if (paises != null)
            {
                DataPaises.Rows.Clear();
                for (int i = 0; i < paises.Count; i++)
                {
                    DataPaises.Rows.Add();
                    DataPaises.Rows[i].Cells[0].Value = paises[i].Land;
                    DataPaises.Rows[i].Cells[0].ReadOnly = true;
                    DataPaises.Rows[i].Cells[0].Style.BackColor = Color.LightSlateGray;
                    DataPaises.Rows[i].Cells[1].Value = paises[i].Nome;
                    DataPaises.Rows[i].Cells[1].ReadOnly = true;
                    DataPaises.Rows[i].Cells[1].Style.BackColor = Color.LightGray;
                }
            }
            this.CodPais = "";
            ValPais.Clear();
            ValNome.Clear();
            ValLinhas.Text = "50";
            this.Cursor = Cursors.Default;
            DataPaises.AllowUserToAddRows = false;
        }

        private void BtnColapse_Click(object sender, EventArgs e)
        {
            if (SplitDlgFilter.Panel1Collapsed)
            {
                SplitDlgFilter.Panel1Collapsed = false;
                Image image = Image.FromFile(actionUp);
                BtnColapse.Image = image;
            }
            else
            {
                SplitDlgFilter.Panel1Collapsed = true;
                Image image = Image.FromFile(actionDown);
                BtnColapse.Image = image;
            }

            if(SplitDlgFilter.Panel1Collapsed == false)
            {
                ValPais.Focus();
            }

            SplitDlgFilter.Panel2Collapsed = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void DlgFormPaises_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                int count = Int32.Parse(ValLinhas.Text);
                paises = paisDAO.FindByCountAndFilter(count, ValPais.Text.ToString(), ValNome.Text.ToString());
                DataPaises.Rows.Clear();
                if (paises != null)
                {
                    for (int i = 0; i < paises.Count; i++)
                    {
                        DataPaises.Rows.Add();
                        DataPaises.Rows[i].Cells[0].Value = paises[i].Land;
                        DataPaises.Rows[i].Cells[0].ReadOnly = true;
                        DataPaises.Rows[i].Cells[0].Style.BackColor = Color.LightSlateGray;
                        DataPaises.Rows[i].Cells[1].Value = paises[i].Nome;
                        DataPaises.Rows[i].Cells[1].ReadOnly = true;
                        DataPaises.Rows[i].Cells[1].Style.BackColor = Color.LightGray;
                    }
                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBoxEx.Show(this, ex.Message, "Erro Pesquisa Paises",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                for (int i = 0; i < DataPaises.Rows.Count; i++)
                {
                    if (DataPaises.Rows[i].Selected)
                    {
                        this.CodPais = DataPaises.Rows[i].Cells[0].Value.ToString();
                        break;
                    }
                }
                this.Cursor = Cursors.Default;
                this.Close();
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBoxEx.Show(this, ex.Message, "Erro Pesquisa Paises",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
