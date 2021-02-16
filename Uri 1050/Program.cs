using System;

namespace Uri_1050
{
    class Program
    {
        static void Main(string[] args)
        {
            int ddd;

            ddd = int.Parse(Console.ReadLine());

            switch (ddd)
            {
                case 61:
                    Console.WriteLine();
                    Console.WriteLine("Brasília");
                    break;

                case 71:
                    Console.WriteLine();
                    Console.WriteLine("Salvador");
                    break;

                case 11:
                    Console.WriteLine();
                    Console.WriteLine("São Paulo");
                    break;

                case 21:
                    Console.WriteLine();
                    Console.WriteLine("Rio de Janeiro");
                    break;

                case 32:
                    Console.WriteLine();
                    Console.WriteLine("Juiz de Fora");
                    break;

                case 19:
                    Console.WriteLine();
                    Console.WriteLine("Campinas");
                    break;

                case 27:
                    Console.WriteLine();
                    Console.WriteLine("Vitória");
                    break;

                case 31:
                    Console.WriteLine();
                    Console.WriteLine("Belo Horizonte");
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("DDD Inválido");
                    break;
            }

        }
    }
}
