using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 86853;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();


            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863853;


            if(contaDaGabriela.saldo >= 100)
            {
                contaDaGabriela.saldo -= 100;
            }
            




            Console.ReadLine();
        }
    }
}
