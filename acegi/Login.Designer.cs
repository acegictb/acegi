namespace acegi
{
    partial class Login
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
            this.PaneLogin = new System.Windows.Forms.Panel();
            this.ValSenha = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.ValUsuario = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PaneLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PaneLogin
            // 
            this.PaneLogin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PaneLogin.Controls.Add(this.ValSenha);
            this.PaneLogin.Controls.Add(this.lbSenha);
            this.PaneLogin.Controls.Add(this.ValUsuario);
            this.PaneLogin.Controls.Add(this.lbUsuario);
            this.PaneLogin.Location = new System.Drawing.Point(12, 84);
            this.PaneLogin.Name = "PaneLogin";
            this.PaneLogin.Size = new System.Drawing.Size(340, 157);
            this.PaneLogin.TabIndex = 0;
            // 
            // ValSenha
            // 
            this.ValSenha.Location = new System.Drawing.Point(43, 95);
            this.ValSenha.Name = "ValSenha";
            this.ValSenha.PasswordChar = '#';
            this.ValSenha.Size = new System.Drawing.Size(248, 20);
            this.ValSenha.TabIndex = 3;
            this.ValSenha.UseSystemPasswordChar = true;
            this.ValSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValSenha_KeyPress);
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(43, 79);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(38, 13);
            this.lbSenha.TabIndex = 2;
            this.lbSenha.Text = "Senha";
            // 
            // ValUsuario
            // 
            this.ValUsuario.Location = new System.Drawing.Point(43, 54);
            this.ValUsuario.Name = "ValUsuario";
            this.ValUsuario.Size = new System.Drawing.Size(248, 20);
            this.ValUsuario.TabIndex = 1;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(40, 38);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(43, 13);
            this.lbUsuario.TabIndex = 0;
            this.lbUsuario.Text = "Usuário";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(179, 294);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 1;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(260, 294);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 2;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 52);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(140, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(369, 345);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.PaneLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.PaneLogin.ResumeLayout(false);
            this.PaneLogin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PaneLogin;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.TextBox ValSenha;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox ValUsuario;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}