using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
   partial class BankAccount
    {
        public BankAccount()
        {
            ShowAccount();
        }
        partial void ShowAccount()
        {
            Console.WriteLine("Kapital Bank 1000 AZN");
        }
        partial void UpdateAccount()
        {
            Console.WriteLine("Updated Account Successfully");
        }
    }
}
