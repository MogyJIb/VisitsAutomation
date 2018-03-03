using System;
using System.IO;
using System.Xml.Serialization;

namespace VisitsAutomation.Utils
{
    class XmlFileReader
    {
        public static object Deserialize(string fileName, Type type)
        {
            // set class type to constructor
            XmlSerializer formatter = new XmlSerializer(type);

            // deserialization
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                return formatter.Deserialize(fs);
            }
        }        
    }
}
