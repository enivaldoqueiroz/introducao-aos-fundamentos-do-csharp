using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula126Heranca.Entities
{
    class SavingsAccount : Account
    {
        public double InterstRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number,holder, balance)
        {
            InterstRate = interestRate;
        }

        public void UpdateBalence()
        {
            Balance += Balance * InterstRate;
        }

        public sealed override void WithDraw(double amount)
        {
            base.WithDraw(amount);
            Balance -= 2.0;
        }
    }
}
