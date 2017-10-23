using System;
using System.IO;


namespace PracticeLib
{
    public class FileHandler
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string Birthday { get; set; }

        public string WriteFile()
        {
            string content = "";
            content = Name + ";";
            content += Birthday + ";";
            content += Number;
            return content;
        }
    }
}
