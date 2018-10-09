namespace acegi.Regionais
{
    partial class DlgIdiomaPosiciona
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
            this.LbIdioma = new System.Windows.Forms.Label();
            this.ValIdioma = new System.Windows.Forms.TextBox();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbIdioma
            // 
            this.LbIdioma.AutoSize = true;
            this.LbIdioma.Location = new System.Drawing.Point(22, 30);
            this.LbIdioma.Name = "LbIdioma";
            this.LbIdioma.Size = new System.Drawing.Size(38, 13);
            this.LbIdioma.TabIndex = 0;
            this.LbIdioma.Text = "Idioma";
            // 
            // ValIdioma
            // 
            this.ValIdioma.Location = new System.Drawing.Point(66, 26);
            this.ValIdioma.Name = "ValIdioma";
            this.ValIdioma.Size = new System.Drawing.Size(100, 20);
            this.ValIdioma.TabIndex = 1;
            // 
            // BtnFilter
            // 
            this.BtnFilter.Location = new System.Drawing.Point(151, 25);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(42, 22);
            this.BtnFilter.TabIndex = 2;
            this.BtnFilter.UseVisualStyleBackColor = true;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(97, 67);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(44, 23);
            this.BtnOK.TabIndex = 3;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(148, 67);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(45, 23);
            this.BtnSair.TabIndex = 4;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // DlgIdiomaPosiciona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 102);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.BtnFilter);
            this.Controls.Add(this.ValIdioma);
            this.Controls.Add(this.LbIdioma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DlgIdiomaPosiciona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Posicionar";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DlgIdiomaPosiciona_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbIdioma;
        private System.Windows.Forms.TextBox ValIdioma;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnSair;
    }
}