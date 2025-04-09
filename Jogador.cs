using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman1
{
    internal class Jogador
    {
        private int x;
        private int y;
        private string simbolo;
        private ConsoleKey cma;
        private ConsoleKey bxo;
        private ConsoleKey esq;
        private ConsoleKey dir;



        public Jogador(int x, int y, string simbolo,
            ConsoleKey cima, ConsoleKey baixo,
            ConsoleKey esquerda, ConsoleKey direita )
        {
            this.x = x;
            this.y = y;
            this.simbolo = simbolo;
            this.cma = cima;
            this.bxo = baixo;
            this.esq = esquerda;
            this.dir = direita;

            this.desenhar();
        }

        public void desenhar()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.WriteLine(this.simbolo);
        }

        public void apagar()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.WriteLine(" ");
        }
        
        public void mover(ConsoleKey tecla)
        {
            this.apagar();
            if (tecla == this.cma) y--;
            if (tecla == this.bxo) y++;
            if (tecla == this.esq) x--;
            if (tecla == this.dir) x++;
            this.desenhar();
        }
    }
}
