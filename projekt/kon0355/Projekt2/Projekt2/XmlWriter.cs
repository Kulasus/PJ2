using System;
using System.Text;
using System.Xml;

namespace Projekt2
{
    class XmlWriter
    {
        public static bool SaveToXML(string filename, UserCollection uc)
        {
            string scoreTmp;
            string isActiveTmp;
            try
            {
                if (filename.Substring(filename.Length - 4) != ".xml")
                {
                    throw new ArgumentException();
                }
                XmlTextWriter writer = new XmlTextWriter(filename, Encoding.UTF8) { Formatting = Formatting.Indented };
                writer.WriteStartDocument();
                writer.WriteComment("If you want to add something, it must be in the same format as below. Otherway it will be skipped!");
                writer.WriteStartElement("USERS");
                foreach (User u in uc)
                {
                    scoreTmp = u.Score == null ? "null" : u.Score.ToString();
                    isActiveTmp = u.IsActive == null ? "null" : u.IsActive.ToString();

                    writer.WriteStartElement("USER");
                    writer.WriteAttributeString("USERNAME", u.Username);
                    writer.WriteAttributeString("SCORE", scoreTmp);
                    writer.WriteAttributeString("ISACTIVE", isActiveTmp);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
                return true;
            }
            catch (ArgumentException)
            {
                return false;
            }
            
        }
    }
}
