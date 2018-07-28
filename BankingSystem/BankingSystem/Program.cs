using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountDetails;
using AccountHolders;

namespace BankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount;
            int id;

            Console.WriteLine("Press 'A' if you want to see Account Details \n Press 'S' if you want to search for an Account \n Press 'W' if you want to withdraw money \n  Press 'D' if you want to deposit mooney \n Press 'C' if you want to calculate interest");
            Console.WriteLine("Enter operation you want to perform");
            char Case = Console.ReadKey().KeyChar;

            Console.WriteLine("Enter user id");
            id = Int32.Parse(Console.ReadLine());
            User user = new User();

            switch (Case)
            {

                case 'A':

                    user.AccDetails(id);
                    break;

                case 'W':
                    Console.WriteLine("Enter the amount to be withdrawn");
                    amount = Int32.Parse(Console.ReadLine());
                    user.WithrawMoney(id, amount);
                    break;

                case 'S':

                    Account acc = user.SearchAccount(id);
                    if (acc != null)
                        Console.WriteLine("User found");
                    else
                        Console.WriteLine("User NOT found");

                    break;

                case 'D':

                    Console.WriteLine("Enter the amount to be Deposit");
                    amount = Int32.Parse(Console.ReadLine());
                    user.DepositAmount(id, amount);
                    break;

                case 'C':

                    Console.WriteLine("Enter the time for which interest to be calculated");
                    user.CalculateInterest(id);
                    break;


            }

            Console.ReadLine();


        }

    

       }

}

