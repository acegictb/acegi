namespace acegi.Regionais
{
    partial class FrmCatCambio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCatCambio));
            this.toolIdioma = new System.Windows.Forms.ToolStrip();
            this.toolStrip01 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip02 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStrip03 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStrip05 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStrip04 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnFrmFiltro = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip06 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnClose = new System.Windows.Forms.ToolStripButton();
            this.SplitCatCambio = new System.Windows.Forms.SplitContainer();
            this.GroupFiltro = new System.Windows.Forms.GroupBox();
            this.BtnFiltro = new System.Windows.Forms.Button();
            this.ValDescricao = new System.Windows.Forms.TextBox();
            this.LbDescricao = new System.Windows.Forms.Label();
            this.ValCategoria = new System.Windows.Forms.TextBox();
            this.LbCategoria = new System.Windows.Forms.Label();
            this.DataCatCambio = new System.Windows.Forms.DataGridView();
            this.Kurst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolIdioma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitCatCambio)).BeginInit();
            this.SplitCatCambio.Panel1.SuspendLayout();
            this.SplitCatCambio.Panel2.SuspendLayout();
            this.SplitCatCambio.SuspendLayout();
            this.GroupFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataCatCambio)).BeginInit();
            this.SuspendLayout();
            // 
            // toolIdioma
            // 
            this.toolIdioma.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip01,
            this.BtnEdit,
            this.toolStrip02,
            this.BtnNew,
            this.toolStrip03,
            this.BtnDelete,
            this.toolStrip05,
            this.BtnSave,
            this.toolStrip04,
            this.BtnFrmFiltro,
            this.ToolStrip06,
            this.BtnClose});
            this.toolIdioma.Location = new System.Drawing.Point(0, 0);
            this.toolIdioma.Name = "toolIdioma";
            this.toolIdioma.Size = new System.Drawing.Size(1068, 25);
            this.toolIdioma.TabIndex = 1;
            this.toolIdioma.Text = "toolIdioma";
            // 
            // toolStrip01
            // 
            this.toolStrip01.Name = "toolStrip01";
            this.toolStrip01.Size = new System.Drawing.Size(6, 25);
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
            // BtnFrmFiltro
            // 
            this.BtnFrmFiltro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnFrmFiltro.Image = ((System.Drawing.Image)(resources.GetObject("BtnFrmFiltro.Image")));
            this.BtnFrmFiltro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnFrmFiltro.Name = "BtnFrmFiltro";
            this.BtnFrmFiltro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnFrmFiltro.Size = new System.Drawing.Size(23, 22);
            this.BtnFrmFiltro.Click += new System.EventHandler(this.BtnFrmFiltro_Click);
            // 
            // ToolStrip06
            // 
            this.ToolStrip06.Name = "ToolStrip06";
            this.ToolStrip06.Size = new System.Drawing.Size(6, 25);
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
            // SplitCatCambio
            // 
            this.SplitCatCambio.IsSplitterFixed = true;
            this.SplitCatCambio.Location = new System.Drawing.Point(0, 28);
            this.SplitCatCambio.Name = "SplitCatCambio";
            this.SplitCatCambio.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitCatCambio.Panel1
            // 
            this.SplitCatCambio.Panel1.Controls.Add(this.GroupFiltro);
            // 
            // SplitCatCambio.Panel2
            // 
            this.SplitCatCambio.Panel2.AutoScroll = true;
            this.SplitCatCambio.Panel2.Controls.Add(this.DataCatCambio);
            this.SplitCatCambio.Size = new System.Drawing.Size(449, 684);
            this.SplitCatCambio.SplitterDistance = 120;
            this.SplitCatCambio.TabIndex = 3;
            // 
            // GroupFiltro
            // 
            this.GroupFiltro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GroupFiltro.Controls.Add(this.BtnFiltro);
            this.GroupFiltro.Controls.Add(this.ValDescricao);
            this.GroupFiltro.Controls.Add(this.LbDescricao);
            this.GroupFiltro.Controls.Add(this.ValCategoria);
            this.GroupFiltro.Controls.Add(this.LbCategoria);
            this.GroupFiltro.Location = new System.Drawing.Point(0, 3);
            this.GroupFiltro.Name = "GroupFiltro";
            this.GroupFiltro.Size = new System.Drawing.Size(446, 114);
            this.GroupFiltro.TabIndex = 0;
            this.GroupFiltro.TabStop = false;
            this.GroupFiltro.Text = "Filtro";
            // 
            // BtnFiltro
            // 
            this.BtnFiltro.Location = new System.Drawing.Point(329, 19);
            this.BtnFiltro.Name = "BtnFiltro";
            this.BtnFiltro.Size = new System.Drawing.Size(75, 23);
            this.BtnFiltro.TabIndex = 4;
            this.BtnFiltro.Text = "Filtrar";
            this.BtnFiltro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnFiltro.UseVisualStyleBackColor = true;
            this.BtnFiltro.Click += new System.EventHandler(this.BtnFiltro_Click);
            // 
            // ValDescricao
            // 
            this.ValDescricao.Location = new System.Drawing.Point(94, 57);
            this.ValDescricao.Name = "ValDescricao";
            this.ValDescricao.Size = new System.Drawing.Size(210, 20);
            this.ValDescricao.TabIndex = 3;
            // 
            // LbDescricao
            // 
            this.LbDescricao.AutoSize = true;
            this.LbDescricao.Location = new System.Drawing.Point(36, 61);
            this.LbDescricao.Name = "LbDescricao";
            this.LbDescricao.Size = new System.Drawing.Size(55, 13);
            this.LbDescricao.TabIndex = 2;
            this.LbDescricao.Text = "Descrição";
            // 
            // ValCategoria
            // 
            this.ValCategoria.Location = new System.Drawing.Point(94, 31);
            this.ValCategoria.Name = "ValCategoria";
            this.ValCategoria.Size = new System.Drawing.Size(74, 20);
            this.ValCategoria.TabIndex = 1;
            // 
            // LbCategoria
            // 
            this.LbCategoria.AutoSize = true;
            this.LbCategoria.Location = new System.Drawing.Point(36, 35);
            this.LbCategoria.Name = "LbCategoria";
            this.LbCategoria.Size = new System.Drawing.Size(52, 13);
            this.LbCategoria.TabIndex = 0;
            this.LbCategoria.Text = "Categoria";
            // 
            // DataCatCambio
            // 
            this.DataCatCambio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataCatCambio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kurst,
            this.Descricao});
            this.DataCatCambio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataCatCambio.Location = new System.Drawing.Point(0, 0);
            this.DataCatCambio.Name = "DataCatCambio";
            this.DataCatCambio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataCatCambio.Size = new System.Drawing.Size(449, 560);
            this.DataCatCambio.TabIndex = 3;
            // 
            // Kurst
            // 
            this.Kurst.HeaderText = "Kurst";
            this.Kurst.Name = "Kurst";
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 260;
            // 
            // FrmCatCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1068, 717);
            this.ControlBox = false;
            this.Controls.Add(this.SplitCatCambio);
            this.Controls.Add(this.toolIdioma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCatCambio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Categoria de Cambio";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmCatCambio_KeyPress);
            this.toolIdioma.ResumeLayout(false);
            this.toolIdioma.PerformLayout();
            this.SplitCatCambio.Panel1.ResumeLayout(false);
            this.SplitCatCambio.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitCatCambio)).EndInit();
            this.SplitCatCambio.ResumeLayout(false);
            this.GroupFiltro.ResumeLayout(false);
            this.GroupFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataCatCambio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolIdioma;
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
        private System.Windows.Forms.SplitContainer SplitCatCambio;
        private System.Windows.Forms.DataGridView DataCatCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kurst;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.ToolStripButton BtnFrmFiltro;
        private System.Windows.Forms.ToolStripSeparator ToolStrip06;
        private System.Windows.Forms.GroupBox GroupFiltro;
        private System.Windows.Forms.Label LbCategoria;
        private System.Windows.Forms.TextBox ValCategoria;
        private System.Windows.Forms.TextBox ValDescricao;
        private System.Windows.Forms.Label LbDescricao;
        private System.Windows.Forms.Button BtnFiltro;
    }
}