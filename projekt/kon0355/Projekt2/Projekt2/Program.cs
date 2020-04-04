using System;
using System.Windows.Forms;

namespace Projekt2
{
    static class Program
    {
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            UserCollection uc = new UserCollection();
            XmlWriter.SaveToXML("21352*//*-/*/*-*", uc);
        }
    }
}
