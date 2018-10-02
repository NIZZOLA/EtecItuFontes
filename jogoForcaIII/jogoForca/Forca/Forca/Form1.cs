using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forca
{
    public partial class Form1 : Form
    {
        Jogo funcoes = new Jogo();

        public Form1()
        {
            InitializeComponent();

            funcoes.AddPalavra("BATATA");
            funcoes.AddPalavra("TOMATE");
            funcoes.AddPalavra("ABACAXI");
            funcoes.AddPalavra("BANANA");
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            char letra = Convert.ToChar(txtLetra.Text);
            int retorno = funcoes.PesquisarLetra(letra);
            
            MontaPlacar();
            if (funcoes.Erros == 7)
            {
                btnConfirma.Visible = false;
                MessageBox.Show("Game over !");
            }
        }

        private void MontaPlacar()
        {
            lblAcertos.Text = funcoes.Acertos.ToString();
            lblErros.Text = funcoes.Erros.ToString();
            lblTentativas.Text = funcoes.Tentativas.ToString();
            EscreveLetras();
            MontaImagem();
            if( funcoes.Acertou() )
            {
                MessageBox.Show("ACERTOU !!!");
                btnConfirma.Visible = false;
            }
        }

        private void MontaImagem()
        {
            string nomeImagem = "D:\\Nizzola\\jogoForca\\Forca\\Forca\\Images\\forca " + (funcoes.Erros+1).ToString() + ".png";
                //"~\\Images\\imagem" + funcoes.Erros.ToString() + ".jpg";
            
            pictureBox1.Image = Image.FromFile(nomeImagem);
        }

        public void EscreveLetras()
        {
            for (int i = 0; i <= funcoes.Decifrada.Length - 1; i++)
            {
                switch( i )
                {
                    case 0:
                        txtLetra0.Text = funcoes.Decifrada[i].ToString();
                        txtLetra0.Visible = true;
                        break;
                    case 1:
                        txtLetra1.Text = funcoes.Decifrada[i].ToString();
                        txtLetra1.Visible = true;
                        break;
                    case 2:
                        txtLetra2.Text = funcoes.Decifrada[i].ToString();
                        txtLetra2.Visible = true;
                        break;
                    case 3:
                        txtLetra3.Text = funcoes.Decifrada[i].ToString();
                        txtLetra3.Visible = true;
                        break;
                    case 4:
                        txtLetra4.Text = funcoes.Decifrada[i].ToString();
                        txtLetra4.Visible = true;
                        break;
                    case 5:
                        txtLetra5.Text = funcoes.Decifrada[i].ToString();
                        txtLetra5.Visible = true;
                        break;
                    case 6:
                        txtLetra6.Text = funcoes.Decifrada[i].ToString();
                        txtLetra6.Visible = true;
                        break;
                    case 7:
                        txtLetra7.Text = funcoes.Decifrada[i].ToString();
                        txtLetra7.Visible = true;
                        break;
                    case 8:
                        txtLetra8.Text = funcoes.Decifrada[i].ToString();
                        txtLetra8.Visible = true;
                        break;
                    case 9:
                        txtLetra9.Text = funcoes.Decifrada[i].ToString();
                        txtLetra9.Visible = true;
                        break;
                   
                }
                
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string sorteio = funcoes.SortearPalavra();
            MontaPlacar();

            //MessageBox.Show("Palavra:" + sorteio);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EscondeLetras();
            string sorteio = funcoes.SortearPalavra();
            MontaPlacar();
        }

        private void EscondeLetras()
        {
            txtLetra0.Visible = false;
            txtLetra1.Visible = false;
            txtLetra2.Visible = false;
            txtLetra3.Visible = false;
            txtLetra4.Visible = false;
            txtLetra5.Visible = false;
            txtLetra6.Visible = false;
            txtLetra7.Visible = false;
            txtLetra8.Visible = false;
            txtLetra9.Visible = false;
            btnConfirma.Visible = true;
        }

    }
}
