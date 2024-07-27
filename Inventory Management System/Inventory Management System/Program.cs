namespace Inventory_Management_System
{
    internal class Program
    {
        const int numberOfProudct = 50;
        static string[,] Proudcts = new string[numberOfProudct, 3];
          static int productCount = 0;

        //add product 
        //update product (id ,name ,quanitiy , price)
        //view product
        //exit 
        static void Main(string[] args)
        {

           


            Console.WriteLine("Welcome to the inventory system :)");

            while (true)
            {
                Console.WriteLine("=============================================");


                Console.Write("[1]Add product\n[2]Update product\n[3]View product\n[4]Exit\nEnter your choice: ");
                var userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        //add product
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("How much product you want to add ?");
                        int productAdd = int.Parse(Console.ReadLine());
                        for (int i = 0; i <productAdd; i++)
                        {
                            AddProduct();
                            Console.WriteLine("******");
                        }
                        break;
                    case 2:
                        //update product
                        Console.WriteLine("---------------------------------------");
                        UpdateProduct();
                        break;
                    case 3:
                        //view product
                        Console.WriteLine("---------------------------------------");
                        ViewProduct();
                        break;
                    case 4:
                        //exit
                        Environment.Exit(0);
                        break;

                }
            }
        }

        private static void AddProduct()
        {
            Console.Write("Enter product name : ");
            string name = Console.ReadLine();

            Console.Write("Enter product quantity : ");
            string quantity = Console.ReadLine();

            Console.Write("Enter product price: ");
            string price = Console.ReadLine();

            Proudcts[productCount, 0] = name;
            Proudcts[productCount, 1] = quantity;
            Proudcts[productCount, 2] = price;

            productCount++;

            Console.WriteLine("Product added successfully");

        }

        private static void UpdateProduct()
        {
            Console.Write("Enter prodcut name :");
            string searchProduct = Console.ReadLine();
            int productID = -1;

            if (productCount > 0)
            {


                for (int i = 0; i < productCount; i++)
                {
                    if ( Proudcts[i, 0]== searchProduct)
                    {
                        productID = i;
                        break;
                    }
                }
                if (productID != -1)
                {
                    Console.Write("Enter the new name: ");
                    var newName = Console.ReadLine();

                    Console.Write("Enter the new quantity: ");
                    var newQuantity = Console.ReadLine();

                    Console.Write("Enter the new price: ");
                    var newPrice = Console.ReadLine();

                    Proudcts[productID, 0] = newName;
                    Proudcts[productID, 1] = newQuantity;
                    Proudcts[productID, 2] = newPrice;

                    Console.WriteLine("Products updated successfully ");
                }
            }
            else
            {
                Console.WriteLine("Product not found");
            }
        }

        private static void ViewProduct()
        {
            Console.WriteLine("Product List ");

            if (productCount > 0)
            {
               for (int i = 0; i < productCount; i++)
                {
                    Console.WriteLine($"Product ID is :{i+1}");
                    Console.WriteLine($"Product name is :{Proudcts[i, 0]}");
                    Console.WriteLine($"Product quantity is :{Proudcts[i, 1]}");
                    Console.WriteLine($"Product price is :{Proudcts[i, 2]}");
                    Console.WriteLine("++++++++++++++++++++++++");
                }
            }
        }
    }
}