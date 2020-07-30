using System;
using GameTop;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {       

        public string Chuta()
        {
            return "\nNivaldo Chutou";
        }

        public string Corre()
        {
            return "\nNivaldo Correu Livre!";
        }

        public string Passa()
        {
            return "\nNivaldo Passou!";
        }

        public int numCamisa()
        {
            Console.Write("\nCamisa ");
            return 10 ;
        }
    }
}