using System;

namespace VolumeEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio;
            double volume;

            Console.WriteLine("Digite o raio da esfera");
            raio = Convert.ToDouble(Console.ReadLine());

            volume =  (4 * (3.14) * Math.Pow(raio, 3)) / 3;
            Console.WriteLine("O valor do volume da esfera é {0}", volume);
        }
    }
}
