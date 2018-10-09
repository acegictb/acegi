using acegi.Model;
using acegi.Util;
using MaterialSkin.Controls;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace acegi
{
    public partial class Principal : Form
    {
        public const string actionTcode = "Resources\\Icons\\s_f_okay.gif";
        public const string iconSystem = "Resources\\Icons\\s_system.gif";
        public const string actionExec = "Resources\\Icons\\s_b_exec.gif";
        public const string actionLoad = "Resources\\Icons\\loader.gif";

        public MenuStrip MnuStrip;

        public String message;

        public String acao;

        public String tipo;

        public static Thread execth;

        public static Thread messth;

        public int tempoMsg;

        public static Semaphore threadPool;

        private FormUtil FrmUtil;

        private AutoCompleteStringCollection autocomplete;

        public Principal()
        {
            InitializeComponent();

            this.Cursor = Cursors.WaitCursor;
            FrmUtil = new FormUtil(this);
            Image image = Image.FromFile(iconSystem);
            Bitmap bitmap = new Bitmap(image);
            this.Icon = Icon.FromHandle(bitmap.GetHicon());
            this.GotFocus += new EventHandler(Sub_GotFocus);
            this.LostFocus += new EventHandler(Sub_LostFocus);
            this.Cursor = Cursors.Default;

            /*var client = new RestClient("http://eccsrv30.localdomain:8080");

            var request = new RestRequest("/acegi_portal/rest/hdf/nfe/xmls/53180600701839000157550010000063641000063643", Method.GET);
            string queryResult = client.Execute(request).Content;

            TNfeProc proc = XmlUtil.GetTNFeProc(queryResult);

            if(proc != null)
            {

            }*/

            tempoMsg = 5000;
            threadPool = new Semaphore(3, 5);
        }

        public void Principal_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            MnuStrip = new MenuStrip();
            FrmUtil.MenuStripDB(this, MnuStrip);

            this.MainMenuStrip = MnuStrip;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.LightGray;
                }
            }
            Image image = Image.FromFile(actionTcode);
            btnTransacao.Image = image;
            Size size = ValTransacao.Size;
            size.Width = 120;
            size.Height = 20;
            ValTransacao.Size = size;
            autocomplete = new AutoCompleteStringCollection();
            IList<FuncaoSubMenu> menus = FrmUtil.GetTransacoes();
            
            for(int i = 0; i < menus.Count; i++)
            {
                autocomplete.Add(menus[i].Transacao);
            }

            ValTransacao.AutoCompleteCustomSource = autocomplete;

            ValTransacao.Focus();
            this.Cursor = Cursors.Default;
        }
        private new void Resize(object sender, EventArgs e)
        {
            if (this.MdiChildren != null)
            {
                this.HideExecucao();

                Form[] mdi = this.MdiChildren;
                if (mdi.Length > 0)
                {
                    for (int i = 0; i < mdi.Length; i++)
                    {
                        int x = 1;
                        int y = 2;
                        mdi[i].Location = new Point(x, y);
                        mdi[i].Focus();

                    }
                }
            }

        }

        private void BtnTransacao_Click(object sender, EventArgs e)
        {
            this.HideExecucao();

            if (ValTransacao.Text.ToString() != "")
            {
                FrmUtil.CallTransacao(this, ValTransacao.Text.ToString());
                ValTransacao.Text = "";
            }
            else
            {
                this.exibirMessage(actionTcode, "Entrar nome de uma transação!", "E");
            }
        
            ValTransacao.Focus();
        }

        private void Sub_GotFocus(object sender, EventArgs e)
        {
            this.HideExecucao();
            ValTransacao.Focus();
        }
        private void Sub_LostFocus(object sender, EventArgs e)
        {
            this.HideExecucao();
            ValTransacao.Focus();
        }

        private void Principal_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            this.HideExecucao();
            ValTransacao.Focus();
        }

        public void exibirExecucao(String message)
        {
            LbProcess.Image = Image.FromFile(actionExec);
            LbProcess.Text = message;
            this.Refresh();
        }
        public void exibirMessage(String action, string message, String tipo)
        {
            this.message = message;
            this.acao = action;
            this.tipo = tipo;
            
            messth = new Thread(new ThreadStart(CallMessage));
           // messth.IsBackground = false;
            messth.Start();
        }

        public void CallMessage()
        {
            threadPool.WaitOne();
            lock (messth)
            {
                InvokeMessage(acao, message, tipo);
            }
            threadPool.Release();
        }

        delegate void ReceberMensagemCallback(String img, String message, String tipo);
        async public void InvokeMessage(String img, String message, String tipo)
        {
            if (InvokeRequired)
            {
                ReceberMensagemCallback callback = InvokeMessage;
                Invoke(callback, img, message, tipo);
            }
            else
            {
                LbProcess.Image = Image.FromFile(img);
                LbProcess.Text = message;
                this.Refresh();
                if (tipo == "E")
                {
                    Console.Beep(415, 300);
                    await Task.Delay(tempoMsg);
                }
                else
                {
                    Console.Beep(100, 300);
                    await Task.Delay(tempoMsg);
                }
                this.HideExecucao();
            }
        }

        public void HideExecucao()
        {
            if (execth != null && execth.ThreadState != ThreadState.Stopped)
            {
                execth.Abort();
            }
            LbProcess.Image = null;
            LbGif.Image = null;
            LbProcess.Text = "";
            this.Update();
        }

        private void ValTransacao_KeyDown(object sender, KeyEventArgs e)
        {
            this.HideExecucao();

            if (e.KeyValue == 13)
            {
                if (ValTransacao.Text.ToString() != "")
                {
                    FrmUtil.CallTransacao(this, ValTransacao.Text.ToString());
                    ValTransacao.Text = "";
                }
                else
                {
                    exibirMessage(actionTcode, "Entrar um nome de transação!", "E");
                    ValTransacao.Focus(); 
                }
            }
        }
    }
}
