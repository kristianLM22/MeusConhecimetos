﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBiteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 100;

            Console.WriteLine("Titular " + contaDaGabriela.titular);
            Console.WriteLine("Agência " + contaDaGabriela.agencia);
            Console.WriteLine("Conta " + contaDaGabriela.numero);
            Console.WriteLine("Saldo " + contaDaGabriela.saldo);

            contaDaGabriela.saldo += 100;

            Console.WriteLine(contaDaGabriela.saldo);


            Console.ReadLine();
        }
    }
}
