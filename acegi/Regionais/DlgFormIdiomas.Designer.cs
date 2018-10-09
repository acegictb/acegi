namespace acegi.Util
{
    partial class DlgFormIdiomas
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
            System.Windows.Forms.ToolStripSeparator ToolStrip002;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgFormIdiomas));
            this.SplitDlgFilter = new System.Windows.Forms.SplitContainer();
            this.GroupFiltro = new System.Windows.Forms.GroupBox();
            this.ValLinhas = new System.Windows.Forms.TextBox();
            this.LbLinhas = new System.Windows.Forms.Label();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.ValDescricao = new System.Windows.Forms.TextBox();
            this.LbDescricao = new System.Windows.Forms.Label();
            this.ValIdioma = new System.Windows.Forms.TextBox();
            this.LbIdioma = new System.Windows.Forms.Label();
            this.DataIdiomas = new System.Windows.Forms.DataGridView();
            this.Langu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Denominacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStrip001 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnOK = new System.Windows.Forms.ToolStripButton();
            this.BtnColapse = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip003 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnSair = new System.Windows.Forms.ToolStripButton();
            ToolStrip002 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.SplitDlgFilter)).BeginInit();
            this.SplitDlgFilter.Panel1.SuspendLayout();
            this.SplitDlgFilter.Panel2.SuspendLayout();
            this.SplitDlgFilter.SuspendLayout();
            this.GroupFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataIdiomas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip002
            // 
            ToolStrip002.Name = "ToolStrip002";
            ToolStrip002.Size = new System.Drawing.Size(6, 25);
            // 
            // SplitDlgFilter
            // 
            this.SplitDlgFilter.Location = new System.Drawing.Point(-1, 26);
            this.SplitDlgFilter.Name = "SplitDlgFilter";
            this.SplitDlgFilter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitDlgFilter.Panel1
            // 
            this.SplitDlgFilter.Panel1.Controls.Add(this.GroupFiltro);
            // 
            // SplitDlgFilter.Panel2
            // 
            this.SplitDlgFilter.Panel2.AutoScroll = true;
            this.SplitDlgFilter.Panel2.Controls.Add(this.DataIdiomas);
            this.SplitDlgFilter.Size = new System.Drawing.Size(367, 547);
            this.SplitDlgFilter.SplitterDistance = 196;
            this.SplitDlgFilter.TabIndex = 4;
            // 
            // GroupFiltro
            // 
            this.GroupFiltro.Controls.Add(this.ValLinhas);
            this.GroupFiltro.Controls.Add(this.LbLinhas);
            this.GroupFiltro.Controls.Add(this.BtnFiltrar);
            this.GroupFiltro.Controls.Add(this.ValDescricao);
            this.GroupFiltro.Controls.Add(this.LbDescricao);
            this.GroupFiltro.Controls.Add(this.ValIdioma);
            this.GroupFiltro.Controls.Add(this.LbIdioma);
            this.GroupFiltro.Location = new System.Drawing.Point(13, 16);
            this.GroupFiltro.Name = "GroupFiltro";
            this.GroupFiltro.Size = new System.Drawing.Size(343, 160);
            this.GroupFiltro.TabIndex = 0;
            this.GroupFiltro.TabStop = false;
            this.GroupFiltro.Text = "Filtro";
            // 
            // ValLinhas
            // 
            this.ValLinhas.Location = new System.Drawing.Point(43, 124);
            this.ValLinhas.Name = "ValLinhas";
            this.ValLinhas.Size = new System.Drawing.Size(55, 20);
            this.ValLinhas.TabIndex = 6;
            // 
            // LbLinhas
            // 
            this.LbLinhas.AutoSize = true;
            this.LbLinhas.Location = new System.Drawing.Point(43, 108);
            this.LbLinhas.Name = "LbLinhas";
            this.LbLinhas.Size = new System.Drawing.Size(38, 13);
            this.LbLinhas.TabIndex = 5;
            this.LbLinhas.Text = "Linhas";
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(251, 43);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.BtnFiltrar.TabIndex = 4;
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // ValDescricao
            // 
            this.ValDescricao.Location = new System.Drawing.Point(43, 85);
            this.ValDescricao.Name = "ValDescricao";
            this.ValDescricao.Size = new System.Drawing.Size(176, 20);
            this.ValDescricao.TabIndex = 3;
            // 
            // LbDescricao
            // 
            this.LbDescricao.AutoSize = true;
            this.LbDescricao.Location = new System.Drawing.Point(43, 69);
            this.LbDescricao.Name = "LbDescricao";
            this.LbDescricao.Size = new System.Drawing.Size(55, 13);
            this.LbDescricao.TabIndex = 2;
            this.LbDescricao.Text = "Descrição";
            // 
            // ValIdioma
            // 
            this.ValIdioma.Location = new System.Drawing.Point(43, 46);
            this.ValIdioma.Name = "ValIdioma";
            this.ValIdioma.Size = new System.Drawing.Size(66, 20);
            this.ValIdioma.TabIndex = 1;
            // 
            // LbIdioma
            // 
            this.LbIdioma.AutoSize = true;
            this.LbIdioma.Location = new System.Drawing.Point(43, 30);
            this.LbIdioma.Name = "LbIdioma";
            this.LbIdioma.Size = new System.Drawing.Size(38, 13);
            this.LbIdioma.TabIndex = 0;
            this.LbIdioma.Text = "Idioma";
            // 
            // DataIdiomas
            // 
            this.DataIdiomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataIdiomas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Langu,
            this.Denominacao});
            this.DataIdiomas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataIdiomas.Location = new System.Drawing.Point(0, 0);
            this.DataIdiomas.Name = "DataIdiomas";
            this.DataIdiomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataIdiomas.Size = new System.Drawing.Size(367, 347);
            this.DataIdiomas.TabIndex = 2;
            // 
            // Langu
            // 
            this.Langu.HeaderText = "Idioma";
            this.Langu.Name = "Langu";
            this.Langu.Width = 70;
            // 
            // Denominacao
            // 
            this.Denominacao.HeaderText = "Descrição";
            this.Denominacao.Name = "Denominacao";
            this.Denominacao.Width = 200;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip001,
            this.BtnOK,
            ToolStrip002,
            this.BtnColapse,
            this.ToolStrip003,
            this.BtnSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(367, 25);
            this.toolStrip1.TabIndex = 5;
            // 
            // ToolStrip001
            // 
            this.ToolStrip001.Name = "ToolStrip001";
            this.ToolStrip001.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnOK
            // 
            this.BtnOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnOK.Image = ((System.Drawing.Image)(resources.GetObject("BtnOK.Image")));
            this.BtnOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(23, 22);
            this.BtnOK.ToolTipText = "Selecionar";
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnColapse
            // 
            this.BtnColapse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnColapse.Image = ((System.Drawing.Image)(resources.GetObject("BtnColapse.Image")));
            this.BtnColapse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnColapse.Name = "BtnColapse";
            this.BtnColapse.Size = new System.Drawing.Size(23, 22);
            this.BtnColapse.ToolTipText = "Filtro";
            this.BtnColapse.Click += new System.EventHandler(this.BtnColapse_Click_1);
            // 
            // ToolStrip003
            // 
            this.ToolStrip003.Name = "ToolStrip003";
            this.ToolStrip003.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnSair
            // 
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(62, 22);
            this.BtnSair.Text = "Fechar";
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // DlgFormIdiomas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 574);
            this.Controls.Add(this.SplitDlgFilter);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DlgFormIdiomas";
            this.Text = "Idiomas";
            this.TopMost = true;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DlgFormIdiomas_KeyPress);
            this.SplitDlgFilter.Panel1.ResumeLayout(false);
            this.SplitDlgFilter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitDlgFilter)).EndInit();
            this.SplitDlgFilter.ResumeLayout(false);
            this.GroupFiltro.ResumeLayout(false);
            this.GroupFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataIdiomas)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitDlgFilter;
        private System.Windows.Forms.DataGridView DataIdiomas;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator ToolStrip001;
        private System.Windows.Forms.ToolStripButton BtnOK;
        private System.Windows.Forms.ToolStripButton BtnColapse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Langu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denominacao;
        private System.Windows.Forms.GroupBox GroupFiltro;
        private System.Windows.Forms.TextBox ValDescricao;
        private System.Windows.Forms.Label LbDescricao;
        private System.Windows.Forms.TextBox ValIdioma;
        private System.Windows.Forms.Label LbIdioma;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.TextBox ValLinhas;
        private System.Windows.Forms.Label LbLinhas;
        private System.Windows.Forms.ToolStripSeparator ToolStrip003;
        private System.Windows.Forms.ToolStripButton BtnSair;
    }
}