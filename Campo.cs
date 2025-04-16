using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman
{
    public class Campo
    {
        private int coluna;
        private int linha;
        private int altura;
        private int largura;

        public Campo(int col, int lin, int alt, int lar)
        {
            this.coluna = col;
            this.linha = lin;
            this.altura = alt;
            this.largura = lar;
        }

        public void desenhar()
        {
            int colunaFinal = this.coluna + this.largura;
            int linhaFinal = this.linha + this.altura;

            for (int x = this.coluna; x <= colunaFinal; x++)
            {
                // Linha horizontal superior
                Console.SetCursorPosition(x, this.linha);
                Console.Write('-');

                // Linha horizontal inferior
                Console.SetCursorPosition(x, linhaFinal);
                Console.Write('-');
            }

            for (int y = this.linha; y <= linhaFinal; y++)
            {
                // Linha vertical esquerda
                Console.SetCursorPosition(this.coluna, y);
                Console.Write('|');

                // Linha vertical direita
                Console.SetCursorPosition(colunaFinal, y);
                Console.Write('|');
            }
        }

        public bool podeMover(Coordenada pos)
        {
            bool pode = true;

            if (pos.X <= this.coluna) pode = false;
            if (pos.X >= this.coluna + this.largura) pode = false;
            if (pos.Y <= this.linha) pode = false;
            if (pos.Y >= this.linha + this.altura) pode = false;

            return pode;
        }
    }
}
