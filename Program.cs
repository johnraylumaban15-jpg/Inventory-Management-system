namespace Inventory_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Inventory Management System!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            string correctUsername = "admin";
            string correctPassword = "password";
            string username;
            string password;

            do
            {
                Console.WriteLine("Input Your Username: ");
                username = Console.ReadLine();
                Console.WriteLine("Input Your Password: ");
                password = Console.ReadLine();

                if (username != correctUsername || password != correctPassword)
                {
                    Console.WriteLine("Incorrect username or password. Please try again.\n");
                }
            }
            while (username != correctUsername || password != correctPassword);

            Console.WriteLine("Login successful!");
            Console.WriteLine("Welcome to the Inventory Management System Mr/Ms " + username);
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. Update Item");
            Console.WriteLine("4. View Inventory");
            Console.WriteLine("5. Exit");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("AddItem");
                    break;
                case "2":
                    Console.WriteLine("Remove Item");
                    break;
                case "3":
                    Console.WriteLine("Update Item");
                    break;
                case "4":
                    Console.WriteLine("View Inventory");
                    break;
                case "5":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }


    }
}