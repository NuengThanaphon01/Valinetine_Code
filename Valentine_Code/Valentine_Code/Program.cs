using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valentine_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, n = 10;
            string message = " PROGRAMMING <3 ";
            int print_message = 4;

            if (message.Length % 2 != 0)
                message += " ";
            for (a = 0; a < n; a++)
            {
                for (b = 0; b <= 4 * n; b++)
                {
                    double distance1 = Math.Sqrt(Math.Pow(a - n, 2) + Math.Pow(b - n, 2));
                    double distance2 = Math.Sqrt(Math.Pow(a - n, 2) + Math.Pow(b - 3 * n, 2));
                    if (distance1 < n + 0.5 || distance2 < n + 0.5)
                        Console.Write("S");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            for (a = 1; a < 2 * n; a++)
            {
                for (b = 0; b < a; b++)
                    Console.Write(" ");
                for (b = 0; b < 4 * n + 1 - 2 * a; b++)
                {
                    if (a >= print_message - 1 && a <= print_message + 1)
                    {
                        double point = b-(4 * n - 2 * a - message.Length)/2;
                        if (point < message.Length && point >= 0)
                        {
                            if (a == print_message)
                                Console.Write(
                                    message[(int)point]);
                            else
                                Console.Write(" ");
                        }
                        else
                            Console.Write("S");
                    }
                    else
                        Console.Write("S");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
