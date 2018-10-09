namespace acegi.Regionais
{
    partial class FrmFatorConversao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFatorConversao));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.DataFator = new System.Windows.Forms.DataGridView();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fcur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Waers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fator_ori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Div = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fator_dst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolIdioma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataFator)).BeginInit();
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
            this.toolIdioma.Size = new System.Drawing.Size(734, 25);
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
            // DataFator
            // 
            this.DataFator.AllowUserToAddRows = false;
            this.DataFator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataFator.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categoria,
            this.Fcur,
            this.Waers,
            this.ValDesde,
            this.Fator_ori,
            this.Div,
            this.Fator_dst});
            this.DataFator.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataFator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataFator.ImeMode = System.Windows.Forms.ImeMode.On;
            this.DataFator.Location = new System.Drawing.Point(0, 25);
            this.DataFator.Name = "DataFator";
            this.DataFator.Size = new System.Drawing.Size(734, 918);
            this.DataFator.TabIndex = 2;
            this.DataFator.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataFator_CellValueChanged);
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Ctg.Ca.";
            this.Categoria.Name = "Categoria";
            this.Categoria.Width = 50;
            // 
            // Fcur
            // 
            this.Fcur.HeaderText = "De";
            this.Fcur.Name = "Fcur";
            this.Fcur.Width = 80;
            // 
            // Waers
            // 
            this.Waers.HeaderText = "Para";
            this.Waers.Name = "Waers";
            this.Waers.Width = 80;
            // 
            // ValDesde
            // 
            this.ValDesde.HeaderText = "Desde";
            this.ValDesde.Name = "ValDesde";
            // 
            // Fator_ori
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Fator_ori.DefaultCellStyle = dataGridViewCellStyle10;
            this.Fator_ori.HeaderText = "Fator (de)";
            this.Fator_ori.Name = "Fator_ori";
            this.Fator_ori.Width = 50;
            // 
            // Div
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.NullValue = ":";
            this.Div.DefaultCellStyle = dataGridViewCellStyle11;
            this.Div.HeaderText = "Div";
            this.Div.Name = "Div";
            this.Div.ReadOnly = true;
            this.Div.Width = 10;
            // 
            // Fator_dst
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Fator_dst.DefaultCellStyle = dataGridViewCellStyle12;
            this.Fator_dst.HeaderText = "Fator (para)";
            this.Fator_dst.Name = "Fator_dst";
            this.Fator_dst.Width = 50;
            // 
            // FrmFatorConversao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 943);
            this.ControlBox = false;
            this.Controls.Add(this.DataFator);
            this.Controls.Add(this.toolIdioma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFatorConversao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Fatores de Conversão";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmFatorConversao_KeyPress);
            this.toolIdioma.ResumeLayout(false);
            this.toolIdioma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataFator)).EndInit();
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
        private System.Windows.Forms.DataGridView DataFator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fcur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Waers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fator_ori;
        private System.Windows.Forms.DataGridViewTextBoxColumn Div;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fator_dst;
    }
}