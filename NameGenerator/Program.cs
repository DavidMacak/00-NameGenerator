using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace NameGenerator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            RandomName myNameGenerator = new RandomName();
            FileManager fileManager = new FileManager();

            fileManager.GetFirstNames(ref myNameGenerator.firstNameList);
            fileManager.GetLastNames(ref myNameGenerator.lastNameList);

            myNameGenerator.GenerateNames(1000000);

            //Task.WaitAll();
            //fileManager.CreateFileGenerated(myNameGenerator.fullNameListWithNumber);

            //List<string> generatedNames = new List<string>();
            //List<string> ram1 = new List<string>();
            //List<string> ram2 = new List<string>();
            //List<string> ram3= new List<string>();
            //List<string> ram4= new List<string>();

            //fileManager.LoadFile("Generated.txt", ref generatedNames);
            //ram1 = generatedNames;
            //ram2 = ram1;
            //ram3 = ram2;
            //ram4 = ram3;

            //Console.WriteLine(generatedNames.Count);
            //Console.WriteLine(generatedNames.Capacity);


            //foreach (string line in generatedNames)
            //{
            //    Console.WriteLine(line);
            //}

            
            Console.ReadKey();
        }

    }
}
