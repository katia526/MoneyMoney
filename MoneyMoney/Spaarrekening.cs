using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMoney
{
    class Spaarrekening : Rekening
    {
        public Spaarrekening(double saldo)
        {
            Saldo = saldo;
        }
        public override double BerekenRente()
        {
            saldo += saldo * 0.02;
            return saldo;
        }
    }

}
