using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NameGenerator
{
    public class FileManager
    {
        private string fName = "FirstNames.txt";
        private string lName = "LastNames.txt";

        public FileManager()
        {
            FindFile(fName);
            FindFile(lName);
        }
        private void FindFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                CreateFile(fileName);
            }
        }

        private void CreateFile(string fileName)
        {
            File.WriteAllText(fileName, "New file created");
        }

        public void CreateFileGenerated(List<string> list)
        {
            File.WriteAllLines("Generated.txt", list);
        }

        public void GetFirstNames(ref List<string> list)
        {
            LoadFile(fName, ref list);
        }
        public void GetLastNames(ref List<string> list)
        {
            LoadFile(lName, ref list);
        }

        public void LoadFile(string fileName, ref List<string> list)
        {
            int counter = 0;

            foreach(string line in File.ReadLines(fileName))
            {
                if (fileName == "FirstNames.txt")
                    list.Add(line);
                if (fileName == "LastNames.txt")
                    list.Add(line);
                else
                    list.Add(line);
                counter++;
            }
        }

    }
}
