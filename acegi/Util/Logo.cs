using System;
using System.IO;
using System.Reflection;

namespace ACBr.Net.NFe.Util
{
    public class Logo
    {
        public static byte[] ToBytes(String logo)
        {
            if (File.Exists(logo))
            {
                return File.ReadAllBytes(logo);
            }
            var path = (new System.Uri(Assembly.GetExecutingAssembly().CodeBase)).AbsolutePath;
            var caminhoImagem = Path.GetDirectoryName(path) + "/Resources/Imagens/logo.jpg";
            return File.ReadAllBytes(caminhoImagem);
        }
    }
}
