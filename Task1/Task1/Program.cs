using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ad daxil edin:");
            string name = Console.ReadLine();

            Console.WriteLine(" ");

            sbyte age;


            Console.WriteLine("Yas daxil edin(0-124 arasi):");
            age = sbyte.Parse(Console.ReadLine());



            try
            {
                Person person = new Person()
                {
                    Name = name,
                    Age = age
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
