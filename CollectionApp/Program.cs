using System.Collections;
using System.Collections.Generic;

namespace CollectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> groups = new Dictionary<string, string>();
            int[] array= new int[10];
    

            while (groups.Count < 3)
            {
                Console.WriteLine("Xahis edirem group kodunu daxil ediniz");
                string key = Console.ReadLine();
           

                if (!groups.ContainsKey(key))
                {
                    Console.WriteLine("Xahis edirem group adini daxil ediniz");
                    string value = Console.ReadLine();
                    groups.Add(key, value);
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz key elave edilmisdir.");
                }

            }


            foreach (var item in groups)
            {
                Console.WriteLine($"Key: {item.Key} Value: {item.Value}");
            }

       


        }
    }
}
