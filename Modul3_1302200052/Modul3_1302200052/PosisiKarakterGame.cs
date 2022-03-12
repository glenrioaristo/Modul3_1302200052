using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3_1302200052
{
    internal class PosisiKarakterGame
    {
        enum State { W, S, jongkok, tengkurap, n };
        public static void Mulai()
        {
            Console.WriteLine("Masukan State");
            State state = State.S;
            while (state != State.n)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "W":
                        Console.WriteLine("jongkok");
                        Console.WriteLine();
                        break;
                    case "S":
                        Console.WriteLine("tengkurap");
                        Console.WriteLine();
                        break;
                    case "N":
                        state = State.n;
                        break;
                    default:
                        Console.WriteLine("Masukan ulang State");
                        break;
                }
            }

        }
    }
}