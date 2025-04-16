using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman
{
    public class Jogador
    {
        public Coordenada posicao;
        private string simbolo;
        private ConsoleKey cma;
        private ConsoleKey bxo;
        private ConsoleKey esq;
        private ConsoleKey dir;

        public Jogador(int x, int y, string simbolo,
            ConsoleKey cima, ConsoleKey baixo,
            ConsoleKey esquerda, ConsoleKey direita )
        {
            this.posicao = new Coordenada(x, y);
            this.simbolo = simbolo;
            this.cma = cima;
            this.bxo = baixo;
            this.esq = esquerda;
            this.dir = direita;

            this.desenhar();
        }

        public void desenhar()
        {
            Console.SetCursorPosition(this.posicao.X, this.posicao.Y);
            Console.WriteLine(this.simbolo);
        }

        public void apagar()
        {
            Console.SetCursorPosition(this.posicao.X, this.posicao.Y);
            Console.WriteLine(" ");
        }
        
        public void mover(ConsoleKey tecla)
        {
            this.apagar();
            if (tecla == this.esq) this.posicao.X--;
            if (tecla == this.dir) this.posicao.X++;
            if (tecla == this.cma) this.posicao.Y--;
            if (tecla == this.bxo) this.posicao.Y++;
            this.desenhar();
        }

        public Coordenada simularMovimento(ConsoleKey tecla)
        {
            Coordenada pos = new Coordenada(this.posicao.X, this.posicao.Y);
            if (tecla == this.esq) pos.X--;
            if (tecla == this.dir) pos.X++;
            if (tecla == this.cma) pos.Y--;
            if (tecla == this.bxo) pos.Y++;
            return pos;
        }
    }
}
