using Aula126Heranca.Entities;
using System;

namespace Aula126Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aula 126");
            Console.WriteLine();
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            //A propriedade ou indexador 'propriedade / indexador'
            //não pode ser usado neste contexto porque o acessador definido está inacessível
            //account.Balance = 200.00; //O atributo Balance esta protect na classe Account

        }
    }
}
