using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
   partial class BankAccount
    {
        partial void ShowAccount();
        partial void UpdateAccount();
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
