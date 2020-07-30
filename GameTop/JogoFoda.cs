using System;

namespace GameTop
{
    class JogoFoda
    {
        private readonly iJogador _jogadorA;

        private readonly iJogador _jogadorB;

        public JogoFoda(iJogador jogador1,iJogador jogador2)
        {
            _jogadorA = jogador1;
            _jogadorB = jogador2;
        }

        public void IniciaJogo()
        {
            Console.Write(_jogadorA.Corre()) ;
            
            Console.Write(_jogadorA.Chuta()) ;
            
            Console.Write(_jogadorA.Passa());

            Console.Write("\n\nProximo Jogador \n");

            Console.Write(_jogadorB.Corre());
                
            Console.Write(_jogadorB.Chuta());
            
            Console.Write(_jogadorB.Passa());

        Console.Write(_jogadorA.numCamisa());

        System.Console.WriteLine();

        Console.Write(_jogadorB.numCamisa());            
          
        }
        
    }

   
}