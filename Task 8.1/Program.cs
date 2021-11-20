using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_8._1
{
    class Program
    {
        private static void Main(string[] args)
        {
            int sum = 0;
            StreamWriter writer = new StreamWriter("C:\\Users\\kreda\\Desktop\\Test\\test.txt"); 
            Random r = new Random();
            for (int i = 1; i <= 10; i++)
            {
                int number = r.Next(1, 10);
                writer.Write(number + ",");
            }
            writer.Close();

            StreamReader reader = new StreamReader("C:\\Users\\kreda\\Desktop\\Test\\test.txt");
            string text = reader.ReadToEnd();
            reader.Close();
            string[] count = text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < 10; j++)
            { sum += Convert.ToInt32(count[j]); }
           
            Console.WriteLine(sum);
            Console.ReadKey();
          }          
    }
    }

