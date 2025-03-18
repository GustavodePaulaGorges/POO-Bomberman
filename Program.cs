using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instanciando um novo objeto da classe campo
            // classe objeto  new construtor(param1, param2...)
            Campo campo = new Campo(1, 1, 20, 70);
            campo.desenhar();

            Jogador jog1 = new Jogador(2, 2, "#", 
                ConsoleKey.W, ConsoleKey.S, 
                ConsoleKey.A, ConsoleKey.D);
            jog1.desenhar();

            Jogador jog2 = new Jogador(70, 20, "%",
                ConsoleKey.UpArrow, ConsoleKey.DownArrow,
                ConsoleKey.LeftArrow, ConsoleKey.RightArrow);
            jog2.desenhar();

            ConsoleKeyInfo tecla;
            while (true)
            {
                tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.Escape) break;

                jog1.mover(tecla.Key);
                jog2.mover(tecla.Key);
            }

        }
    }
}