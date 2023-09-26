namespace ChessGame.tabuleiro
{
    internal abstract class Peca //classe genérica
    {
        public Posicao Posicao {  get; set; }
        public Cor Cor { get; set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab {  get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Tab = tab;
            Cor = cor;
            QteMovimentos = 0;
        }

        public void incrementarQteMovimentos()
        {
            QteMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
