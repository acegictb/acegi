using acegi.Dao;
using acegi.Model;
using acegi.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acegi.Regionais
{
    public partial class DlgIdiomaPosiciona : Form
    {
        private const string actionF4Idioma = "Resources\\Icons\\s_f4help.gif";
        private const string iconSystem = "Resources\\Icons\\s_system.gif";

        private Principal principal;

        private IdiomaDAO idiomaDAO;

        public string CodIdioma;

        public DlgIdiomaPosiciona(Principal principal)
        {
            InitializeComponent();

            this.principal = principal;

            idiomaDAO = new IdiomaDAO();

            Image image = Image.FromFile(iconSystem);
            Bitmap bitmap = new Bitmap(image);
            this.Icon = Icon.FromHandle(bitmap.GetHicon());

            image = Image.FromFile(actionF4Idioma);
            BtnFilter.Image = image;
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                DlgFormIdiomas DlgFilter = new DlgFormIdiomas();
                Point point = new Point(this.principal.Location.X + 100, this.principal.Location.Y + 100);
                DlgFilter.Location = point;
                DlgFilter.StartPosition = FormStartPosition.Manual;
                DlgFilter.ShowDialog();
                if (DlgFilter.CodIdioma != "")
                {
                    Idioma idioma = idiomaDAO.FindByLangu(DlgFilter.CodIdioma);
                    if (idioma != null)
                    {
                        ValIdioma.Text = idioma.Langu;
                        ValIdioma.Text = DlgFilter.CodIdioma;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(this, ex.Message, "Erro Paises",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.CodIdioma = ValIdioma.Text;
            this.Close();
        }

        private void DlgIdiomaPosiciona_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
