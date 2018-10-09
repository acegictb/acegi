namespace acegi.Util
{
    partial class DlgFormPaises
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ToolStripSeparator ToolStrip002;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgFormPaises));
            this.SplitDlgFilter = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ValLinhas = new System.Windows.Forms.TextBox();
            this.LbCount = new System.Windows.Forms.Label();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.ValNome = new System.Windows.Forms.TextBox();
            this.LbNome = new System.Windows.Forms.Label();
            this.ValPais = new System.Windows.Forms.TextBox();
            this.LbPais = new System.Windows.Forms.Label();
            this.DataPaises = new System.Windows.Forms.DataGridView();
            this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStrip001 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnOK = new System.Windows.Forms.ToolStripButton();
            this.BtnColapse = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip003 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnSair = new System.Windows.Forms.ToolStripButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            ToolStrip002 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.SplitDlgFilter)).BeginInit();
            this.SplitDlgFilter.Panel1.SuspendLayout();
            this.SplitDlgFilter.Panel2.SuspendLayout();
            this.SplitDlgFilter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPaises)).BeginInit();
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
            this.SplitDlgFilter.Location = new System.Drawing.Point(9, 9);
            this.SplitDlgFilter.Name = "SplitDlgFilter";
            this.SplitDlgFilter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitDlgFilter.Panel1
            // 
            this.SplitDlgFilter.Panel1.Controls.Add(this.groupBox1);
            // 
            // SplitDlgFilter.Panel2
            // 
            this.SplitDlgFilter.Panel2.AutoScroll = true;
            this.SplitDlgFilter.Panel2.Controls.Add(this.DataPaises);
            this.SplitDlgFilter.Size = new System.Drawing.Size(357, 532);
            this.SplitDlgFilter.SplitterDistance = 192;
            this.SplitDlgFilter.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ValLinhas);
            this.groupBox1.Controls.Add(this.LbCount);
            this.groupBox1.Controls.Add(this.BtnFiltrar);
            this.groupBox1.Controls.Add(this.ValNome);
            this.groupBox1.Controls.Add(this.LbNome);
            this.groupBox1.Controls.Add(this.ValPais);
            this.groupBox1.Controls.Add(this.LbPais);
            this.groupBox1.Location = new System.Drawing.Point(16, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // ValLinhas
            // 
            this.ValLinhas.Location = new System.Drawing.Point(66, 77);
            this.ValLinhas.Name = "ValLinhas";
            this.ValLinhas.Size = new System.Drawing.Size(67, 20);
            this.ValLinhas.TabIndex = 11;
            // 
            // LbCount
            // 
            this.LbCount.AutoSize = true;
            this.LbCount.Location = new System.Drawing.Point(22, 80);
            this.LbCount.Name = "LbCount";
            this.LbCount.Size = new System.Drawing.Size(38, 13);
            this.LbCount.TabIndex = 10;
            this.LbCount.Text = "Linhas";
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(184, 91);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(79, 29);
            this.BtnFiltrar.TabIndex = 9;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // ValNome
            // 
            this.ValNome.Location = new System.Drawing.Point(66, 51);
            this.ValNome.Name = "ValNome";
            this.ValNome.Size = new System.Drawing.Size(197, 20);
            this.ValNome.TabIndex = 8;
            // 
            // LbNome
            // 
            this.LbNome.AutoSize = true;
            this.LbNome.Location = new System.Drawing.Point(22, 54);
            this.LbNome.Name = "LbNome";
            this.LbNome.Size = new System.Drawing.Size(35, 13);
            this.LbNome.TabIndex = 7;
            this.LbNome.Text = "Nome";
            // 
            // ValPais
            // 
            this.ValPais.Location = new System.Drawing.Point(66, 25);
            this.ValPais.Name = "ValPais";
            this.ValPais.Size = new System.Drawing.Size(67, 20);
            this.ValPais.TabIndex = 6;
            // 
            // LbPais
            // 
            this.LbPais.AutoSize = true;
            this.LbPais.Location = new System.Drawing.Point(22, 28);
            this.LbPais.Name = "LbPais";
            this.LbPais.Size = new System.Drawing.Size(27, 13);
            this.LbPais.TabIndex = 5;
            this.LbPais.Text = "Pais";
            // 
            // DataPaises
            // 
            this.DataPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPaises.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pais,
            this.Nome});
            this.DataPaises.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataPaises.Location = new System.Drawing.Point(0, 0);
            this.DataPaises.Name = "DataPaises";
            this.DataPaises.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataPaises.Size = new System.Drawing.Size(357, 336);
            this.DataPaises.TabIndex = 2;
            // 
            // Pais
            // 
            this.Pais.HeaderText = "Pais";
            this.Pais.Name = "Pais";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 180;
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
            this.toolStrip1.Location = new System.Drawing.Point(9, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(362, 25);
            this.toolStrip1.TabIndex = 3;
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
            this.BtnOK.Text = "toolStripButton1";
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnColapse
            // 
            this.BtnColapse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnColapse.Image = ((System.Drawing.Image)(resources.GetObject("BtnColapse.Image")));
            this.BtnColapse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnColapse.Name = "BtnColapse";
            this.BtnColapse.Size = new System.Drawing.Size(23, 22);
            this.BtnColapse.Click += new System.EventHandler(this.BtnColapse_Click);
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
            this.BtnSair.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // DlgFormPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(380, 556);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.SplitDlgFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(10, 10);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DlgFormPaises";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Paises";
            this.TopMost = true;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DlgFormPaises_KeyPress);
            this.SplitDlgFilter.Panel1.ResumeLayout(false);
            this.SplitDlgFilter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitDlgFilter)).EndInit();
            this.SplitDlgFilter.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPaises)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitDlgFilter;
        private System.Windows.Forms.DataGridView DataPaises;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator ToolStrip001;
        private System.Windows.Forms.ToolStripButton BtnOK;
        private System.Windows.Forms.ToolStripButton BtnColapse;
        private System.Windows.Forms.ToolStripSeparator ToolStrip003;
        private System.Windows.Forms.ToolStripButton BtnSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.TextBox ValNome;
        private System.Windows.Forms.Label LbNome;
        private System.Windows.Forms.TextBox ValPais;
        private System.Windows.Forms.Label LbPais;
        private System.Windows.Forms.TextBox ValLinhas;
        private System.Windows.Forms.Label LbCount;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    }
}
