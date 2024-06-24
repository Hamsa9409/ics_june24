using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_3
{
    class Accounts
    {
        public int Accountnum;
        public string costomername;
        public string accounttype;
        public string transactiontype;
        public int ammount;
        public int balance;
        public Accounts(int Accountnum, string costomername, string accounttype,   int balance)
        {
            this.Accountnum = Accountnum;
            this.costomername = costomername;
            this.accounttype = accounttype;
            
            this.balance = balance;
        }
        public void balanceupdate(string transactiontype,int ammount)
        {
            this.transactiontype = transactiontype;
            this.ammount = ammount;
            if (transactiontype == "D")
            {
                Credit(ammount);
            }
            else if (transactiontype == "W")
            {
                Debit(ammount);

            }
        }
        public void Credit(int ammount)
        {
            balance += ammount;
            Console.WriteLine($"ammount {ammount} credited to your account");
        }
        public void Debit(int ammount)
        {
            if ( ammount > balance)
            {
                Console.WriteLine("balance insufficiant check your balance");
            }
            else
            {
                balance -= ammount;
                Console.WriteLine($"ammount {ammount} debited from your account.");
            }



        }
        public void showdata()
        {
            Console.WriteLine("Account no:"+ Accountnum +"customer name:"+ costomername+"account type:"+ accounttype + "balance:"+ balance);

        }
            






        
        
        
    }
    public class testdata
    {
        public static void Main(string[] args)
        {
            Accounts account = new Accounts(1035467,"HAMSA","SALARY",10000);
            account.showdata();

            account.balanceupdate("D", 1000);
            account.showdata();

            account.balanceupdate("W", 700);
            account.showdata();

            account.balanceupdate("W", 15000);
            account.showdata();

            Console.Read();
        }
    }
}
