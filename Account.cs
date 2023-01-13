using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Methods
{
    public class Account
    {
        public string Number;
        public string Name;
        public string Type;
        public double OpeningBalance;
        public double CurrentBalance;

        public static void CreateAccount()
        {

        }

        public static void UpdateAccount(string acctno)
        {

        }
        public static void DeleteAccount(string acctno)
        {
            
        }
        public static void ListAccount()
        {

        }
        public double CheckBalance(string acctno)
        {
            return 0;
        }
        public bool DepositMoney(string acctno, double amount)
        {
            return true;
        }
    }
}