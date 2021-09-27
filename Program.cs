using System;

namespace Projetil
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objetivo: Um projétil é lançado em um ângulo θ° (teta graus) a uma velocidade inicial v0 m/s. Calcule, em metros, o alcance máximo xmax e a altura máxima atingida hmax.

            const double pi = 3.1415926535897931;
            const double g = 9.80665;

            Console.WriteLine("-- Projétil --\n");

            Console.Write("Entre com a velocidade, em m/s..: ");
            double vel = double.Parse(Console.ReadLine());

            Console.Write("Entre com o ângulo, em graus....: ");
            double ang = double.Parse(Console.ReadLine());

            double xmax = ((Math.Pow(vel, 2))*(Math.Sin((ang*2) * pi / 180)))/g;
            double hmax = (Math.Pow((vel * Math.Sin(ang * pi / 180)), 2)/(2*g));

            Console.WriteLine($"\nAlcance........: {Math.Round(xmax,2)} m");
            Console.WriteLine($"Altura máxima..: {Math.Round(hmax,2)} m");
        }
    }
}
