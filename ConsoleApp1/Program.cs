using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emsi;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cargaison [] listCargaison= new Cargaison[4];
            Cargaison A = new Aérienne("A", 100, 1000, 1000000);
            Cargaison B = new Aérienne("B", 20, 200, 2000000);
            Cargaison C = new Routiere("C", 300, 3000, 3000000);
            Cargaison D = new Routiere("D", 40, 400, 4000000);

            listCargaison[0] = A;
            listCargaison[1] = B;
            listCargaison[2] = C;
            listCargaison[3] = D;

            for(int i =0;i< listCargaison.Length; i++)
            {
                if(listCargaison[i].cout_total() > 480000)
                {
                    listCargaison[i].afficher();
                    Console.Write("\n\n");
                }
            }

            Console.ReadKey();
        }


    }
}
