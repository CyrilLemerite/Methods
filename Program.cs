using Methods;

Account[] accounts = new Account[100];
bool cont = true;

do
{
    //Console.Clear();
    Console.WriteLine("************************");
    Console.WriteLine("Merit Financials (MeritFi)");
    Console.WriteLine("*************************");
    Console.WriteLine();
    Console.WriteLine("Select an Option:");
    Console.WriteLine();

    Console.Beep();
    Console.WriteLine("1. Create Custormer Account");
    Console.WriteLine("2. Update Custormer Account");
    Console.WriteLine("3. Delete Custormer Account");
    Console.WriteLine("4. List Custormer Account");
    Console.WriteLine();

    Console.Write("Option: ");
    int option = Convert.ToInt32(Console.ReadLine());
    Console.Beep();
    Console.WriteLine();
    switch (option)
    {
        case 1:

            Console.WriteLine("Enter Custormer Information: ");
            Account account = new Account();

            Console.Write("Name: ");
            account.Name = Console.ReadLine();

            Console.Write("Type Current(c) or Savings(s): ");
            string type = Console.ReadLine();
            if (type.ToLower() == "current" || type.ToLower() == "c")
            {
                account.Type = "Current";
            }
            else if (type.ToLower() == "savings" || type.ToLower() == "s")
            {
                account.Type = "Savings";
            }
            else
            {
                account.Type = "Savings";
            }

            Console.Write("Opening Balance: ");
            account.OpeningBalance = Convert.ToDouble(Console.ReadLine());

            account.CurrentBalance = account.OpeningBalance;
            Console.WriteLine("Current Balance: " + account.CurrentBalance);


            int j = 0;
            bool canCreate = false;
            do
            {
                if (accounts[j] == null)
                {
                    canCreate = true;
                    account.Number = Convert.ToString((accounts.Length - 100) + 1).PadLeft(4, '0');
                    Console.WriteLine("Account Number: " + account.Number);
                    accounts[j] = account;
                }
                j++;

            } while (canCreate = false && j < 100);

            break;

        case 2:

            break;

        case 3:

            break;

        case 4:
            Console.WriteLine("**************************************");
            Console.WriteLine("List of Account Holders in Merite Bank");
            Console.WriteLine("**************************************");
            Console.WriteLine();

            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] != null)
                {
                    Account acct = accounts[i];
                    Console.WriteLine("Name: " + acct.Name + " Number: " + acct.Number);
                }

            }
            break;

    }
    Console.WriteLine();
    Console.Beep();
    Console.Write("Do you want to continue? Yes(Y) or No(N): ");
    string ans = Console.ReadLine();
    if (ans.ToLower() == "yes" || ans.ToLower() == "y")
    {
        cont = true;
    }
    else
    {
        cont = false;
    }
} while (cont == true);

Console.WriteLine();
Console.WriteLine("Thank you for using this app.");
Console.WriteLine();




















