using System;

namespace Media4Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            Double n1, n2, n3, n4, media;
            String resultado;

            Console.WriteLine("--média--\n");
            Console.WriteLine("Digite suas notas abaixo");

            Console.Write("Nota 1: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 3: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 4: ");
            n4 = Convert.ToDouble(Console.ReadLine());

            if (n1 < 0 || n1 > 10
            || n2 < 0 || n2 > 10
            || n3 < 0 || n3 > 10
            || n4 < 0 || n4 > 10)
            {
                Console.WriteLine("Digite somente notas entre 0 e 10");
            }
            else
            {
                media = (n1 + n2 + n3 + n4) / 4;

                if (media < 5)
                {
                    resultado = "Reprovado";
                }
                else if (media > 6)
                {
                    resultado = "Aprovado";
                }
                else
                {
                    resultado = "Recuperação";
                }

                Console.WriteLine($"Vocẽ ficou com média {media:N1}. resultado: {resultado}");
            }


        }
    }
}
