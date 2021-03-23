using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMoney
{
    abstract class Rekening
    {

        public double Bedrag { get; set; }
        public double saldo;

        public double Saldo
        {
            get { return saldo; }
            internal set { saldo = value; }
           
        }
       
     public double VoegGeldToe(double bedrag)
        {
            saldo += bedrag;
            return saldo;
        }
        public double HaalGeldAf(double bedrag)
        {
            saldo -= bedrag;
            return saldo;
        }

        //   public  HaalGeldAf();


        public abstract double BerekenRente();
    }
}
