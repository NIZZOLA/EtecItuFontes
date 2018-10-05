using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormClicavel
{
    public partial class Form1 : Form
    {
        //VARIAVEIS E ARRAYS
        bool jogador = true;
        int jogadas = 0;
        String[,] tabuleiro = new String[3, 3];
        bool ganhou = false;

        public Form1()
        {
            InitializeComponent();
            //DEFININDO O TABULEIRO
            tabuleiro[0, 0] = "";
            tabuleiro[0, 1] = "";
            tabuleiro[0, 2] = "";

            tabuleiro[1, 0] = "";
            tabuleiro[1, 1] = "";
            tabuleiro[1, 2] = "";

            tabuleiro[2, 0] = "";
            tabuleiro[2, 1] = "";
            tabuleiro[2, 2] = "";

            preencheTabuleiro();
        }

        private void preencheTabuleiro()
        {
            btn_1.Text = tabuleiro[0, 0];
            btn_2.Text = tabuleiro[0, 1];
            btn_3.Text = tabuleiro[0, 2];

            btn_4.Text = tabuleiro[1, 0];
            btn_5.Text = tabuleiro[1, 1];
            btn_6.Text = tabuleiro[1, 2];

            btn_7.Text = tabuleiro[2, 0];
            btn_8.Text = tabuleiro[2, 1];
            btn_9.Text = tabuleiro[2, 2];
        }

        private void clique( int linha, int col  )
        {
            if (tabuleiro[linha, col] != "")
            {
                MessageBox.Show("Não pode jogar aqui novamente!");
                return;
            }

            if (jogador)
                tabuleiro[linha, col] = "X";
            else
                tabuleiro[linha, col] = "O";

            preencheTabuleiro();
            jogadas++;
            verificaGanhador();
            
            jogador = !jogador;
            mudarLabel();
        }

        private void mudarLabel()
        {
            if (jogador)
                lbl_informacao.Text = "Vez do jogador 1 (X)";
            else
                lbl_informacao.Text = "Vez do jogador 2 (0)";
        }

        private bool verificaGanhador( )
        {
            ganhou = false;
            string tag = jogador == true ? "X" : "O";

            //POSSIBILIDADES DE GANHAR X - HORIZONTAL
            if ((tabuleiro[0, 0] == tag) && (tabuleiro[0, 1] == tag ) && (tabuleiro[0, 2] == tag))
            {
                ganhou = true;
            }
            else if ((tabuleiro[1, 0] == tag) && (tabuleiro[1, 1] == tag) && (tabuleiro[1, 2] == tag))
            {
                ganhou = true;
            }
            else if ((tabuleiro[2, 0] == tag) && (tabuleiro[2, 1] == tag) && (tabuleiro[2, 2] == tag))
            {
                ganhou = true;
            }

            //POSSIBLIDADES DE GANHAR X - VERTICAL
            if ((tabuleiro[0, 0] == tag) && (tabuleiro[1, 0] == tag) && (tabuleiro[2, 0] == tag))
            {
                ganhou = true;
            }
            else if ((tabuleiro[0, 1] == tag) && (tabuleiro[1, 1] == tag) && (tabuleiro[2, 1] == tag))
            {
                ganhou = true;
            }
            else if ((tabuleiro[0, 2] == tag) && (tabuleiro[1, 2] == tag) && (tabuleiro[2, 2] == tag))
            {
                ganhou = true;
            }

            //POSSIBLIDADES DE GANHAR X - DIAGONAL
            if ((tabuleiro[0, 0] == tag) && (tabuleiro[1, 1] == tag) && (tabuleiro[2, 2] == tag))
            {
                ganhou = true;
            }
            else if ((tabuleiro[0, 2] == tag) && (tabuleiro[1, 1] == tag) && (tabuleiro[2, 0] == tag))
            {
                ganhou = true;
            }

            if( ganhou )
            {
                MessageBox.Show("O jogador " + (jogador == true ? "1" : "2") + " " + tag + " ganhou !");
            }

            if (jogadas == 9 && !ganhou)
                MessageBox.Show("Fim de jogo, não houve ganhadores !");

            return ganhou;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            clique(2, 0);
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            clique(2, 1);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            clique(2, 2);
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            clique(0, 0);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            clique(0, 1);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            clique(0, 2);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            clique(1, 0);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            clique(1, 1);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            clique(1, 2);
        }
    }
}
