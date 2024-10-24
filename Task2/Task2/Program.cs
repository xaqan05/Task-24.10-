using Core.Models;
using Core.Helpers.Enums;
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name;

            double price;

            string num;

            TypeEnum type = TypeEnum.Meat;
            TypeEnum type2 = TypeEnum.Meat;
            bool condition = false;

            Store store = new Store();
            try
            {


                do
                {
                    Console.WriteLine("1.Mehsul yaratmaq ucun 1 secin.");
                    Console.WriteLine("2.Type gore filterlemek ucun 2 secin.");
                    Console.WriteLine("3.Butun mehsullari gormek ucun 3 secin.");
                    Console.WriteLine("Cixis etmek ucun 0 secin.");

                    Console.Write("Qiymet daxil edin:");

                    string input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            Console.Clear();
                            Console.Write("Ad daxil edin:");
                            name = Console.ReadLine();

                            Console.WriteLine(" ");
                            Console.Clear();


                            Console.Write("Qiymet daxil edin:");
                            price = double.Parse(Console.ReadLine());

                            Console.WriteLine(" ");

                            Console.Clear();

                            Console.WriteLine("1.Baker");
                            Console.WriteLine("2.Drink");
                            Console.WriteLine("3.Meat");
                            Console.WriteLine("4.Diary");

                            Console.Write("Type secin:");

                            num = Console.ReadLine();

                            switch (num)
                            {
                                case "1":
                                    type = TypeEnum.Baker; break;
                                case "2":
                                    type = TypeEnum.Drink; break;
                                case "3":
                                    type = TypeEnum.Meat; break;
                                case "4": type = TypeEnum.Diary; break;
                                default:
                                    Console.WriteLine("Duzgun secim edin!");
                                    break;
                            }



                            Product product = new Product(name, price, type);

                            store.AddProduct(product);

                            Console.WriteLine("Mehsul ugurla elave olundu.");

                            break;

                        case "2":

                            Console.Clear();

                            Console.WriteLine("1.Baker");
                            Console.WriteLine("2.Drink");
                            Console.WriteLine("3.Meat");
                            Console.WriteLine("4.Diary");

                            Console.WriteLine("Secim edin:");

                            string input1 = Console.ReadLine();

                            switch (input1)
                            {
                                case "1":
                                    type2 = TypeEnum.Baker; break;
                                case "2":
                                    type2 = TypeEnum.Drink; break;
                                case "3":
                                    type2 = TypeEnum.Meat; break;
                                case "4": type2 = TypeEnum.Diary; break;
                                default:
                                    Console.WriteLine("Duzgun secim edin!");
                                    break;
                            }
                            Product[] products = store.FilterProductsByType(type2);


                            for (int i = 0; i < products.Length; i++)
                            {
                                Console.WriteLine($"No: {products[i].No}, Name: {products[i].Name}, Price: {products[i].Price}, Type: {products[i].Type.ToString()}");
                            }

                            break;
                        case "3":
                            Console.Clear();

                            Product[] products1 = store.GETALL();

                            for (int i = 0; i < products1.Length; i++)
                            {
                                Console.WriteLine($"No: {products1[i].No}, Name: {products1[i].Name}, Price: {products1[i].Price}, Type: {products1[i].Type.ToString()}");
                            }

                            break;

                        case "0":
                            condition = true;
                            break;

                    }


                } while (!condition);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            Product[] test = store.RemoveProduct(1);





            /*Console.WriteLine($"No: {test.No} Name: {test.Name}, Type: {test.Type}, Price: {test.Price}");*/


            /* for (int i = 0; i < Produst.Length; i++)
             {
                 Console.WriteLine($"No: {Produst[i].No} Name: {Produst[i].Name}, Type: {Produst[i].Type}, Price: {Produst[i].Price}");
             }*/
        }
    }
}
