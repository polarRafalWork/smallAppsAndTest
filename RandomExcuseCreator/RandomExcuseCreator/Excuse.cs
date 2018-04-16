using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomExcuseCreator
{
    class Excuse
    {
        // FIELDS
        private string description;
        private string results;
        private DateTime lastUsed;
        private string fileDate;
        private string excusePath;

    

        // CONSTRUCTORS
        public Excuse()
        {
            ExcusePath = "";
        }

        public Excuse(string excusePath)
        {
            OpenFile(excusePath);
        }

        public Excuse(Random random, string folder)
        {
            string[] fileNames = Directory.GetFiles(folder, "*.txt");
            OpenFile(fileNames[random.Next(fileNames.Length)]);
        }

        // PROPERTIES
        public string Description { get => description; set => description = value; }
        public string Results { get => results; set => results = value; }
        public DateTime LastUsed { get => lastUsed; set => lastUsed = value; }
        public string FileDate { get => fileDate; set => fileDate = value; }
        public string ExcusePath { get => excusePath; set => excusePath = value; }


        // SETTERS AND GETTERS

        // METHODS
        public void OpenFile(string filePatch)
        {
            this.ExcusePath = filePatch;
            using (StreamReader reader = new StreamReader(ExcusePath))
            {
                Description = reader.ReadLine();
                Results = reader.ReadLine();
                //DateTime tmpDate = DateTime.ParseExact(reader.ReadLine(), "yyyy-MM-dd,fff", System.Globalization.CultureInfo.InvariantCulture);
                LastUsed = Convert.ToDateTime(reader.ReadLine());
                //LastUsed = tmpDate;
            }

        }

        public void SaveFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(Description);
                writer.WriteLine(Results);
                writer.WriteLine(LastUsed);
            }
        }



    }
}
