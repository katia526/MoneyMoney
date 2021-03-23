using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMoney
{
    class ProRekening : Spaarrekening
    {
        public ProRekening(double saldo): base(saldo)
        {
            Saldo = saldo;
        }
        public override double BerekenRente()
        {

            int aantal = Convert.ToInt32(saldo / 1000);
            if (saldo > 1000.00)
                for (int i = 0; i <= aantal; i++)
                {
                    saldo += 10;
                }
            base.BerekenRente();
            return saldo;
        }
    }
}
