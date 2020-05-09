using System;
using System.Drawing;
using System.Windows.Forms;
using JogoQuiz.Entities;

namespace JogoQuiz
{
    public partial class FrmPergunta : Form
    {

        int segundo = 30;
        public FrmPergunta()
        {
            InitializeComponent();
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            if(Jogo.VerificarResposta(btnA.Text))
            {
                btnA.BackColor = Color.Green;
                MessageBox.Show("Parabéns você acertou!", "CERTA RESPOSTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btnA.BackColor = Color.Red;
                MessageBox.Show("Infelizmente você errou!", "RESPOSTA ERRADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            if (Jogo.VerificarResposta(btnB.Text))
            {
                btnB.BackColor = Color.Green;
                MessageBox.Show("Parabéns você acertou!", "CERTA RESPOSTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btnB.BackColor = Color.Red;
                MessageBox.Show("Infelizmente você errou!", "RESPOSTA ERRADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();

        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            if (Jogo.VerificarResposta(btnC.Text))
            {
                btnC.BackColor = Color.Green;
                MessageBox.Show("Parabéns você acertou!", "CERTA RESPOSTA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                btnC.BackColor = Color.Red;
                MessageBox.Show("Infelizmente você errou!", "RESPOSTA ERRADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();

        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            if (Jogo.VerificarResposta(btnD.Text))
            {
                btnD.BackColor = Color.Green;
                MessageBox.Show("Parabéns você acertou!", "CERTA RESPOSTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btnD.BackColor = Color.Red;
                MessageBox.Show("Infelizmente você errou!", "RESPOSTA ERRADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            segundo--;
            if (segundo >= 10)
            {
                lblTimer.Text = "00:" + segundo.ToString();
            }
            else
            {
                lblTimer.Text = "00:0" + segundo.ToString();

            }
            if (segundo == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Acabou o Tempo!", "TEMPO!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private void FrmPergunta_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblTimer.Text = "00:" + segundo.ToString();
        }
    }
}
