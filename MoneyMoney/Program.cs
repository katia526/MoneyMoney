using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMoney
{
    class Program
    {
        static void Main(string[] args)
        {


            Bankrekening bankrekening = new Bankrekening(500.00);
            Console.WriteLine("Bankrekening " + bankrekening.BerekenRente());
            Spaarrekening spaarrekening = new Spaarrekening(1000.00);
            Console.WriteLine("Spaarrekening " + spaarrekening.BerekenRente());
            ProRekening proRekening = new ProRekening(5000.00);
            Console.WriteLine("Prorekening " + proRekening.BerekenRente());
            Console.WriteLine("voeg geld toe " + bankrekening.VoegGeldToe(100));
            Console.WriteLine("voeg geld toe " + spaarrekening.VoegGeldToe(100));
            Console.WriteLine("voeg geld toe " + proRekening.VoegGeldToe(100));

            Console.WriteLine("haal geld af " + bankrekening.HaalGeldAf(100));
            Console.WriteLine("haal geld af " + spaarrekening.HaalGeldAf(100));
            Console.WriteLine("haal geld af " + proRekening.HaalGeldAf(100));


            Console.ReadLine();
        }
    }
}
