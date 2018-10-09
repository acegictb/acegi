using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace acegi.Util
{
    public class UtilObject
    {
       public static void Serialize<T>(string file, T objectToWrite, bool append = false)
       {
           string path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
           using (Stream stream = File.Open(path+"\\"+file, append ? FileMode.Append : FileMode.Create))
           {
               
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
               binaryFormatter.Serialize(stream, objectToWrite);
           }
       }
       public static T Deserialize<T>(string file)
       {
          string path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
          using (Stream stream = File.Open(path + "\\" + file, FileMode.Open))
          {
             var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
             return (T)binaryFormatter.Deserialize(stream);
          }
       }

        public static void DeleteSelected(DataGridView data)
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i].Selected)
                {
                    data.Rows.RemoveAt(i);
                    DeleteSelected(data);
                }
            }
        }

    }
}
