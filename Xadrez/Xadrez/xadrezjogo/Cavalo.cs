using tabuleiro;

namespace xadrezjogo
{
    internal class Cavalo : Peca
    {


        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "C";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //cima1

            pos.definirValores(posicao.linha - 1, posicao.coluna -2);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //cima2

            pos.definirValores(posicao.linha - 2, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            
            //cima3

            pos.definirValores(posicao.linha - 1, posicao.coluna +2);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            
            //cima4

            pos.definirValores(posicao.linha - 2, posicao.coluna +1 );
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            
            //baixo1

            pos.definirValores(posicao.linha + 1, posicao.coluna +2 );
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            
               //baixo2

            pos.definirValores(posicao.linha + 2, posicao.coluna +1 );
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            
         
            //baixo3

            pos.definirValores(posicao.linha +1, posicao.coluna -2 );
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            
            //baixo4

            pos.definirValores(posicao.linha + 2, posicao.coluna -1 );
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            return mat;
        }
    }
}