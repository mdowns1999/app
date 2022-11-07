/***********************************************************
* TRANSACTION CLASS
* Handle any changes to the amounts in the account list.
************************************************************/
class Transactions
{
    /*************************************************
    * DISPLAY ACCOUNT AMOUNT
    **************************************************/
    public void displayAccountAmount(List<Account> accounts, int accountLocation)
    {
        // accounts = accountList.getAccountList();
        Console.WriteLine("Your Amount is: $" + accounts[accountLocation].accountAmount);
    }

    /*************************************************
    * WITHDRAWL AMOUNT
    * Withdrawl an amount from the user
    **************************************************/
    public void withdrawlAmount(List<Account> accounts, int accountLocation)
    {
        // accounts = accountList.getAccountList();
        bool valid = false;

        while(!valid)
        {
        Console.WriteLine("What Amount would you like to withdrawl?");
        string withdrawl = Console.ReadLine();
        double withdrawlNum = Convert.ToDouble (withdrawl);

        if (withdrawlNum >= 0 || accounts[accountLocation].accountAmount > 0)
        {
            double amount = accounts[accountLocation].accountAmount -= withdrawlNum;
            accounts[accountLocation].Transactions.Add(amount);
            valid = true;
        }
        }
        Console.WriteLine("Your New Amount is: $" + accounts[accountLocation].accountAmount);
    }

    /*************************************************
    * DEPOSIT AMOUNT
    * Deposit an amount from the user
    **************************************************/
        public void depositAmount(List<Account> accounts, int accountLocation)
    {
        // accounts = accountList.getAccountList();
        bool valid = false;

        while(!valid)
        {
        Console.WriteLine("What Amount would you like to Deposit?");
        string withdrawl = Console.ReadLine();
        double withdrawlNum = Convert.ToDouble (withdrawl);

        if (withdrawlNum >= 0)
        {
            double amount = accounts[accountLocation].accountAmount += withdrawlNum;
            accounts[accountLocation].Transactions.Add(amount);
            valid = true;
        }

        Console.WriteLine("Please enter a valid amount.");
        }
        Console.WriteLine("Your New Amount is: $" + accounts[accountLocation].accountAmount);
    }

    /*************************************************
    * GET RECENT TRANSACTIONS
    * Get the five most recent transactions
    **************************************************/
    public void getRecentTrasactions(List<Account> accounts, int accountLocation)
    {
        // accounts = accountList.getAccountList();
        int num = 1;
        for (var i = accounts[accountLocation].Transactions.Count - 1; num != 6 && i >= 0; i--) 
        {
            Console.WriteLine("Transaction " + num + ": $" + accounts[accountLocation].Transactions[i]);
            num ++;
        }

    }

    /*************************************************
    * GET REPORT
    * Get a Bank Report of their amount and list of transactions
    **************************************************/
        public void getReport(List<Account> accounts, int accountLocation)
    {
        // accounts = accountList.getAccountList();
        Console.WriteLine("***BANK REPORT***");
        Console.WriteLine("Your Amount is: " + accounts[accountLocation].accountAmount);
        getRecentTrasactions(accounts, accountLocation);
        Console.WriteLine("*REPORT END*");

    }





}
