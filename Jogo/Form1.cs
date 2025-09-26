using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random();
        int numeroSorteado = 0;
        private void btnGirar_Click(object sender, EventArgs e)
        {
            btnGirar.Enabled = false;
            lblMensagem.Text = "Girando...";
            timer1.Start();
        }


        int contador = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;

            // Animação de rotação: mostra números aleatórios rapidamente
            lblResultado.Text = rand.Next(1, 11).ToString();

            if (contador >= 15) // Depois de 15 "ticks", para
            {
                timer1.Stop();
                contador = 0;
                numeroSorteado = rand.Next(1, 11);
                lblResultado.Text = numeroSorteado.ToString();

                int numeroEscolhido = (int)numSorte.Value;

                if (numeroEscolhido == numeroSorteado)
                {
                    lblMensagem.Text = "🎉 Você ganhou!";
                }
                else
                {
                    lblMensagem.Text = "😢 Que pena, tente novamente.";
                }

                btnGirar.Enabled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
