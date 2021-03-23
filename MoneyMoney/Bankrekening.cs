using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMoney
{
    class Bankrekening : Rekening
    {
        public Bankrekening(double saldo)
        {
            Saldo = saldo;
      
        }
        public override double BerekenRente()
        {
            if (saldo > 100)
            {
                saldo += (saldo * 0.05);
                return saldo;
            }
            else
            {
                return saldo;
            }
            
        }
    }
}
