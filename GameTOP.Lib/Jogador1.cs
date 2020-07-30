using System;
using GameTop;

namespace GameTOP.Lib
{
    public class Jogador1 :iJogador
    { 

        public string Chuta()
        {
            return "\nMessi esta chutando";
        }

        public string Corre()
        {
            return "\nMessi esta Correndo";
        }

        public string Passa()
        {
            return "\nMessi esta passando";
        }

        public int numCamisa()
        {
            Console.Write("\n\nCamisa ");
            return 7 ;
        }
    }
}