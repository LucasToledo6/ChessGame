﻿namespace ChessGame.tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao {  get; set; }
        public Cor Cor { get; set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab {  get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor)
        {
            Posicao = posicao;
            Tab = tab;
            Cor = cor;
            QteMovimentos = 0;
        }

    }
}
