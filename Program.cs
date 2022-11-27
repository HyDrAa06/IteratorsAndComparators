using System;
using System.Runtime.InteropServices;

namespace ListyIterator1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input:");

            string[] create = Console.ReadLine().Split();
            if (create.Length <= 1)
            {
                Console.WriteLine("Invalid Input");
                return;
            }
            List<string> temp = new List<string>();
            for(int i = 1; i < create.Length; i++)
            {
                temp.Add(create[i]); 
            }
            

            Iterators<string> iterator = new Iterators<string>();
            iterator.Elements = temp;

            while (true)
            {
                string command = Console.ReadLine();

                if(command == "Print")
                {
                    iterator.Print();
                }
                if (command == "PrintAll")
                {
                    iterator.PrintAll();
                }
                if (command == "Move")
                {
                    Console.WriteLine(iterator.Move());
                }
                if(command == "HasNext")
                {
                    Console.WriteLine(iterator.HasNext());
                }
                if(command == "END")
                {
                    break;  
                }
            }
        }
    }
}