using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {           
            var files = Directory.GetFiles("C:\\Users\\kreda\\Desktop\\Test", "*.*", SearchOption.AllDirectories);
            var dirs = Directory.GetDirectories("C:\\Users\\kreda\\Desktop\\Test", "*.*", SearchOption.AllDirectories);
                       
            Console.WriteLine("По заданному адресу расположены следующие папки:");
            foreach (string j in dirs)
                {
                    Console.WriteLine(j);
                }
            Console.WriteLine();
            Console.WriteLine("По заданному адресу расположены следующие файлы");
              foreach (string i in files)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }           
            
        
    }
}
