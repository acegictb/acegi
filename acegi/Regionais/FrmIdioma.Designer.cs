namespace acegi.Regionais
{
    partial class FrmIdioma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIdioma));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.BtnClose = new System.Windows.Forms.ToolStripButton();
            this.DataIdioma = new System.Windows.Forms.DataGridView();
            this.ValPosicionar = new System.Windows.Forms.Button();
            this.Idioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Langu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Denominacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolIdioma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataIdioma)).BeginInit();
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
            this.BtnClose});
            this.toolIdioma.Location = new System.Drawing.Point(0, 0);
            this.toolIdioma.Name = "toolIdioma";
            this.toolIdioma.Size = new System.Drawing.Size(412, 25);
            this.toolIdioma.TabIndex = 0;
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
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click_1);
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
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // DataIdioma
            // 
            this.DataIdioma.AllowUserToOrderColumns = true;
            this.DataIdioma.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataIdioma.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataIdioma.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DataIdioma.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataIdioma.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataIdioma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataIdioma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idioma,
            this.Langu,
            this.Denominacao});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataIdioma.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataIdioma.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DataIdioma.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.DataIdioma.Location = new System.Drawing.Point(0, 25);
            this.DataIdioma.Name = "DataIdioma";
            this.DataIdioma.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataIdioma.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataIdioma.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataIdioma.Size = new System.Drawing.Size(337, 646);
            this.DataIdioma.TabIndex = 1;
            this.DataIdioma.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataIdioma_RowValidating);
            // 
            // ValPosicionar
            // 
            this.ValPosicionar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ValPosicionar.FlatAppearance.BorderSize = 0;
            this.ValPosicionar.Location = new System.Drawing.Point(116, 689);
            this.ValPosicionar.Name = "ValPosicionar";
            this.ValPosicionar.Size = new System.Drawing.Size(90, 29);
            this.ValPosicionar.TabIndex = 2;
            this.ValPosicionar.Text = "Posicionar";
            this.ValPosicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ValPosicionar.UseVisualStyleBackColor = true;
            this.ValPosicionar.Click += new System.EventHandler(this.ValPosicionar_Click);
            // 
            // Idioma
            // 
            this.Idioma.HeaderText = "Idioma";
            this.Idioma.MaxInputLength = 2;
            this.Idioma.Name = "Idioma";
            this.Idioma.Width = 50;
            // 
            // Langu
            // 
            this.Langu.HeaderText = "ISO";
            this.Langu.MaxInputLength = 2;
            this.Langu.Name = "Langu";
            this.Langu.Width = 50;
            // 
            // Denominacao
            // 
            this.Denominacao.HeaderText = "Denominação";
            this.Denominacao.MaxInputLength = 60;
            this.Denominacao.Name = "Denominacao";
            this.Denominacao.Width = 150;
            // 
            // FrmIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(412, 769);
            this.ControlBox = false;
            this.Controls.Add(this.ValPosicionar);
            this.Controls.Add(this.DataIdioma);
            this.Controls.Add(this.toolIdioma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIdioma";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Idiomas";
            this.TopMost = true;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmIdioma_KeyPress);
            this.toolIdioma.ResumeLayout(false);
            this.toolIdioma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataIdioma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolIdioma;
        private System.Windows.Forms.ToolStripButton BtnEdit;
        private System.Windows.Forms.DataGridView DataIdioma;
        private System.Windows.Forms.ToolStripSeparator toolStrip01;
        private System.Windows.Forms.ToolStripSeparator toolStrip02;
        private System.Windows.Forms.ToolStripButton BtnNew;
        private System.Windows.Forms.ToolStripSeparator toolStrip03;
        private System.Windows.Forms.ToolStripButton BtnSave;
        private System.Windows.Forms.ToolStripSeparator toolStrip04;
        private System.Windows.Forms.ToolStripButton BtnClose;
        private System.Windows.Forms.ToolStripButton BtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStrip05;
        private System.Windows.Forms.Button ValPosicionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idioma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Langu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denominacao;
    }
}