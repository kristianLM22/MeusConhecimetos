using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Gabriela";
            conta.saldo = 200;


            Console.WriteLine("Titular " + conta.titular);
            Console.WriteLine(conta.agencia);
            Console.WriteLine(conta.saldo);


            Console.ReadLine();

        }
    }
}
