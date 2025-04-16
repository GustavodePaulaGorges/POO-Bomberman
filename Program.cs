using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Jogador> jogadores = new List<Jogador>();

            Campo campo = new Campo(1, 1, 20, 80);
            campo.desenhar();

            jogadores.Add(new Jogador(3, 3, "#", ConsoleKey.W, ConsoleKey.S, ConsoleKey.A, ConsoleKey.D));
            jogadores.Add(new Jogador(60, 15, "%", ConsoleKey.UpArrow, ConsoleKey.DownArrow, ConsoleKey.LeftArrow, ConsoleKey.RightArrow));
            jogadores.Add(new Jogador(30, 8, "@", ConsoleKey.Y, ConsoleKey.H, ConsoleKey.G, ConsoleKey.J));
            jogadores.Add(new Jogador(50, 5, "&", ConsoleKey.NumPad8, ConsoleKey.NumPad5, ConsoleKey.NumPad4, ConsoleKey.NumPad6));

            Console.CursorVisible = false;
            ConsoleKeyInfo tecla;
            while (true)
            {
                tecla = Console.ReadKey(true);
                if (tecla.Key == ConsoleKey.Escape) break;

                foreach(var jog in jogadores)
                {
                    Coordenada pos = jog.simularMovimento(tecla.Key);

                    if (campo.podeMover(pos))
                        jog.mover(tecla.Key);
                        
                }

            }

        }
    }
}