using System;

namespace res2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            double pes;
            double alt;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("+=+=- Calculadora De IMC -=+=+");
            Console.ResetColor();

            Console.Write("\nDigite seu peso em kg...: ");
            pes = double.Parse(Console.ReadLine());

            Console.Write("Digite sua altura em m..: ");
            alt = double.Parse(Console.ReadLine());

            double res;
            res = pes / (alt * alt);

            Console.WriteLine($"\nSeu IMC é {res:N2} kg/m².");

            if (res < 17)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Diagnostico: Muito abaixo do peso!");
                Console.ResetColor();
                Environment.Exit(-1);
            }
            if (res >= 17 && res <= 18.49)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Diagnostico: Abaixo do peso");
                Console.ResetColor();
                Environment.Exit(-1);
            }
            if (res >= 18.5 && res <= 24.99)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Diagnostico: Peso normal");
                Console.ResetColor();
                Environment.Exit(-1);
            }      
            if (res >= 25 && res <= 29.99)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Diagnostico: Acima do peso");
                Console.ResetColor();
                Environment.Exit(-1);
            }
            if (res >= 30 && res <= 34.99)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Diagnostico: Obesidade I");
                Console.ResetColor();
                Environment.Exit(-1);
            }
            if (res >= 35 && res <= 39.99)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Diagnostico: Obesidade II (severa)");
                Console.ResetColor();
                Environment.Exit(-1);
            }
            if (res >= 40)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Diagnostico: Obesidade III (mórbida)");
                Console.ResetColor();
                Environment.Exit(-1);
            }
        }
    }
}