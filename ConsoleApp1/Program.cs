using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("Hello!");
                Console.WriteLine("Please, write your Name");
                string Name_client = Console.ReadLine();
                Console.WriteLine("please,write your surname");
                string SurName_client = Console.ReadLine();
                Console.WriteLine("Please,write your problem");
                string problem = Console.ReadLine();
                using (StreamWriter sw = new StreamWriter($"write_num{i}.txt",true,Encoding.UTF8))
                {
                    sw.WriteLine("Name of client " + Name_client);
                    sw.WriteLine("Surname of client " + SurName_client);
                    sw.WriteLine($"The problem of {Name_client} is " + problem);
                }
                i++;
            }
            for (int j = 0; j <= i; j++)
            {
                using (StreamReader sr = new StreamReader($"write_num{j}.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                    Console.WriteLine($"The write of number {j} is end");
                }
            }
            Console.ReadLine();
        }




    }
}


