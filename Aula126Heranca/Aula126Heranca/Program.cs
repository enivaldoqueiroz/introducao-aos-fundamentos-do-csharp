using Aula126Heranca.Entities;
using System;

namespace Aula126Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Console.WriteLine("Aula 126");
            //Console.WriteLine();
            //BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            //Console.WriteLine(account.Balance);

            //A propriedade ou indexador 'propriedade / indexador'
            //não pode ser usado neste contexto porque o acessador definido está inacessível
            //account.Balance = 200.00; //O atributo Balance esta protect na classe Account
            */

            /*
            //Aula127Upcasting e downcasting

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002,"Maria", 0.0, 500.0);

            //UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1003, "Bob", 0.0, 200.0);

            //DOWNCASTING

            //BusinessAccount acc4 = (BusinessAccount)acc2;
            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                //Outra forma de aplicar o casting
                BusinessAccount acc5 = acc3 as BusinessAccount;
                
                acc5.Loan(200.0);
            }

            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;

                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalence();
                Console.WriteLine("Update!");
            }
            */

            //Aula128.Sobreposição, palavras virtual, override e base

            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.WithDraw(10.0);
            acc2.WithDraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

        }
    }
}
