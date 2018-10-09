using acegi.Dao;
using acegi.DBA;
using System;
using System.Windows.Forms;

namespace acegi
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Dbs.GetSession();

            Login login = new Login();
            login.ShowDialog();
            if (login.IsLogin)
            {
                login.Close();
                Application.EnableVisualStyles();
                Application.Run(new Principal());
            }
        }
    }
}
