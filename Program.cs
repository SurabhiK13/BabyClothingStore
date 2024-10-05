namespace Test2
{
    public class Program
    {
        public static List<BabyDress> DressesCart { get; set; } = new List<BabyDress>();
        static void Main(string[] args)
        {
            BabyDressUtility babyDresses = new BabyDressUtility();

            while (true)
            {
                Console.WriteLine("1. Add The Dress To Cart");
                Console.WriteLine("2. Remove The Dress From Cart");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter Your Choice From The List Of Options ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Enter Dress Size");
                    int size = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter The Color");
                    string color = Console.ReadLine();

                    Console.WriteLine("Enter the Brand");
                    string brand = Console.ReadLine();

                    Console.WriteLine("Enter The Price");
                    int price = Convert.ToInt32(Console.ReadLine());

                    BabyDress dress = new BabyDress
                    {
                        Size = size,
                        Color = color,
                        Brand = brand,
                        Price = price
                    };
                    babyDresses.AddDressToCart(dress);
                    Console.WriteLine("Successfully added to the dress cart");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter the Dress Brand to Remove");
                    string brandToRemove = Console.ReadLine();
                    if (babyDresses.RemoveDressFromCart(brandToRemove))
                    {
                        Console.WriteLine("Successfully Removed");
                    }
                    else
                    {
                        Console.WriteLine("Brand Not Found In Cart");
                    }
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Thank You");
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }

            }
        }
        }
    }
