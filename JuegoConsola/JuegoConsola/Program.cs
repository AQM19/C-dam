using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JuegoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            //http://stackoverflow.com/questions/5891538/c-sharp-listen-for-key-press-in-console-app

            Granizo g = new Granizo(10, 10);

            // Console.WriteLine("Press ESC to stop");
            do
            {
                g.AvanzarLinea();
               // while (!Console.KeyAvailable)
                //{
                    for(int i = 0; i < g.Estado.GetLength(0); i++)
                    {
                        for(int j = 0; j < g.Estado.GetLength(1); j++)
                        {
                            Console.Write(g.Estado[i,j]);
                        }
                        Console.WriteLine();
                    }
                Console.WriteLine();
                //}
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
