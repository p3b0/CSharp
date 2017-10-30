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

        public string ConvertText(string row)
        {
            string[] tokens = row.Split(';');
            var firstName = tokens[0].ToUpper();
            var lastName = tokens[1].ToUpper();
            var years = DateTime.Now.Year - int.Parse(tokens[2]);
            var phone = tokens[3];
            var message = $"{firstName} {lastName} är {years} år gammal och har telefonnumret {phone}.";
            return message;
        }

        public void SaveConvertedText()
        {
            
        }
    }
}
