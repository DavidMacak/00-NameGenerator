using System;
using System.Collections.Generic;

namespace NameGenerator
{
    public class RandomName
    {
        public static Random r = new Random();
        public static List<string> firstNameList = new List<string>();
        public static List<string> lastNameList = new List<string>();
        public List<string> fullNameListWithNumber = new List<string>();
        static int count = 0;
        static int rInt;
        static string firstName;
        static string lastName;
        static string fullName;
        static string message;

        public static void GetName()
        {
            firstName = firstNameList[RandomNumber(ref firstNameList)];
            lastName = lastNameList[RandomNumber(ref lastNameList)];
            fullName = firstName + " " + lastName;

        }
        public void GenerateNames(int numberOfNames)
        {
            count = 0;
            for (int i = 0; i < numberOfNames; i++)
            {
                GetName();
                message = count + " " + fullName;
                fullNameListWithNumber.Add(message);
                //Console.WriteLine(message);
                count++;
            }
        }

        private static int RandomNumber(ref List<string> list)
        {
            rInt = r.Next(0, list.Count);

            return rInt;
        }

        public void PrintAllNames(ref List<string> list)
        {
            foreach(string line in list)
            {
                Console.WriteLine(line);
            }
        }

    }
}
