namespace MyATMApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyBank bk = new MyBank();

            bool condition = true;

            while (condition)
            {
                Console.WriteLine("1. Check account Balance");
                Console.WriteLine("2. Deposit Funds");
                Console.WriteLine("3. Withdraw Cash");
                Console.WriteLine("4. Transfer Money");

                // Read the user's choice
                string input = Console.ReadLine();
                int choice = Convert.ToInt32(input);

                switch (choice)
                {
                    case 1:
                        bk.checkBalance();
                        break;
                    case 2:
                        bk.depositFunds();
                        break;
                    case 3:
                        bk.withdraw();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }

    }


