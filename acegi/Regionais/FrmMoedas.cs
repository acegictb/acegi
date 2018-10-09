using acegi.Dao;
using acegi.Model;
using acegi.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace acegi.Regionais
{
    public partial class FrmMoedas : Form
    {

        private const string actionEdit = "Resources\\Icons\\s_b_dpch.gif";
        private const string actionSave = "Resources\\Icons\\s_f_save.gif";
        private const string actionClose = "Resources\\Icons\\s_b_clos.gif";
        private const string actionDelete = "Resources\\Icons\\s_b_dele.gif";
        private const string iconSystem = "Resources\\Icons\\s_system.gif";
        private const string actionBack = "Resources\\Icons\\s_f_back.gif";
        private const string actionUp = "Resources\\Icons\\s_tot_up.gif";
        private const string actionDown = "Resources\\Icons\\s_tot_do.gif";
        private const string actionFilter = "Resources\\Icons\\s_b_filt.gif";
        private const string actionOK = "Resources\\Icons\\s_f_okay.gif";

        private Principal principal;

        private Boolean IsInsert = false;

        private Boolean IsEdit = false;

        private MoedaDAO moedaDAO;

        private IList<Moeda> moedas;

        private Thread popula_dados;

        public FrmMoedas(Principal principal)
        {
            
            InitializeComponent();

            this.principal = principal;

            SplitMoedas.Panel1Collapsed = false;
            SplitMoedas.Panel2Collapsed = true;
            SplitMoedas.Refresh();

            SplitListaPais.Panel1Collapsed = true;
            SplitListaPais.Panel2Collapsed = false;
            SplitListaPais.Refresh();

            Image image = Image.FromFile(iconSystem);
            Bitmap bitmap = new Bitmap(image);
            this.Icon = Icon.FromHandle(bitmap.GetHicon());

            FormUtil.Resize(principal, this);

            image = Image.FromFile(actionEdit);
            BtnEdit.Image = image;

            image = Image.FromFile(actionFilter);
            BtnFFiltrar.Image = image;

            image = Image.FromFile(actionSave);
            BtnSave.Image = image;

            image = Image.FromFile(actionClose);
            BtnClose.Image = image;

            image = Image.FromFile(actionDelete);
            BtnDelete.Image = image;

            image = Image.FromFile(actionBack);
            BtnVoltar.Image = image;

            image = Image.FromFile(actionUp);
            BtnFiltrar.Image = image;

            BtnEdit.Enabled = true;
            BtnNew.Enabled = false;
            BtnSave.Enabled = false;
            BtnDelete.Enabled = false;
            BtnVoltar.Visible = false;

            ValDesde.Mask = "00/00/0000";

            this.IsInsert = false;
            this.IsEdit = false;

            popula_dados = new Thread(Inicializa);
            popula_dados.IsBackground = true;
            popula_dados.Start();

            DataMoedas.Focus();

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }catch(Exception ex)
            {
                MessageBoxEx.Show(this, ex.Message, "Erro Moedas",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PopulaDados()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                DataMoedas.Rows.Clear();
                moedas = moedaDAO.FindAll();
                for (int i = 0; i < moedas.Count; i++)
                {
                    DataMoedas.Rows.Add();
                    DataMoedas.Rows[i].Cells[0].Value = moedas[i].Waers;
                    DataMoedas.Rows[i].Cells[0].ReadOnly = true;
                    DataMoedas.Rows[i].Cells[0].Style.BackColor = Color.LightSlateGray;
                    DataMoedas.Rows[i].Cells[1].Value = moedas[i].Tcurc;
                    DataMoedas.Rows[i].Cells[1].ReadOnly = true;
                    DataMoedas.Rows[i].Cells[1].Style.BackColor = Color.LightSlateGray;
                    DataMoedas.Rows[i].Cells[2].Value = moedas[i].Descricao;
                    DataMoedas.Rows[i].Cells[2].ReadOnly = true;
                    DataMoedas.Rows[i].Cells[2].Style.BackColor = Color.LightGray;
                    DataMoedas.Rows[i].Cells[3].ReadOnly = true;
                    DataMoedas.Rows[i].Cells[3].Style.BackColor = Color.LightGray;
                    if (moedas[i].Primario == "X")
                    {
                        DataMoedas.Rows[i].Cells[3].Value = true;
                    }
                    else
                    {
                        DataMoedas.Rows[i].Cells[3].Value = false;
                    }
                }
                DataMoedas.Rows[0].Selected = true;
                DataMoedas.AllowUserToAddRows = false;
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBoxEx.Show(this, ex.Message, "Erro Moedas",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            BtnEdit.Visible = true;

            if (BtnNew.Enabled)
            {
                BtnNew.Enabled = false;
            }
            else
            {
                BtnNew.Enabled = true;
            }

            if (BtnSave.Enabled)
            {
                BtnSave.Enabled = false;
            }
            else
            {
                if (SplitListaPais.Panel1Collapsed)
                {
                    BtnSave.Enabled = false;
                }
                else
                {
                    BtnSave.Enabled = true;
                }
            }

            if (BtnDelete.Enabled)
            {
                BtnDelete.Enabled = false;
            }
            else
            {
                BtnDelete.Enabled = true;
            }

            if (IsEdit)
            {
                IsEdit = false;
            }
            else
            {
                IsEdit = true;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBoxEx.Show(DataMoedas, "Deseja excluir registros!", "Confirmação",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    this.Cursor = Cursors.WaitCursor;
                    for (int i = 0; i < DataMoedas.Rows.Count; i++)
                    {
                        if (DataMoedas.Rows[i].Selected)
                        {
                            Moeda pais = moedaDAO.FindByWaers(DataMoedas.Rows[i].Cells[0].Value.ToString());
                            if (pais != null)
                            {
                                moedaDAO.Delete(pais);
                                DataMoedas.Rows.RemoveAt(i);
                            }
                        }
                    }
                    this.Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBoxEx.Show(this, ex.Message, "Erro Moedas",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataMoedas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String waers = DataMoedas.Rows[e.RowIndex].Cells[0].Value.ToString();

                if (waers != "")
                {
                    Moeda moeda = moedaDAO.FindByWaers(waers);

                    if (moeda != null)
                    {
                        ValMoeda.Text = moeda.Waers;
                        ValIso.Text = moeda.Tcurc;
                        ValDescricao.Text = moeda.Descricao;
                        ValDecimal.Text = moeda.Cdecimal;
                        if (moeda.Primario == "X")
                        {
                            ValPrimario.Checked = true;
                        }
                        else
                        {
                            ValPrimario.Checked = false;
                        }
                        if (!moeda.ValDesde.ToString().Equals("01/01/0001 00:00:00"))
                        {
                            ValDesde.Text = moeda.ValDesde.ToString();
                        }
                        else
                        {
                            ValDesde.Text = "";
                        }
                    }

                    SplitMoedas.Panel1Collapsed = true;
                    SplitMoedas.Panel2Collapsed = false;
                    BtnEdit.Visible = false;
                    BtnVoltar.Visible = true;
                    
                    SplitMoedas.Refresh();

                    if (this.IsEdit || this.IsInsert)
                    {
                        BtnSave.Enabled = true;
                        BtnDelete.Enabled = false;
                        BtnNew.Enabled = false;
                        ValDecimal.Enabled = true;
                        ValDescricao.Enabled = true;
                        ValDesde.Enabled = true;
                        ValFCheckPrimario.Enabled = true;
                        ValFMoeda.Enabled = true;
                        ValMoeda.Enabled = true;
                        ValIso.Enabled = true;
                    }
                    else
                    {
                        ValDecimal.Enabled = false;
                        ValDescricao.Enabled = false;
                        ValDesde.Enabled = false;
                        ValFCheckPrimario.Enabled = false;
                        ValFMoeda.Enabled = false;
                        ValMoeda.Enabled = false;
                        ValIso.Enabled = false;
                    }

                    if (IsEdit)
                        ValDescricao.Focus();

                    if (IsInsert)
                        ValMoeda.Focus();

                    BtnFiltrar.Visible = false;
                    toolStrip06.Visible = false;

                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(this, ex.Message, "Erro Moedas",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            BtnVoltar.Visible = false;
            BtnEdit.Visible = true;
            IsInsert = false;
            SplitMoedas.Panel1Collapsed = false;
            SplitMoedas.Panel2Collapsed = true;
            BtnFiltrar.Visible = true;
            toolStrip06.Visible = true;
            if (IsEdit)
            {
                BtnDelete.Enabled = true;
                BtnNew.Enabled = true;
            }
            else
            {
                BtnDelete.Enabled = false;
                BtnNew.Enabled = false;
            }
        }

        private void FrmMoedas_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Escape)
                {
                    BtnVoltar.Visible = false;
                    BtnEdit.Visible = true;
                    BtnFiltrar.Visible = true;
                    toolStrip06.Visible = true;
                    if (this.IsEdit || this.IsInsert)
                    {

                        if (SplitMoedas.Panel1Collapsed == true)
                        {
                            SplitMoedas.Panel1Collapsed = false;
                            SplitMoedas.Panel2Collapsed = true;
                            BtnSave.Enabled = false;
                            if (IsEdit)
                            {
                                BtnDelete.Enabled = true;
                                BtnNew.Enabled = true;
                            }
                            else
                            {
                                BtnDelete.Enabled = false;
                                BtnNew.Enabled = false;
                            }
                            SplitMoedas.Refresh();
                        }
                        else
                        {
                            BtnNew.Enabled = false;
                            BtnSave.Enabled = false;
                            BtnDelete.Enabled = false;
                            IsEdit = false;
                            IsInsert = false;
                        }

                    }
                    else
                    {
                        if (SplitMoedas.Panel1Collapsed == true)
                        {
                            SplitMoedas.Panel1Collapsed = false;
                            SplitMoedas.Panel2Collapsed = true;
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
                MessageBoxEx.Show(this, ex.Message, "Erro Moedas",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            SplitMoedas.Panel1Collapsed = true;
            SplitMoedas.Panel2Collapsed = false;
            ValMoeda.Enabled = true;
            ValIso.Enabled = true;
            ValDecimal.Enabled = true;
            ValDescricao.Enabled = true;
            ValDesde.Enabled = true;
            ValDescricao.Text = "";
            ValPrimario.Checked = false;
            ValDecimal.Text = "";
            ValIso.Text = "";
            ValMoeda.Text = "";
            SplitMoedas.Refresh();
            ValMoeda.Focus();
            IsInsert = true;
            BtnFiltrar.Visible = false;
            BtnNew.Enabled = false;
            BtnDelete.Enabled = false;
            BtnSave.Enabled = true;
            toolStrip06.Visible = false;
            ValDesde.Text = "";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.Salvar();
        }

        private void Salvar()
        {
            try
            {
                if (this.BtnSave.Enabled)
                {
                    if (ValMoeda.Text == "")
                    {
                        MessageBoxEx.Show(DataMoedas, "Código da moeda é obrigatório!", "Erro Moedas",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ValMoeda.Focus();
                    }
                    else
                    {
                        this.Cursor = Cursors.WaitCursor;
                        Moeda moeda = moedaDAO.FindByWaers(ValMoeda.Text);
                        if (moeda == null)
                            moeda = new Moeda();

                        moeda.Waers = ValMoeda.Text;
                        moeda.Tcurc = ValIso.Text;
                        moeda.Descricao = ValDescricao.Text;
                        moeda.Cdecimal = ValDecimal.Text;

                        if (ValPrimario.Checked)
                        {
                            moeda.Primario = "X";
                        }
                        else
                        {
                            moeda.Primario = "";
                        }

                        string waers = ValDesde.Text.Replace("/", "");
                        waers = waers.Trim();
                        if(waers != "")
                            moeda.ValDesde = DateTime.ParseExact(waers, "ddMMyyyy", CultureInfo.InvariantCulture);
                       

                        if (moeda.Id == 0)
                        {
                            moedaDAO.Persist(moeda);

                            popula_dados = new Thread(Inicializa);
                            popula_dados.IsBackground = true;
                            popula_dados.Start();
                        }
                        else
                        {
                            moedaDAO.Merge(moeda);
                            int index = DataMoedas.CurrentCell.RowIndex;
                            DataMoedas.Rows[index].Cells[0].Value = moeda.Tcurc;
                            DataMoedas.Rows[index].Cells[1].Value = moeda.Descricao;
                            if(moeda.Primario == "X")
                            {
                                DataMoedas.Rows[index].Cells[2].Value = true;
                            }
                            else
                            {
                                DataMoedas.Rows[index].Cells[2].Value = false;
                            }

                        }

                        this.Cursor = Cursors.Default;
                        var message = "Moeda "+ ValDescricao.Text +" salva com sucesso...";
                        this.principal.exibirMessage(actionOK, message, "S");

                        FormUtil.GetMessage(actionOK, message);
                        this.principal.HideExecucao();

                        if (this.IsInsert)
                        {
                            ValMoeda.Focus();
                        }
                        else
                        {
                            ValDescricao.Focus();
                        }
                    }
                }
            }catch(Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBoxEx.Show(this, ex.Message, "Erro Moedas",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMoedas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.S))
            {
                this.Salvar();
            }
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (SplitListaPais.Panel1Collapsed)
                {
                    SplitListaPais.Panel1Collapsed = false;
                    Image image = Image.FromFile(actionDown);
                    BtnFiltrar.Image = image;
                }
                else
                {
                    SplitListaPais.Panel1Collapsed = true;
                    Image image = Image.FromFile(actionUp);
                    BtnFiltrar.Image = image;
                }

                SplitListaPais.Panel2Collapsed = false;
                ValFMoeda.Focus();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(this, ex.Message, "Erro Pesquisa Moedas",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                this.moedaDAO = new MoedaDAO();
                this.PopulaDados();
            }
        }

        private void BtnFFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                String IsPrimario = "";

                if (ValFCheckPrimario.Checked)
                    IsPrimario = "X";

                IList<Moeda> moedas = moedaDAO.FindByCountAndFilter(ValFMoeda.Text, ValFDescricao.Text, IsPrimario);

                if(moedas != null && moedas.Count > 0)
                {
                    DataMoedas.Rows.Clear();
                    for (int i = 0; i < moedas.Count; i++)
                    {
                        DataMoedas.Rows.Add();
                        DataMoedas.Rows[i].Cells[0].Value = moedas[i].Waers;
                        DataMoedas.Rows[i].Cells[0].ReadOnly = true;
                        DataMoedas.Rows[i].Cells[0].Style.BackColor = Color.LightSlateGray;
                        DataMoedas.Rows[i].Cells[1].Value = moedas[i].Tcurc;
                        DataMoedas.Rows[i].Cells[1].ReadOnly = true;
                        DataMoedas.Rows[i].Cells[1].Style.BackColor = Color.LightSlateGray;
                        DataMoedas.Rows[i].Cells[2].Value = moedas[i].Descricao;
                        DataMoedas.Rows[i].Cells[2].ReadOnly = true;
                        DataMoedas.Rows[i].Cells[2].Style.BackColor = Color.LightGray;
                        DataMoedas.Rows[i].Cells[3].ReadOnly = true;
                        DataMoedas.Rows[i].Cells[3].Style.BackColor = Color.LightGray;
                        if (moedas[i].Primario == "X")
                        {
                            DataMoedas.Rows[i].Cells[3].Value = true;
                        }
                        else
                        {
                            DataMoedas.Rows[i].Cells[3].Value = false;
                        }
                    }
                    DataMoedas.Rows[0].Selected = true;
                    DataMoedas.AllowUserToAddRows = false;
                }
                this.Cursor = Cursors.Default;

            }
            catch(Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBoxEx.Show(this, ex.Message, "Erro Pesquisa Moedas",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
