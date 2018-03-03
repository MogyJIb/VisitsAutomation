using System.IO;
using System.Xml.Serialization;

namespace VisitsAutomation.Utils
{
    class XmlFileWriter
    {
        public static void Serialize(string fileName, FileMode fm, object obj)
        {
            // set class type to constructor
            XmlSerializer formatter = new XmlSerializer(obj.GetType());

            // serialization
            using (FileStream fs = new FileStream(fileName, fm))
            {
                formatter.Serialize(fs, obj);
            }
        }
    }
}
