using System.Diagnostics.Metrics;
using System.Numerics;
using System.Threading.Channels;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta kujund: Teemant; Kolmnurk; Ruut; Ristkülik");

            string g = Console.ReadLine();

            if (g == "Teemant")
            {
                Teemant();
            }
            if (g == "Kolmnurk")
            {
                Kolmnurk();
            }
            if (g == "Ruut")
            {
                Ruut();
            }
            if (g == "Ristkülik")
            {
                Ristkülik();
            }

        }
        static void Teemant()
        {
            int i, j, count = 1, number;
            Console.Write("Sisesta teemanti suurus ");
            number = int.Parse(Console.ReadLine());
            count = number - 1;
            for (j = 1; j <= number; j++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                for (i = 1; i <= 2 * j - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            count = 1;
            for (j = 1; j <= number - 1; j++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count++;
                for (i = 1; i <= 2 * (number - j) - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void Kolmnurk()
        {
            int number, i, j, count = 1;
            Console.Write("Sisesta kolmnurga suurus ");
            number = int.Parse(Console.ReadLine());
            count = number - 1;
            for (j = 1; j <= number; j++)
            {
                #region Printing Space  
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                #endregion
                for (i = 1; i <= 2 * j - 1; i++)
                    Console.Write("*");
                Console.WriteLine();

            }
            Console.ReadLine();
        }

        static void Ruut()
        {
            int Size;

            Console.WriteLine("Sisesta ruudu suurus ");
            Size = Convert.ToInt32(Console.ReadLine());

            for (int row = 0; row < Size; row++)
            {
                for (int column = 0; column < Size; column++)
                {
                    Console.Write("*" + " ");
                }

                Console.WriteLine();
            }
            Console.WriteLine("Ruudu ümbermõõt on:");
            Console.WriteLine(Size * 4);
            Console.WriteLine("Ruudu pindala on:");
            Console.WriteLine(Size * Size);

        }
        static void Ristkülik()
        {
            Console.WriteLine("Sisestage kõrgus: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisestage laius: ");
            int width = Convert.ToInt32(Console.ReadLine());
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                 Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Ristküliku ümbermõõt on:");
            Console.WriteLine( height * 2 + width * 2);
            Console.WriteLine("Ristküliku pindala");
            Console.WriteLine( height * width);
        }
    }
}