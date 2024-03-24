// See http s://aka.ms/new-console-template for more information
//using System.Security.Cryptography.X509Certificates;






using System;
using System.Globalization;

namespace PrimeiraAplicacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            int x = int.Parse(Console.ReadLine());
            double soma = 0;
            int contador = 0;
            double mediaIdades;

            if (x < 0) { Console.WriteLine("impossivel calcular");
            }
            else
            {
                while (x > 0)
                {
                   
                    soma += x;

                    x = int.Parse(Console.ReadLine());
                    contador += 1;



                }
                mediaIdades = soma / contador;
                Console.WriteLine(mediaIdades.ToString("f2"));
            }
            
            
        

           // Console.WriteLine(mediaIdades.ToString("f2"));
         
            




        }


    }
}





