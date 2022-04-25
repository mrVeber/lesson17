using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account<string> account = new Account<string>();
            account.Input();
            Console.Write(account.GetInfo());

            Console.ReadKey();
            Console.Clear();

            Account<int> account1 = new Account<int>();
            account1.Input();
            Console.Write(account1.GetInfo());

            Console.ReadKey();
        }
    }
}
