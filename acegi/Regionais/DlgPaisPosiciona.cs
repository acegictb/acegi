using acegi.Dao;
using acegi.Model;
using acegi.Util;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace acegi.Regionais
{
    public partial class DlgPaisPosiciona : Form
    {
        private const string actionF4Idioma = "Resources\\Icons\\s_f4help.gif";
        private const string iconSystem = "Resources\\Icons\\s_system.gif";

        private Principal principal;

        private PaisDAO paisDAO;

        public String CodPais;

        public DlgPaisPosiciona(Principal principal)
        {
            InitializeComponent();

            this.principal = principal;

            paisDAO = new PaisDAO();

            Image image = Image.FromFile(iconSystem);
            Bitmap bitmap = new Bitmap(image);
            this.Icon = Icon.FromHandle(bitmap.GetHicon());

            image = Image.FromFile(actionF4Idioma);
            BtnFilter.Image = image;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.CodPais = ValPais.Text;
            this.Close();
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            DlgFormPaises DlgFilter = new DlgFormPaises();
            Point point = new Point(this.principal.Location.X + 100, this.principal.Location.Y + 100);
            DlgFilter.Location = point;
            DlgFilter.StartPosition = FormStartPosition.Manual;
            DlgFilter.ShowDialog();
            if (DlgFilter.CodPais != "")
            {
                Pais pais = paisDAO.FindByLand(DlgFilter.CodPais);
                if (pais != null)
                {
                    ValPais.Text = pais.Land;
                }
            }
        }

        private void DlgPaisPosiciona_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
