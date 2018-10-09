namespace acegi.Regionais
{
    partial class DlgPaisPosiciona
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
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.ValPais = new System.Windows.Forms.TextBox();
            this.LbPais = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(138, 62);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(45, 23);
            this.BtnSair.TabIndex = 9;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(87, 62);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(44, 23);
            this.BtnOK.TabIndex = 8;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnFilter
            // 
            this.BtnFilter.Location = new System.Drawing.Point(141, 20);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(42, 22);
            this.BtnFilter.TabIndex = 7;
            this.BtnFilter.UseVisualStyleBackColor = true;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // ValPais
            // 
            this.ValPais.Location = new System.Drawing.Point(56, 21);
            this.ValPais.Name = "ValPais";
            this.ValPais.Size = new System.Drawing.Size(100, 20);
            this.ValPais.TabIndex = 6;
            // 
            // LbPais
            // 
            this.LbPais.AutoSize = true;
            this.LbPais.Location = new System.Drawing.Point(23, 25);
            this.LbPais.Name = "LbPais";
            this.LbPais.Size = new System.Drawing.Size(27, 13);
            this.LbPais.TabIndex = 5;
            this.LbPais.Text = "Páis";
            // 
            // DlgPaisPosiciona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 106);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.BtnFilter);
            this.Controls.Add(this.ValPais);
            this.Controls.Add(this.LbPais);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DlgPaisPosiciona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Posicionar";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DlgPaisPosiciona_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.TextBox ValPais;
        private System.Windows.Forms.Label LbPais;
    }
}