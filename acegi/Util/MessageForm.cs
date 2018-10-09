using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acegi.Util
{
    public partial class MessageForm : MaterialForm
    {

        private IList<String> messages;

        private String action;
        public MessageForm(String action, IList<String> messages)
        {
            InitializeComponent();
            this.Cursor = Cursors.WaitCursor;
            this.messages = messages;
            this.action = action;
            
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MessageForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
               this.Close();
            }
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            
        }

        private void MessageForm_Shown(object sender, EventArgs e)
        {
            
            this.UpdateBounds();
            Image image = Image.FromFile(action);
            LBImage.Image = image;
            
            for (int i = 0; i < messages.Count; i++)
            {
                this.RTextMessage.AppendText(messages[i]);
                this.RTextMessage.Update();
            }

            this.Cursor = Cursors.Default;
        }
    }
}
