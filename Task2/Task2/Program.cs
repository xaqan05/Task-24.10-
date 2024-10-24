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

            TypeEnum? type = null;
            TypeEnum? type2 = null;
            bool condition = false;
            int choice;
            int choice2;

            Store store = new Store();
            try
            {


                do
                {
                    Console.WriteLine("1.Mehsul yaratmaq ucun 1 secin.");
                    Console.WriteLine("2.Mehsulu silmek ucun (no) 2 secin");
                    Console.WriteLine("3.Mehsullari type gore filterlemek ucun 3 secin.");
                    Console.WriteLine("4.Mehsul no gore elde etmek ucun 4 secin.");
                    Console.WriteLine("5.Mehsullari adina gore filterlemek ucun 5 secin.");
                    Console.WriteLine("6.Butun mehsullari gormek ucun 6 secin.");
                    Console.WriteLine("Cixis etmek ucun 0 secin.");

                    Console.WriteLine(" ");

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


                            bool condition2 = false;

                            do
                            {
                                Console.Write("Qiymet daxil edin:");
                                condition2 = double.TryParse(Console.ReadLine(), out price);
                            } while (!condition2);


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


                            if (type != null)
                            {

                                Product product = new Product(name, price, type.Value);
                                store.AddProduct(product);
                                Console.WriteLine("Mehsul ugurla elave olundu.");
                                Console.WriteLine(" ");
                            }

                            else
                            {
                                Console.WriteLine("Mehsul elave edilmedi.");
                                Console.WriteLine(" ");
                            }





                            break;
                        case "2":
                            Console.Clear();
                            bool condition3 = false;

                            do
                            {
                                Product[] products2 = store.GetAll();

                                for (int i = 0; i < products2.Length; i++)
                                {
                                    products2[i].ShowInfo();
                                }
                                Console.WriteLine(" ");

                                Console.Write("Silmek istediyiniz mehsulun no- girin:");

                                condition3 = int.TryParse(Console.ReadLine(), out choice);
                                for (int i = 0; i < products2.Length; i++)
                                {
                                    if (choice == products2[i].No)
                                    {
                                        store.RemoveProduct(choice);
                                        Console.WriteLine(" ");
                                        Console.WriteLine("Secdiyiniz mehsul ugurla silindi.");
                                        Console.WriteLine(" ");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Qeyd etdiyiniz mehsul siyahida yoxdur.");
                                        Console.WriteLine(" ");
                                    }
                                }



                            } while (!condition3);
                            break;
                        case "3":

                            Console.Clear();

                            Console.WriteLine("1.Baker");
                            Console.WriteLine("2.Drink");
                            Console.WriteLine("3.Meat");
                            Console.WriteLine("4.Diary");
                            Console.WriteLine(" ");
                            Console.Write("Hansi type gore filterlemek isteyirsiniz:");

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

                            if (type2 != null)
                            {

                                Product[] products = store.FilterProductsByType(type2.Value);
                                if (products.Length != 0)
                                {
                                    for (int i = 0; i < products.Length; i++)
                                    {
                                        products[i].ShowInfo();
                                        Console.WriteLine(" ");
                                    }
                                }

                                else
                                {
                                    Console.WriteLine("Axtardiginiz mehsul tapilmadi.");
                                    Console.WriteLine(" ");

                                }
                            }
                            else
                            {
                                Console.WriteLine("Axtardiginiz mehsul tapilmadi.");
                                Console.WriteLine(" ");

                            }




                            break;
                        case "4":
                            Console.Clear();

                            bool condition4 = false;
                            do
                            {
                                Console.Write("Elde etmek istediyiniz mehsulun no girin:");

                                condition4 = int.TryParse(Console.ReadLine(), out choice2);



                                Product foundProduct = store.GetProduct(choice2);

                                if (foundProduct != null)
                                {
                                    foundProduct.ShowInfo();
                                    Console.WriteLine(" ");
                                }
                                else
                                {
                                    Console.WriteLine("Axtardiginiz mehsul tapilmadi.");
                                    Console.WriteLine(" ");
                                }

                            } while (!condition4);

                            break;

                        case "5":
                            Console.Clear();

                            Console.WriteLine("Axtarmaq istediyiniz mehsulun adini daxil edin:");

                            string name1 = Console.ReadLine();

                            Product[] products3 = store.FilterProductByName(name1);

                            if (products3.Length != 0)
                            {
                                for (int i = 0; i < products3.Length; i++)
                                {
                                    products3[i].ShowInfo();
                                    Console.WriteLine(" ");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Axtardiginiz mehsul tapilmadi.");

                            }


                            break;
                        case "6":
                            Console.Clear();

                            Product[] products1 = store.GetAll();

                            for (int i = 0; i < products1.Length; i++)
                            {
                                products1[i].ShowInfo();
                                Console.WriteLine(" ");
                            }

                            break;

                        case "0":
                            condition = true;
                            break;
                        default:
                            Console.WriteLine("Zehmet olmasa duzgun secim edin.");
                            break;

                    }


                } while (!condition);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
