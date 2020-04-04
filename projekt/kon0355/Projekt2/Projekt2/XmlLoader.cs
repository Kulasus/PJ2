using System;
using System.Xml;

namespace Projekt2
{
    class XmlLoader
    {
        public static bool LoadFromXml(string path, UserCollection uc)
        {
            string usernameTmp;
            int? scoreTmp;
            bool? isActiveTmp;
            uc.Erase();
            try
            {
                if (path.Substring(path.Length - 4) != ".xml")
                {
                    throw new ArgumentException();
                }
                XmlReader reader = XmlReader.Create(path);
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "USER")
                    {

                        if (!(reader.GetAttribute("USERNAME") == null ||
                            reader.GetAttribute("SCORE") == null ||
                            reader.GetAttribute("ISACTIVE") == null))
                        {
                            usernameTmp = reader.GetAttribute("USERNAME");
                            if (reader.GetAttribute("SCORE") == "null")
                            {
                                scoreTmp = null;
                            }
                            else scoreTmp = int.Parse(reader.GetAttribute("SCORE"));
                            if (reader.GetAttribute("ISACTIVE") == "null")
                            {
                                isActiveTmp = null;
                            }
                            else isActiveTmp = bool.Parse(reader.GetAttribute("ISACTIVE"));
                            uc.Add(new User(usernameTmp, scoreTmp, isActiveTmp));
                        }
                    }
                }
                reader.Close();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
            
        }
    }
}
