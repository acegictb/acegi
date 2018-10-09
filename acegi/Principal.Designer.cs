namespace acegi
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.statusPrincipal = new System.Windows.Forms.StatusStrip();
            this.LbGif = new System.Windows.Forms.ToolStripStatusLabel();
            this.LbProcess = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolPrincipal = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTransacao = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ValTransacao = new System.Windows.Forms.ToolStripTextBox();
            this.statusPrincipal.SuspendLayout();
            this.toolPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusPrincipal
            // 
            this.statusPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LbGif,
            this.LbProcess});
            this.statusPrincipal.Location = new System.Drawing.Point(0, 714);
            this.statusPrincipal.Name = "statusPrincipal";
            this.statusPrincipal.Size = new System.Drawing.Size(1317, 22);
            this.statusPrincipal.TabIndex = 2;
            this.statusPrincipal.Text = "Teste";
            // 
            // LbGif
            // 
            this.LbGif.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LbGif.Name = "LbGif";
            this.LbGif.Size = new System.Drawing.Size(0, 17);
            // 
            // LbProcess
            // 
            this.LbProcess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LbProcess.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LbProcess.Name = "LbProcess";
            this.LbProcess.Size = new System.Drawing.Size(0, 17);
            // 
            // toolPrincipal
            // 
            this.toolPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btnTransacao,
            this.toolStripSeparator2,
            this.ValTransacao});
            this.toolPrincipal.Location = new System.Drawing.Point(0, 0);
            this.toolPrincipal.Name = "toolPrincipal";
            this.toolPrincipal.Padding = new System.Windows.Forms.Padding(5);
            this.toolPrincipal.Size = new System.Drawing.Size(1317, 39);
            this.toolPrincipal.TabIndex = 3;
            this.toolPrincipal.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // btnTransacao
            // 
            this.btnTransacao.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.btnTransacao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTransacao.Image = ((System.Drawing.Image)(resources.GetObject("btnTransacao.Image")));
            this.btnTransacao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTransacao.Name = "btnTransacao";
            this.btnTransacao.Size = new System.Drawing.Size(23, 26);
            this.btnTransacao.ToolTipText = "Ação transação";
            this.btnTransacao.Click += new System.EventHandler(this.BtnTransacao_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // ValTransacao
            // 
            this.ValTransacao.AcceptsReturn = true;
            this.ValTransacao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ValTransacao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ValTransacao.AutoToolTip = true;
            this.ValTransacao.BackColor = System.Drawing.SystemColors.Control;
            this.ValTransacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ValTransacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ValTransacao.Margin = new System.Windows.Forms.Padding(3);
            this.ValTransacao.Name = "ValTransacao";
            this.ValTransacao.Size = new System.Drawing.Size(0, 23);
            this.ValTransacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValTransacao_KeyDown);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1317, 736);
            this.Controls.Add(this.toolPrincipal);
            this.Controls.Add(this.statusPrincipal);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acegi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResizeEnd += new System.EventHandler(this.Resize);
            this.SizeChanged += new System.EventHandler(this.Resize);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Principal_PreviewKeyDown);
            this.statusPrincipal.ResumeLayout(false);
            this.statusPrincipal.PerformLayout();
            this.toolPrincipal.ResumeLayout(false);
            this.toolPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusPrincipal;
        private System.Windows.Forms.ToolStrip toolPrincipal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox ValTransacao;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnTransacao;
        private System.Windows.Forms.ToolStripStatusLabel LbProcess;
        private System.Windows.Forms.ToolStripStatusLabel LbGif;
    }
}

