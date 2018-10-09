namespace acegi.Regionais
{
    partial class FrmMoedas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMoedas));
            this.toolIdioma = new System.Windows.Forms.ToolStrip();
            this.ToolStrip01 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnVoltar = new System.Windows.Forms.ToolStripButton();
            this.BtnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip02 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStrip03 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStrip05 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStrip04 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnFiltrar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip06 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnClose = new System.Windows.Forms.ToolStripButton();
            this.SplitMoedas = new System.Windows.Forms.SplitContainer();
            this.SplitListaPais = new System.Windows.Forms.SplitContainer();
            this.DataMoedas = new System.Windows.Forms.DataGridView();
            this.Moeda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Primario = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GroupDadosMoeda = new System.Windows.Forms.GroupBox();
            this.ValDesde = new System.Windows.Forms.MaskedTextBox();
            this.ValDecimal = new System.Windows.Forms.TextBox();
            this.LbCasaDecimal = new System.Windows.Forms.Label();
            this.ValPrimario = new System.Windows.Forms.CheckBox();
            this.LbData = new System.Windows.Forms.Label();
            this.ValDescricao = new System.Windows.Forms.TextBox();
            this.LbDescricao = new System.Windows.Forms.Label();
            this.ValIso = new System.Windows.Forms.TextBox();
            this.LbISO = new System.Windows.Forms.Label();
            this.LbDivider001 = new System.Windows.Forms.Label();
            this.ValMoeda = new System.Windows.Forms.TextBox();
            this.LbMoeda = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LbFmoeda = new System.Windows.Forms.Label();
            this.ValFMoeda = new System.Windows.Forms.TextBox();
            this.ValFDescricao = new System.Windows.Forms.TextBox();
            this.LbFDescricao = new System.Windows.Forms.Label();
            this.ValFCheckPrimario = new System.Windows.Forms.CheckBox();
            this.BtnFFiltrar = new System.Windows.Forms.Button();
            this.toolIdioma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitMoedas)).BeginInit();
            this.SplitMoedas.Panel1.SuspendLayout();
            this.SplitMoedas.Panel2.SuspendLayout();
            this.SplitMoedas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitListaPais)).BeginInit();
            this.SplitListaPais.Panel1.SuspendLayout();
            this.SplitListaPais.Panel2.SuspendLayout();
            this.SplitListaPais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataMoedas)).BeginInit();
            this.GroupDadosMoeda.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolIdioma
            // 
            this.toolIdioma.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip01,
            this.BtnVoltar,
            this.BtnEdit,
            this.toolStrip02,
            this.BtnNew,
            this.toolStrip03,
            this.BtnDelete,
            this.toolStrip05,
            this.BtnSave,
            this.toolStrip04,
            this.BtnFiltrar,
            this.toolStrip06,
            this.BtnClose});
            this.toolIdioma.Location = new System.Drawing.Point(0, 0);
            this.toolIdioma.Name = "toolIdioma";
            this.toolIdioma.Size = new System.Drawing.Size(1000, 25);
            this.toolIdioma.TabIndex = 1;
            this.toolIdioma.Text = "toolIdioma";
            // 
            // ToolStrip01
            // 
            this.ToolStrip01.Name = "ToolStrip01";
            this.ToolStrip01.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("BtnVoltar.Image")));
            this.BtnVoltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(23, 22);
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(23, 22);
            this.BtnEdit.ToolTipText = "Editar";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // toolStrip02
            // 
            this.toolStrip02.Name = "toolStrip02";
            this.toolStrip02.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnNew
            // 
            this.BtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnNew.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.Image")));
            this.BtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(82, 22);
            this.BtnNew.Text = "Nova entrada";
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // toolStrip03
            // 
            this.toolStrip03.Name = "toolStrip03";
            this.toolStrip03.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnDelete
            // 
            this.BtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(23, 22);
            this.BtnDelete.ToolTipText = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // toolStrip05
            // 
            this.toolStrip05.Name = "toolStrip05";
            this.toolStrip05.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnSave
            // 
            this.BtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(23, 22);
            this.BtnSave.ToolTipText = "Salvar";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // toolStrip04
            // 
            this.toolStrip04.Name = "toolStrip04";
            this.toolStrip04.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnFiltrar.Image")));
            this.BtnFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(23, 22);
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // toolStrip06
            // 
            this.toolStrip06.Name = "toolStrip06";
            this.toolStrip06.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnClose
            // 
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(62, 22);
            this.BtnClose.Text = "Fechar";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // SplitMoedas
            // 
            this.SplitMoedas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitMoedas.Location = new System.Drawing.Point(0, 25);
            this.SplitMoedas.Name = "SplitMoedas";
            // 
            // SplitMoedas.Panel1
            // 
            this.SplitMoedas.Panel1.AutoScroll = true;
            this.SplitMoedas.Panel1.Controls.Add(this.SplitListaPais);
            // 
            // SplitMoedas.Panel2
            // 
            this.SplitMoedas.Panel2.AutoScroll = true;
            this.SplitMoedas.Panel2.Controls.Add(this.GroupDadosMoeda);
            this.SplitMoedas.Size = new System.Drawing.Size(1000, 636);
            this.SplitMoedas.SplitterDistance = 460;
            this.SplitMoedas.TabIndex = 2;
            // 
            // SplitListaPais
            // 
            this.SplitListaPais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitListaPais.Location = new System.Drawing.Point(0, 0);
            this.SplitListaPais.Name = "SplitListaPais";
            this.SplitListaPais.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitListaPais.Panel1
            // 
            this.SplitListaPais.Panel1.Controls.Add(this.groupBox1);
            // 
            // SplitListaPais.Panel2
            // 
            this.SplitListaPais.Panel2.Controls.Add(this.DataMoedas);
            this.SplitListaPais.Size = new System.Drawing.Size(460, 636);
            this.SplitListaPais.SplitterDistance = 133;
            this.SplitListaPais.TabIndex = 1;
            // 
            // DataMoedas
            // 
            this.DataMoedas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataMoedas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DataMoedas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMoedas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Moeda,
            this.Curr,
            this.Descricao,
            this.Primario});
            this.DataMoedas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataMoedas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.DataMoedas.Location = new System.Drawing.Point(0, 0);
            this.DataMoedas.Name = "DataMoedas";
            this.DataMoedas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataMoedas.Size = new System.Drawing.Size(460, 499);
            this.DataMoedas.TabIndex = 1;
            this.DataMoedas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataMoedas_CellDoubleClick);
            // 
            // Moeda
            // 
            this.Moeda.HeaderText = "Moeda";
            this.Moeda.Name = "Moeda";
            this.Moeda.Width = 60;
            // 
            // Curr
            // 
            this.Curr.HeaderText = "Curr";
            this.Curr.Name = "Curr";
            this.Curr.Width = 60;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 220;
            // 
            // Primario
            // 
            this.Primario.HeaderText = "Primário";
            this.Primario.Name = "Primario";
            this.Primario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Primario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Primario.Width = 60;
            // 
            // GroupDadosMoeda
            // 
            this.GroupDadosMoeda.BackColor = System.Drawing.SystemColors.Window;
            this.GroupDadosMoeda.Controls.Add(this.ValDesde);
            this.GroupDadosMoeda.Controls.Add(this.ValDecimal);
            this.GroupDadosMoeda.Controls.Add(this.LbCasaDecimal);
            this.GroupDadosMoeda.Controls.Add(this.ValPrimario);
            this.GroupDadosMoeda.Controls.Add(this.LbData);
            this.GroupDadosMoeda.Controls.Add(this.ValDescricao);
            this.GroupDadosMoeda.Controls.Add(this.LbDescricao);
            this.GroupDadosMoeda.Controls.Add(this.ValIso);
            this.GroupDadosMoeda.Controls.Add(this.LbISO);
            this.GroupDadosMoeda.Controls.Add(this.LbDivider001);
            this.GroupDadosMoeda.Controls.Add(this.ValMoeda);
            this.GroupDadosMoeda.Controls.Add(this.LbMoeda);
            this.GroupDadosMoeda.Location = new System.Drawing.Point(3, 3);
            this.GroupDadosMoeda.Name = "GroupDadosMoeda";
            this.GroupDadosMoeda.Size = new System.Drawing.Size(469, 319);
            this.GroupDadosMoeda.TabIndex = 0;
            this.GroupDadosMoeda.TabStop = false;
            this.GroupDadosMoeda.Text = "Dados Moeda";
            // 
            // ValDesde
            // 
            this.ValDesde.Location = new System.Drawing.Point(121, 122);
            this.ValDesde.Name = "ValDesde";
            this.ValDesde.Size = new System.Drawing.Size(143, 20);
            this.ValDesde.TabIndex = 12;
            // 
            // ValDecimal
            // 
            this.ValDecimal.Location = new System.Drawing.Point(121, 147);
            this.ValDecimal.Name = "ValDecimal";
            this.ValDecimal.Size = new System.Drawing.Size(60, 20);
            this.ValDecimal.TabIndex = 11;
            // 
            // LbCasaDecimal
            // 
            this.LbCasaDecimal.AutoSize = true;
            this.LbCasaDecimal.Location = new System.Drawing.Point(26, 151);
            this.LbCasaDecimal.Name = "LbCasaDecimal";
            this.LbCasaDecimal.Size = new System.Drawing.Size(82, 13);
            this.LbCasaDecimal.TabIndex = 10;
            this.LbCasaDecimal.Text = "Casas Decimais";
            // 
            // ValPrimario
            // 
            this.ValPrimario.AutoSize = true;
            this.ValPrimario.Location = new System.Drawing.Point(275, 33);
            this.ValPrimario.Name = "ValPrimario";
            this.ValPrimario.Size = new System.Drawing.Size(63, 17);
            this.ValPrimario.TabIndex = 9;
            this.ValPrimario.Text = "Primário";
            this.ValPrimario.UseVisualStyleBackColor = true;
            // 
            // LbData
            // 
            this.LbData.AutoSize = true;
            this.LbData.Location = new System.Drawing.Point(26, 125);
            this.LbData.Name = "LbData";
            this.LbData.Size = new System.Drawing.Size(41, 13);
            this.LbData.TabIndex = 7;
            this.LbData.Text = "Desde:";
            // 
            // ValDescricao
            // 
            this.ValDescricao.Location = new System.Drawing.Point(121, 95);
            this.ValDescricao.Name = "ValDescricao";
            this.ValDescricao.Size = new System.Drawing.Size(249, 20);
            this.ValDescricao.TabIndex = 6;
            // 
            // LbDescricao
            // 
            this.LbDescricao.AutoSize = true;
            this.LbDescricao.Location = new System.Drawing.Point(26, 99);
            this.LbDescricao.Name = "LbDescricao";
            this.LbDescricao.Size = new System.Drawing.Size(35, 13);
            this.LbDescricao.TabIndex = 5;
            this.LbDescricao.Text = "Desc.";
            // 
            // ValIso
            // 
            this.ValIso.Location = new System.Drawing.Point(121, 69);
            this.ValIso.Name = "ValIso";
            this.ValIso.Size = new System.Drawing.Size(60, 20);
            this.ValIso.TabIndex = 4;
            // 
            // LbISO
            // 
            this.LbISO.AutoSize = true;
            this.LbISO.Location = new System.Drawing.Point(26, 73);
            this.LbISO.Name = "LbISO";
            this.LbISO.Size = new System.Drawing.Size(40, 13);
            this.LbISO.TabIndex = 3;
            this.LbISO.Text = "CodIso";
            // 
            // LbDivider001
            // 
            this.LbDivider001.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LbDivider001.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbDivider001.Location = new System.Drawing.Point(0, 56);
            this.LbDivider001.Name = "LbDivider001";
            this.LbDivider001.Size = new System.Drawing.Size(468, 10);
            this.LbDivider001.TabIndex = 2;
            // 
            // ValMoeda
            // 
            this.ValMoeda.Location = new System.Drawing.Point(121, 31);
            this.ValMoeda.Name = "ValMoeda";
            this.ValMoeda.Size = new System.Drawing.Size(60, 20);
            this.ValMoeda.TabIndex = 1;
            // 
            // LbMoeda
            // 
            this.LbMoeda.AutoSize = true;
            this.LbMoeda.Location = new System.Drawing.Point(26, 35);
            this.LbMoeda.Name = "LbMoeda";
            this.LbMoeda.Size = new System.Drawing.Size(40, 13);
            this.LbMoeda.TabIndex = 0;
            this.LbMoeda.Text = "Moeda";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnFFiltrar);
            this.groupBox1.Controls.Add(this.ValFCheckPrimario);
            this.groupBox1.Controls.Add(this.ValFDescricao);
            this.groupBox1.Controls.Add(this.LbFDescricao);
            this.groupBox1.Controls.Add(this.ValFMoeda);
            this.groupBox1.Controls.Add(this.LbFmoeda);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // LbFmoeda
            // 
            this.LbFmoeda.AutoSize = true;
            this.LbFmoeda.Location = new System.Drawing.Point(22, 31);
            this.LbFmoeda.Name = "LbFmoeda";
            this.LbFmoeda.Size = new System.Drawing.Size(40, 13);
            this.LbFmoeda.TabIndex = 0;
            this.LbFmoeda.Text = "Moeda";
            // 
            // ValFMoeda
            // 
            this.ValFMoeda.Location = new System.Drawing.Point(25, 49);
            this.ValFMoeda.Name = "ValFMoeda";
            this.ValFMoeda.Size = new System.Drawing.Size(65, 20);
            this.ValFMoeda.TabIndex = 1;
            // 
            // ValFDescricao
            // 
            this.ValFDescricao.Location = new System.Drawing.Point(25, 92);
            this.ValFDescricao.Name = "ValFDescricao";
            this.ValFDescricao.Size = new System.Drawing.Size(216, 20);
            this.ValFDescricao.TabIndex = 3;
            // 
            // LbFDescricao
            // 
            this.LbFDescricao.AutoSize = true;
            this.LbFDescricao.Location = new System.Drawing.Point(22, 76);
            this.LbFDescricao.Name = "LbFDescricao";
            this.LbFDescricao.Size = new System.Drawing.Size(55, 13);
            this.LbFDescricao.TabIndex = 2;
            this.LbFDescricao.Text = "Descrição";
            // 
            // ValFCheckPrimario
            // 
            this.ValFCheckPrimario.AutoSize = true;
            this.ValFCheckPrimario.Location = new System.Drawing.Point(178, 49);
            this.ValFCheckPrimario.Name = "ValFCheckPrimario";
            this.ValFCheckPrimario.Size = new System.Drawing.Size(63, 17);
            this.ValFCheckPrimario.TabIndex = 10;
            this.ValFCheckPrimario.Text = "Primário";
            this.ValFCheckPrimario.UseVisualStyleBackColor = true;
            // 
            // BtnFFiltrar
            // 
            this.BtnFFiltrar.Location = new System.Drawing.Point(326, 27);
            this.BtnFFiltrar.Name = "BtnFFiltrar";
            this.BtnFFiltrar.Size = new System.Drawing.Size(79, 29);
            this.BtnFFiltrar.TabIndex = 11;
            this.BtnFFiltrar.Text = "Filtrar";
            this.BtnFFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFFiltrar.UseVisualStyleBackColor = true;
            this.BtnFFiltrar.Click += new System.EventHandler(this.BtnFFiltrar_Click);
            // 
            // FrmMoedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1000, 661);
            this.ControlBox = false;
            this.Controls.Add(this.SplitMoedas);
            this.Controls.Add(this.toolIdioma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMoedas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Moedas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMoedas_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmMoedas_KeyPress);
            this.toolIdioma.ResumeLayout(false);
            this.toolIdioma.PerformLayout();
            this.SplitMoedas.Panel1.ResumeLayout(false);
            this.SplitMoedas.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitMoedas)).EndInit();
            this.SplitMoedas.ResumeLayout(false);
            this.SplitListaPais.Panel1.ResumeLayout(false);
            this.SplitListaPais.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitListaPais)).EndInit();
            this.SplitListaPais.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataMoedas)).EndInit();
            this.GroupDadosMoeda.ResumeLayout(false);
            this.GroupDadosMoeda.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolIdioma;
        private System.Windows.Forms.ToolStripSeparator ToolStrip01;
        private System.Windows.Forms.ToolStripButton BtnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStrip02;
        private System.Windows.Forms.ToolStripButton BtnNew;
        private System.Windows.Forms.ToolStripSeparator toolStrip03;
        private System.Windows.Forms.ToolStripButton BtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStrip05;
        private System.Windows.Forms.ToolStripButton BtnSave;
        private System.Windows.Forms.ToolStripSeparator toolStrip04;
        private System.Windows.Forms.ToolStripButton BtnClose;
        private System.Windows.Forms.SplitContainer SplitMoedas;
        private System.Windows.Forms.ToolStripButton BtnVoltar;
        private System.Windows.Forms.GroupBox GroupDadosMoeda;
        private System.Windows.Forms.TextBox ValMoeda;
        private System.Windows.Forms.Label LbMoeda;
        private System.Windows.Forms.Label LbDivider001;
        private System.Windows.Forms.TextBox ValIso;
        private System.Windows.Forms.Label LbISO;
        private System.Windows.Forms.TextBox ValDescricao;
        private System.Windows.Forms.Label LbDescricao;
        private System.Windows.Forms.Label LbData;
        private System.Windows.Forms.CheckBox ValPrimario;
        private System.Windows.Forms.TextBox ValDecimal;
        private System.Windows.Forms.Label LbCasaDecimal;
        private System.Windows.Forms.ToolStripButton BtnFiltrar;
        private System.Windows.Forms.ToolStripSeparator toolStrip06;
        private System.Windows.Forms.SplitContainer SplitListaPais;
        private System.Windows.Forms.DataGridView DataMoedas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moeda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Primario;
        private System.Windows.Forms.MaskedTextBox ValDesde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LbFmoeda;
        private System.Windows.Forms.TextBox ValFMoeda;
        private System.Windows.Forms.TextBox ValFDescricao;
        private System.Windows.Forms.Label LbFDescricao;
        private System.Windows.Forms.CheckBox ValFCheckPrimario;
        private System.Windows.Forms.Button BtnFFiltrar;
    }
}