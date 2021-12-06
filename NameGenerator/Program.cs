using System;
using System.Diagnostics;

namespace NameGenerator
{
    class Program
    {
        public static int pocetJmenCoChciVygenerovat = 50000;
        public static bool chciJmenaUlozitDoTxt = true;

        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            RandomName r1 = new RandomName();
            FileManager fileManager = new FileManager();

            fileManager.GetFirstNames(ref RandomName.firstNameList);
            fileManager.GetLastNames(ref RandomName.lastNameList);

            stopwatch.Start();
            r1.GenerateNames(pocetJmenCoChciVygenerovat);
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime1 = String.Format("Generovani jmen trvalo: {0:00}:{1:00}:{2:00}.{3}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);

            stopwatch.Restart();
            r1.PrintAllNames(ref r1.fullNameListWithNumber);
            stopwatch.Stop();
            ts = stopwatch.Elapsed;
            string elapsedTime2 = String.Format("Vypsani jmen do konzole trvalo: {0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);

            stopwatch.Restart();
            if (chciJmenaUlozitDoTxt)
                fileManager.CreateFileGenerated(r1.fullNameListWithNumber);
            stopwatch.Stop();
            ts = stopwatch.Elapsed;
            string elapsedTime3 = String.Format("Ulozeni do souboru trvalo: {0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);

            Console.WriteLine(elapsedTime1);
            Console.WriteLine(elapsedTime2);
            Console.WriteLine(elapsedTime3);

            Console.ReadKey();
        }

    }
}
