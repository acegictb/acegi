namespace acegi.Util
{
    partial class MessageForm
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
            this.GrpMessage = new System.Windows.Forms.GroupBox();
            this.LBImage = new System.Windows.Forms.Label();
            this.RTextMessage = new System.Windows.Forms.RichTextBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.GrpMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpMessage
            // 
            this.GrpMessage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GrpMessage.Controls.Add(this.LBImage);
            this.GrpMessage.Controls.Add(this.RTextMessage);
            this.GrpMessage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GrpMessage.ForeColor = System.Drawing.Color.Lavender;
            this.GrpMessage.Location = new System.Drawing.Point(3, 69);
            this.GrpMessage.Name = "GrpMessage";
            this.GrpMessage.Size = new System.Drawing.Size(743, 206);
            this.GrpMessage.TabIndex = 0;
            this.GrpMessage.TabStop = false;
            // 
            // LBImage
            // 
            this.LBImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBImage.Location = new System.Drawing.Point(11, 16);
            this.LBImage.Name = "LBImage";
            this.LBImage.Size = new System.Drawing.Size(44, 44);
            this.LBImage.TabIndex = 1;
            // 
            // RTextMessage
            // 
            this.RTextMessage.AutoWordSelection = true;
            this.RTextMessage.BackColor = System.Drawing.SystemColors.Window;
            this.RTextMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTextMessage.Font = new System.Drawing.Font("Arial monospaced for SAP", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTextMessage.ForeColor = System.Drawing.Color.Navy;
            this.RTextMessage.Location = new System.Drawing.Point(62, 31);
            this.RTextMessage.Name = "RTextMessage";
            this.RTextMessage.ReadOnly = true;
            this.RTextMessage.Size = new System.Drawing.Size(660, 154);
            this.RTextMessage.TabIndex = 0;
            this.RTextMessage.Text = "";
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(671, 322);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 1;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(758, 357);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.GrpMessage);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Message";
            this.Load += new System.EventHandler(this.MessageForm_Load);
            this.Shown += new System.EventHandler(this.MessageForm_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MessageForm_KeyPress);
            this.GrpMessage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpMessage;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.RichTextBox RTextMessage;
        public System.Windows.Forms.Label LBImage;
    }
}