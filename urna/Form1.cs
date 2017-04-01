using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace urna
{
    public partial class Form1 : Form
    {

        string num; //armazena o número do candidato

        int candidato10, candidato20, candidato30, branco, nulo;
        int a = 0;
        public Form1()
        {
            InitializeComponent();
        }



        private void btnNumero(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtDireita.Text = txtDireita.Text + bt.Text;

        }
        private void txtDireita_TextChanged(object sender, EventArgs e)
        {
            num = txtDireita.Text;

            if (num == "10")
            {
                pictureBox1.Image = Properties.Resources.cad_Campos;
                lblNomeCandidato.Text = "Eduardo Campos";

            }

            else if (num == "50")
            {
                pictureBox1.Image = Properties.Resources.cad_eneias;
                lblNomeCandidato.Text = "Enéias";
            }

            else if (num == "11")
            {
                pictureBox1.Image = Properties.Resources.cad_pitta;
                lblNomeCandidato.Text = "Celso Pitta";
            }
            else if (num != "1" && num != "2" && num != "3" && num != "4" && num != "5" && num != "6" &&
                  num != "7" && num != "8" && num != "9" && num != "0" & num != "--")
            {
                pictureBox1.Image = Properties.Resources.fundoLARANJA_urna1;
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtDireita.Text = "";
            lblNomeCandidato.Text = "";
            a = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.fundobranco_urna;
            txtDireita.Text = "--";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var resultado = new Form2(candidato10, candidato20, candidato30, branco, nulo);
            resultado.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            {
                if (num == "10")
                {
                    candidato10 += 1;
                    txtDireita.Clear();
                    lblNomeCandidato.ResetText();
                    pictureBox1.Image = Properties.Resources.cad_Campos;
                }
                else if (num == "56")
                {
                    candidato20 += 1;
                    txtDireita.Clear();
                    lblNomeCandidato.ResetText();
                    pictureBox1.Image = Properties.Resources.cad_eneias;
                }
                else if (num == "11")
                {
                    candidato30 += 1;
                    txtDireita.Clear();
                    lblNomeCandidato.ResetText();
                    pictureBox1.Image = Properties.Resources.cad_pitta;
                }
                else if (num == "--")
                {
                    branco += 1;
                    txtDireita.Clear();
                    pictureBox1.Image = Properties.Resources.fundobranco_urna;
                }

                else
                {
                    nulo += 1;
                    txtDireita.Clear();
                    pictureBox1.Image = Properties.Resources.fundobranco_urna;
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

      


    }
}






