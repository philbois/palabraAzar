using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;


namespace PalabraAzar
{
    internal class Program
    {
        static string[] Vecpalabra=new string[500];
        public static void Main(string[] args)
        {
            bool bandera;
            do {
                 
                Random rnd = new Random();
                Console.WriteLine();
                Stopwatch tiempo = new Stopwatch();

                tiempo.Start();
                for (int i = 0; i < Vecpalabra.Length; i++)
                {
                    string palabra = "";
                    for (int j = 0; j < 32; j++)
                    {
                        palabra += (rnd.Next(10));
                    }
                    Vecpalabra[i] = palabra;
                }
                tiempo.Stop();
                //Console.WriteLine("ingrese ");
                //string palabra = Console.ReadLine();
                //int longitugd = palabra.Length;
                //int contador = 0;
                //char[] newpalabra = new char[longitugd];
                /* for (int i = longitugd-1; i >= 0; i--)
                 {
                     newpalabra[contador] = palabra[i];
                     contador++;
                 }
                 foreach (char c in newpalabra)
                 {
                     Console.Write(c);
                 }*/
                 int contador = 0;
                for (int i = 0; i <50; i++)
                 {

                     for (int j = 0; j < 10; j++)
                     { Console.Write(" " + Vecpalabra[contador]); contador++; }
                     Console.WriteLine();

                 }
                

                Console.WriteLine("tiempo que demoro " + tiempo.Elapsed.TotalSeconds);
                Console.WriteLine("desea Repetir");
                bandera = Console.ReadLine() == "si";
            } while (bandera);
            burbuja2();
            int contador2 = 0;
            Console.WriteLine("p/r//////////////////////////////////////////////");
            for (int i = 0; i < 50; i++)
            {

                for (int j = 0; j < 10; j++)
                { Console.Write(" " + Vecpalabra[contador2]); contador2++; }
                Console.WriteLine();

            }

            Console.ReadLine();

            
        }
        static public void burbuja2()
        {
            string aux;
            int contador = 0;
            bool bandera = false;
            for (int i = 0; i <Vecpalabra.Length - 1; i++)
            {
                if (bandera)
                {
                    break;
                }
                bandera = true;
                for (int j = 0; j < Vecpalabra.Length - i - 1; j++)
                {

                    if ((Vecpalabra[j]).CompareTo(( Vecpalabra[j + 1]))>0)
                    {
                                                bandera = false;
                        aux = Vecpalabra[j];
                        Vecpalabra[j] = Vecpalabra[j + 1];
                        Vecpalabra[j + 1] = aux;
                    }
                    contador++;

                }
            }
        }
        }


    }
    
