using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Methods
{
    class Bank_AC
    {
        int ac_no;
        String ac_type;
        int tot_amt;
        public void accept()
        {
            Console.WriteLine("Enter Account number:");
            ac_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Account type:");
            ac_type = Console.ReadLine();
            Console.WriteLine("Enter Account balance:");
            tot_amt = int.Parse(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine(".........Account details......");
            Console.WriteLine("Account number:"+ac_no+"\nAccount Type:"+ac_type+"\ntotal Amout:"+tot_amt);
        }
        public void withdraw()
        {
            Console.WriteLine("Enter Amount to withdraw:");
            int w = int.Parse(Console.ReadLine());
            tot_amt = tot_amt - w;
            Console.WriteLine("After withdraw:"+tot_amt);
        }
        public void deposit()
        {
            Console.WriteLine("Enter Amount to deposit:");
            int d = int.Parse(Console.ReadLine());
            tot_amt = tot_amt + d;
            Console.WriteLine("After withdraw:" + tot_amt);
        }
        static void Main(string[] args)
        {
            Bank_AC b = new Bank_AC();
            b.accept();
            b.display();
            b.withdraw();
            b.display();
            b.deposit();
            b.display();
        }
    }
}
