namespace acegi.Regionais
{
    partial class FrmPaises
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaises));
            this.dataPaises = new System.Windows.Forms.DataGridView();
            this.splitPais = new System.Windows.Forms.SplitContainer();
            this.ValPosicionar = new System.Windows.Forms.Button();
            this.DataPais = new System.Windows.Forms.DataGridView();
            this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDadosGerais = new System.Windows.Forms.GroupBox();
            this.BtnF4Pais = new System.Windows.Forms.Button();
            this.ValIdioma = new System.Windows.Forms.TextBox();
            this.lbIdioma = new System.Windows.Forms.Label();
            this.ValCodIso = new System.Windows.Forms.TextBox();
            this.lbIso = new System.Windows.Forms.Label();
            this.ValNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.ValPais = new System.Windows.Forms.TextBox();
            this.lbPais = new System.Windows.Forms.Label();
            this.menuFormPaises = new System.Windows.Forms.MenuStrip();
            this.menuPaises = new System.Windows.Forms.ToolStripMenuItem();
            this.toolPaises = new System.Windows.Forms.ToolStrip();
            this.toolStrip01 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnVoltar = new System.Windows.Forms.ToolStripButton();
            this.BtnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip02 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStrip03 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStrip05 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStrip04 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnClose = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataPaises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPais)).BeginInit();
            this.splitPais.Panel1.SuspendLayout();
            this.splitPais.Panel2.SuspendLayout();
            this.splitPais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPais)).BeginInit();
            this.groupDadosGerais.SuspendLayout();
            this.menuFormPaises.SuspendLayout();
            this.toolPaises.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataPaises
            // 
            this.dataPaises.AllowUserToOrderColumns = true;
            this.dataPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPaises.Location = new System.Drawing.Point(0, -1);
            this.dataPaises.Name = "dataPaises";
            this.dataPaises.Size = new System.Drawing.Size(417, 554);
            this.dataPaises.TabIndex = 0;
            // 
            // splitPais
            // 
            this.splitPais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPais.Location = new System.Drawing.Point(0, 0);
            this.splitPais.Name = "splitPais";
            // 
            // splitPais.Panel1
            // 
            this.splitPais.Panel1.Controls.Add(this.ValPosicionar);
            this.splitPais.Panel1.Controls.Add(this.DataPais);
            this.splitPais.Panel1Collapsed = true;
            // 
            // splitPais.Panel2
            // 
            this.splitPais.Panel2.Controls.Add(this.groupDadosGerais);
            this.splitPais.Panel2.Controls.Add(this.menuFormPaises);
            this.splitPais.Size = new System.Drawing.Size(742, 743);
            this.splitPais.SplitterDistance = 142;
            this.splitPais.TabIndex = 1;
            // 
            // ValPosicionar
            // 
            this.ValPosicionar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ValPosicionar.FlatAppearance.BorderSize = 0;
            this.ValPosicionar.Location = new System.Drawing.Point(164, 569);
            this.ValPosicionar.Name = "ValPosicionar";
            this.ValPosicionar.Size = new System.Drawing.Size(90, 29);
            this.ValPosicionar.TabIndex = 3;
            this.ValPosicionar.Text = "Posicionar";
            this.ValPosicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ValPosicionar.UseVisualStyleBackColor = true;
            this.ValPosicionar.Click += new System.EventHandler(this.ValPosicionar_Click);
            // 
            // DataPais
            // 
            this.DataPais.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataPais.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DataPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pais,
            this.Nome});
            this.DataPais.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.DataPais.Location = new System.Drawing.Point(3, 28);
            this.DataPais.Name = "DataPais";
            this.DataPais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataPais.Size = new System.Drawing.Size(412, 522);
            this.DataPais.TabIndex = 0;
            this.DataPais.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataPais_CellDoubleClick);
            // 
            // Pais
            // 
            this.Pais.HeaderText = "Pais";
            this.Pais.Name = "Pais";
            this.Pais.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Pais.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Pais.Width = 70;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Nome.Width = 260;
            // 
            // groupDadosGerais
            // 
            this.groupDadosGerais.BackColor = System.Drawing.SystemColors.Window;
            this.groupDadosGerais.Controls.Add(this.BtnF4Pais);
            this.groupDadosGerais.Controls.Add(this.ValIdioma);
            this.groupDadosGerais.Controls.Add(this.lbIdioma);
            this.groupDadosGerais.Controls.Add(this.ValCodIso);
            this.groupDadosGerais.Controls.Add(this.lbIso);
            this.groupDadosGerais.Controls.Add(this.ValNome);
            this.groupDadosGerais.Controls.Add(this.lbNome);
            this.groupDadosGerais.Controls.Add(this.ValPais);
            this.groupDadosGerais.Controls.Add(this.lbPais);
            this.groupDadosGerais.Location = new System.Drawing.Point(10, 42);
            this.groupDadosGerais.Name = "groupDadosGerais";
            this.groupDadosGerais.Size = new System.Drawing.Size(393, 199);
            this.groupDadosGerais.TabIndex = 0;
            this.groupDadosGerais.TabStop = false;
            this.groupDadosGerais.Text = "Dados Geráis";
            // 
            // BtnF4Pais
            // 
            this.BtnF4Pais.AutoSize = true;
            this.BtnF4Pais.BackColor = System.Drawing.SystemColors.Window;
            this.BtnF4Pais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnF4Pais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnF4Pais.ForeColor = System.Drawing.SystemColors.Menu;
            this.BtnF4Pais.Location = new System.Drawing.Point(215, 115);
            this.BtnF4Pais.Name = "BtnF4Pais";
            this.BtnF4Pais.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnF4Pais.Size = new System.Drawing.Size(39, 20);
            this.BtnF4Pais.TabIndex = 8;
            this.BtnF4Pais.UseVisualStyleBackColor = false;
            this.BtnF4Pais.Click += new System.EventHandler(this.BtnF4Pais_Click);
            // 
            // ValIdioma
            // 
            this.ValIdioma.Location = new System.Drawing.Point(91, 115);
            this.ValIdioma.Name = "ValIdioma";
            this.ValIdioma.Size = new System.Drawing.Size(128, 20);
            this.ValIdioma.TabIndex = 7;
            // 
            // lbIdioma
            // 
            this.lbIdioma.AutoSize = true;
            this.lbIdioma.Location = new System.Drawing.Point(26, 118);
            this.lbIdioma.Name = "lbIdioma";
            this.lbIdioma.Size = new System.Drawing.Size(38, 13);
            this.lbIdioma.TabIndex = 6;
            this.lbIdioma.Text = "Idioma";
            // 
            // ValCodIso
            // 
            this.ValCodIso.Location = new System.Drawing.Point(91, 63);
            this.ValCodIso.Name = "ValCodIso";
            this.ValCodIso.Size = new System.Drawing.Size(128, 20);
            this.ValCodIso.TabIndex = 5;
            // 
            // lbIso
            // 
            this.lbIso.AutoSize = true;
            this.lbIso.Location = new System.Drawing.Point(26, 66);
            this.lbIso.Name = "lbIso";
            this.lbIso.Size = new System.Drawing.Size(47, 13);
            this.lbIso.TabIndex = 4;
            this.lbIso.Text = "Cod.ISO";
            // 
            // ValNome
            // 
            this.ValNome.Location = new System.Drawing.Point(91, 89);
            this.ValNome.Name = "ValNome";
            this.ValNome.Size = new System.Drawing.Size(128, 20);
            this.ValNome.TabIndex = 3;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(26, 92);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome";
            // 
            // ValPais
            // 
            this.ValPais.Location = new System.Drawing.Point(91, 37);
            this.ValPais.Name = "ValPais";
            this.ValPais.Size = new System.Drawing.Size(48, 20);
            this.ValPais.TabIndex = 1;
            // 
            // lbPais
            // 
            this.lbPais.AutoSize = true;
            this.lbPais.Location = new System.Drawing.Point(26, 40);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(29, 13);
            this.lbPais.TabIndex = 0;
            this.lbPais.Text = "País";
            // 
            // menuFormPaises
            // 
            this.menuFormPaises.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPaises});
            this.menuFormPaises.Location = new System.Drawing.Point(0, 0);
            this.menuFormPaises.Name = "menuFormPaises";
            this.menuFormPaises.Size = new System.Drawing.Size(742, 24);
            this.menuFormPaises.TabIndex = 1;
            this.menuFormPaises.Text = "Paises";
            // 
            // menuPaises
            // 
            this.menuPaises.Name = "menuPaises";
            this.menuPaises.Size = new System.Drawing.Size(51, 20);
            this.menuPaises.Text = "Paises";
            // 
            // toolPaises
            // 
            this.toolPaises.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolPaises.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip01,
            this.BtnVoltar,
            this.BtnEdit,
            this.toolStrip02,
            this.BtnNew,
            this.toolStrip03,
            this.BtnDelete,
            this.toolStrip05,
            this.BtnSave,
            this.toolStrip04,
            this.BtnClose});
            this.toolPaises.Location = new System.Drawing.Point(0, 0);
            this.toolPaises.Name = "toolPaises";
            this.toolPaises.Size = new System.Drawing.Size(742, 25);
            this.toolPaises.TabIndex = 2;
            this.toolPaises.Text = "toolIdioma";
            // 
            // toolStrip01
            // 
            this.toolStrip01.Name = "toolStrip01";
            this.toolStrip01.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("BtnVoltar.Image")));
            this.BtnVoltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(23, 22);
            this.BtnVoltar.Text = "toolStripButton1";
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
            // BtnClose
            // 
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(62, 22);
            this.BtnClose.Text = "Fechar";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click_1);
            // 
            // FrmPaises
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(742, 743);
            this.ControlBox = false;
            this.Controls.Add(this.toolPaises);
            this.Controls.Add(this.splitPais);
            this.Controls.Add(this.dataPaises);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuFormPaises;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPaises";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Paises";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmPaises_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataPaises)).EndInit();
            this.splitPais.Panel1.ResumeLayout(false);
            this.splitPais.Panel2.ResumeLayout(false);
            this.splitPais.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPais)).EndInit();
            this.splitPais.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataPais)).EndInit();
            this.groupDadosGerais.ResumeLayout(false);
            this.groupDadosGerais.PerformLayout();
            this.menuFormPaises.ResumeLayout(false);
            this.menuFormPaises.PerformLayout();
            this.toolPaises.ResumeLayout(false);
            this.toolPaises.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataPaises;
        private System.Windows.Forms.SplitContainer splitPais;
        private System.Windows.Forms.ToolStrip toolPaises;
        private System.Windows.Forms.ToolStripSeparator toolStrip01;
        private System.Windows.Forms.ToolStripButton BtnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStrip02;
        private System.Windows.Forms.ToolStripButton BtnNew;
        private System.Windows.Forms.ToolStripSeparator toolStrip03;
        private System.Windows.Forms.ToolStripButton BtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStrip05;
        private System.Windows.Forms.ToolStripButton BtnSave;
        private System.Windows.Forms.ToolStripSeparator toolStrip04;
        private System.Windows.Forms.ToolStripButton BtnClose;
        private System.Windows.Forms.DataGridView DataPais;
        private System.Windows.Forms.GroupBox groupDadosGerais;
        private System.Windows.Forms.Label lbPais;
        private System.Windows.Forms.TextBox ValPais;
        private System.Windows.Forms.TextBox ValNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.ToolStripButton BtnVoltar;
        private System.Windows.Forms.TextBox ValCodIso;
        private System.Windows.Forms.Label lbIso;
        private System.Windows.Forms.TextBox ValIdioma;
        private System.Windows.Forms.Label lbIdioma;
        private System.Windows.Forms.MenuStrip menuFormPaises;
        private System.Windows.Forms.ToolStripMenuItem menuPaises;
        private System.Windows.Forms.Button BtnF4Pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.Button ValPosicionar;
    }
}