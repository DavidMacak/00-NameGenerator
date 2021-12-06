using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NameGenerator
{
    public class RandomName
    {
        int count = 0;
        int rInt;
        public static Random r = new Random();
        public List<string> firstNameList = new List<string>();
        public List<string> lastNameList = new List<string>();
        public List<string> fullNameListWithNumber = new List<string>();

        public string GetName()
        {
            string firstName = firstNameList[RandomNumber(ref firstNameList)];
            string lastName = lastNameList[RandomNumber(ref lastNameList)];
            string fullName = firstName + " " + lastName;

            return fullName;
        }

        private int RandomNumber(ref List<string> list)
        {
            rInt = r.Next(0, list.Count);

            return rInt;
        }

        public void GenerateNames(int numberOfNames)
        {
            count = 0;
            //int threshold1 = 10000;
            //int threshold2 = 20000;
            //int threshold3 = 30000;
            //int threshold4 = 40000;

            Generate();

            //NEFUNGUJE JAK BY MĚLO
            //if (numberOfNames <= threshold1) //-1000
            //{
            //    Thread t1 = new Thread(Generate);
            //    t1.Start();
            //}
            //if (numberOfNames <= threshold2 && numberOfNames > threshold1)  // 1001-2000
            //{
            //    Thread t2 = new Thread(Generate);
            //    t2.Start();
            //}
            //if (numberOfNames <= threshold3 && numberOfNames > threshold2)  // 2001-3000
            //{
            //    Thread t3 = new Thread(Generate);
            //    t3.Start();
            //}
            //if (numberOfNames <= threshold4 && numberOfNames > threshold3)  // 3001-4000
            //{
            //    Thread t4 = new Thread(Generate);
            //    t4.Start();
            //}
            //if (numberOfNames > threshold4)  // 4001+
            //{
            //    Thread t5 = new Thread(Generate);
            //    t5.Start();
            //}

            void Generate(){
                for (int i = 0; i < numberOfNames; i++)
                {
                    string fullname = GetName();
                    string message = count + " " + fullname;
                    fullNameListWithNumber.Add(message);
                    PrintName(message);
                    count++;
                }
            }
        }

        public void PrintName(string message)
        {
            Console.WriteLine(message);
        }

    }
}
