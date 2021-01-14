using System;

namespace Bank
{
    public class Account
    {
        int[] accountNumber = new int[2];
        string[] accountType = new string[2];
        double[] balance = new double[2];

        public bool Deposit(int accNumber, double amount)
        {
            for (int i = 0; i < accountNumber.Length; i++)
            {
                if (accountNumber[i] == accNumber)
                {
                    balance[i] = balance[i] + amount;
                    return true;
                }

            }
            return false;
        }
        public bool withdraw(int accNumber, double amount)
        {
            for (int i = 0; i < accountNumber.Length; i++)
            {
                if (accountNumber[i] == accNumber)
                {
                    balance[i] = balance[i];
                    Console.WriteLine("Insufficienet balance");
                    Console.WriteLine("Mininum balance must be one dollar!");
                }
                else
                {
                    balance[i] = balance[i] - amount;
                    return true;
                }
            }
            return false;
        }
        public int Search(int accNo)
        {
            for (int i = 0; i < accountNumber.Length; i++)
            {
                if (accNo == accountNumber[i])
                    return i;
            }
            return -1;
        }
        public bool AcceptDetail()
        {
            int accNo;
            string accType;
            double bal;
            for (int i = 0; i < accountNumber.Length; i++)
            {
                Console.Write("Enter the account number : ");
                accNo = Convert.ToInt32(Console.ReadLine());
                if (accNo <= 0)
                {
                    Console.WriteLine("Invalid account number!");
                    return false;
                }
                Console.Write("Enter account type[Fixed/Saving]/[F/S]: ");
                string input = Console.ReadLine();
                if(input =="F" || input =="Fixed" || input == "f")
                {
                    accType = "Fixed";
                }
                else if(input =="s" || input =="Saving" || input == "s")
                {
                    accType = "Saving";
                }
                else
                {
                    Console.WriteLine("Invalid data Entry");
                    return false;
                }
                int index = Search(accNo);
                if(index != -1)
                {
                    Console.WriteLine("Current balance : {0}", balance[index]);
                    accountNumber[i] = accNo;
                    accountType[i] = accType;
                    
                }
                else
                {
                    Console.Write("Enter corrent balance : ");
                    bal = Convert.ToDouble(Console.ReadLine());
                    if(bal < 1)
                    {
                        Console.WriteLine("Minimum balance must be one dollar!");
                        return false;
                    }
                    accountNumber[i] = accNo;
                    accountType[i] = accType;
                    balance[i] = bal;
                }
                Console.WriteLine("Enter transaction type : ");
                Console.WriteLine("1. Deposit \n2. Withdrawal");
                Console.Write("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter amuont to be deposited : ");
                        input = Console.ReadLine();
                        if(Convert.ToInt32(input) > 1)
                        {
                            if (Deposit(accountNumber[1], Convert.ToDouble(input)))
                            {
                                Console.WriteLine("Amount deposited successfully");
                            }
                            else
                            {
                                Console.WriteLine("Error in updating balance");
                                return false;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Invalid Amount");
                            return false;
                        }
                        break;
                    case 2:
                        Console.Write("Enter amount to be withdrawn : ");
                        input = Console.ReadLine();
                        if(Convert.ToDouble(input) > 1)
                        {
                            if (withdraw(accountNumber[i], Convert.ToDouble(input)))
                            {
                                Console.WriteLine("Amount successfully withdrawn");
                            }
                            else
                            {
                                Console.WriteLine("Invalid Amount!");
                                return false;
                            }
                   
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        return false;
                }
                Console.WriteLine();
            }
            return false;
        }
        public void DisplayDetail()
        {
            Console.WriteLine("\n Account Details : \n");
            Console.WriteLine("A/c No.\tA/c Type Balance($)");
            Console.Write("{0} \t", accountNumber[0]);
            Console.WriteLine("{0}\t  {1}\t", accountType[0], balance[0]);
            for(int i = 1; i < accountNumber.Length; i++)
            {
                bool found = false;
                for(int j = 0; j < i; j++)
                {
                    if (accountNumber[i] == accountNumber[j])
                        found = true;
                }
                if ( !found)
                {
                    Console.Write("{0} \t", accountNumber[i]);
                    Console.WriteLine("{0}\t {1}\t", accountType[i], balance[i]);
                }
            }
        }
    }
}
