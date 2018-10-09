using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace acegi.Util
{
    class XmlUtil
    {
        public static TNfeProc GetTNFeProc(string content)
        {
            TNfeProc nfeProc = null;
            try
            {
                XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
                namespaces.Add("NFe", "http://www.portalfiscal.inf.br/nfe");
                XmlSerializer serializer = new XmlSerializer(typeof(TNfeProc));
                serializer.Serialize(Console.Out, new TNfeProc(), namespaces);
                System.Xml.XmlTextReader reader = new System.Xml.XmlTextReader(new System.IO.StringReader(content));
                reader.Read();
                nfeProc = (TNfeProc)serializer.Deserialize(reader);
                reader.Close();
               }
            catch 
            {
                nfeProc = null;
                throw;
            }
            return nfeProc;
        }
    }
}
