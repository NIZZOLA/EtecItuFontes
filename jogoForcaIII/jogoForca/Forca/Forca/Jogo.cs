using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forca
{
    public class Jogo
    {
        List<string> Palavras;
        string Sorteada = "";
        public char[] Decifrada { get; set; }

        public int Tentativas { get; set; }
        public int Acertos { get; set; }
        /*  CODIGO ERRADO SÓ PARA EXEMPLO
        public int Erros {  get { return Tentativas - Acertos; } } */
        public int Erros { get; set; }

        public Jogo()
        {
            Palavras = new List<string>();
        }
        public void AddPalavra( string palavra )
        {
            Palavras.Add(palavra);
        }
        public string SortearPalavra()
        {
            // SORTEIA UM NÚMERO ALEATÓRIO
            Random rnd = new Random();
            int numero = rnd.Next(0, Palavras.Count() - 1);
            // encontra na lista uma palavra pelo número sorteado 
            Sorteada = Palavras[numero];
            // faz uma string em branco do tamanho da palavra sorteada
            Decifrada = new char[Sorteada.Length];
            for (int i = 0; i < Sorteada.Length ; i++)
                Decifrada[i] = ' ';

            Tentativas = 0;
            Acertos = 0;
            
            return Palavras[numero];
        }

        public int PesquisarLetra( char letra )
        {
            int acertos = 0;
            for( int i =0; i <= Sorteada.Length-1; i ++ )
            {
                if (Sorteada[i] == letra)
                {
                    acertos++;
                    Decifrada[i] = letra;
                }
                else
                {
                    if( Decifrada[i] == ' '  )
                       Decifrada[i] = Convert.ToChar(' ');
                }
            }
            this.Acertos += acertos;
            this.Tentativas++;

            if (acertos == 0)
                this.Erros++;

            return acertos;
        }

        public bool Acertou()
        {
            return ! Decifrada.Contains( ' ' );
        }
    }
}
