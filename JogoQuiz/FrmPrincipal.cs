using System;
using System.Drawing;
using System.Windows.Forms;
using JogoQuiz.Entities;

namespace JogoQuiz
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            lblTurno.Text = "Time 1";

        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {

            if (btn1.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(1);
                btn1.BackColor = Color.Red;
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (btn2.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(2);
                btn2.BackColor = Color.Red;
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (btn3.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(3);
                btn3.BackColor = Color.Red;
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (btn4.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(4);
                btn4.BackColor = Color.Red;
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (btn5.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(5);
                btn5.BackColor = Color.Red;
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (btn6.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(3);
                btn6.BackColor = Color.Red;
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (btn7.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(7);
                btn7.BackColor = Color.Red;
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (btn8.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(8);
                btn8.BackColor = Color.Red;
            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (btn9.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(9);
                btn9.BackColor = Color.Red;
            }
        }

        private void Btn10_Click(object sender, EventArgs e)
        {
            if (btn10.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(10);
                btn10.BackColor = Color.Red;
            }
        }

        private void Btn11_Click(object sender, EventArgs e)
        {
            if (btn11.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(11);
                btn11.BackColor = Color.Red;
            }
        }

        private void Btn12_Click(object sender, EventArgs e)
        {
            if (btn12.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(12);
                btn12.BackColor = Color.Red;
            }
        }

        private void Btn13_Click(object sender, EventArgs e)
        {
            if (btn13.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(13);
                btn13.BackColor = Color.Red;
            }
        }

        private void Btn14_Click(object sender, EventArgs e)
        {
            if (btn14.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(14);
                btn14.BackColor = Color.Red;
            }
        }

        private void Btn15_Click(object sender, EventArgs e)
        {
            if (btn15.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(15);
                btn15.BackColor = Color.Red;
            }
        }

        private void Btn16_Click(object sender, EventArgs e)
        {
            if (btn16.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(16);
                btn16.BackColor = Color.Red;
            }
        }

        private void Btn17_Click(object sender, EventArgs e)
        {
            if (btn17.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(17);
                btn17.BackColor = Color.Red;
            }
        }

        private void Btn18_Click(object sender, EventArgs e)
        {
            if (btn18.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(18);
                btn18.BackColor = Color.Red;
            }
        }

        private void Btn19_Click(object sender, EventArgs e)
        {
            if (btn19.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(19);
                btn19.BackColor = Color.Red;
            }
        }

        private void Btn20_Click(object sender, EventArgs e)
        {
            if (btn20.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(20);
                btn20.BackColor = Color.Red;
            }
        }

        private void Btn21_Click(object sender, EventArgs e)
        {
            if (btn21.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(21);
                btn21.BackColor = Color.Red;
            }
        }

        private void Btn22_Click(object sender, EventArgs e)
        {
            if (btn22.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(22);
                btn22.BackColor = Color.Red;
            }
        }

        private void Btn23_Click(object sender, EventArgs e)
        {
            if (btn23.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(23);
                btn23.BackColor = Color.Red;
            }
        }

        private void Btn24_Click(object sender, EventArgs e)
        {
            if (btn24.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(24);
                btn24.BackColor = Color.Red;
            }
        }

        private void Btn25_Click(object sender, EventArgs e)
        {
            if (btn25.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(25);
                btn25.BackColor = Color.Red;
            }
        }

        private void Btn26_Click(object sender, EventArgs e)
        {
            if (btn26.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(26);
                btn26.BackColor = Color.Red;
            }
        }

        private void Btn27_Click(object sender, EventArgs e)
        {
            if (btn27.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(27);
                btn27.BackColor = Color.Red;
            }
        }

        private void Btn28_Click(object sender, EventArgs e)
        {
            if (btn28.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(28);
                btn28.BackColor = Color.Red;
            }
        }

        private void Btn29_Click(object sender, EventArgs e)
        {
            if (btn29.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(29);
                btn29.BackColor = Color.Red;
            }
        }

        private void Btn30_Click(object sender, EventArgs e)
        {
            if (btn30.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(30);
                btn30.BackColor = Color.Red;
            }
        }

        private void Btn31_Click(object sender, EventArgs e)
        {
            if (btn31.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(31);
                btn31.BackColor = Color.Red;
            }
        }

        private void Btn32_Click(object sender, EventArgs e)
        {
            if (btn32.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(32);
                btn32.BackColor = Color.Red;
            }
        }

        private void Btn33_Click(object sender, EventArgs e)
        {
            if (btn33.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(33);
                btn33.BackColor = Color.Red;
            }
        }

        private void Btn34_Click(object sender, EventArgs e)
        {
            if (btn34.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(34);
                btn34.BackColor = Color.Red;
            }
        }

        private void Btn35_Click(object sender, EventArgs e)
        {
            if (btn35.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(35);
                btn35.BackColor = Color.Red;
            }
        }

        private void Btn36_Click(object sender, EventArgs e)
        {
            if (btn36.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(36);
                btn36.BackColor = Color.Red;
            }
        }

        private void Btn37_Click(object sender, EventArgs e)
        {
            if (btn37.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(37);
                btn37.BackColor = Color.Red;
            }
        }

        private void Btn38_Click(object sender, EventArgs e)
        {
            if (btn38.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(38);
                btn38.BackColor = Color.Red;
            }
        }

        private void Btn39_Click(object sender, EventArgs e)
        {
            if (btn39.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(39);
                btn39.BackColor = Color.Red;
            }
        }

        private void Btn40_Click(object sender, EventArgs e)
        {
            if (btn40.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(40);
                btn40.BackColor = Color.Red;
            }
        }

        private void Btn41_Click(object sender, EventArgs e)
        {
            if (btn41.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(41);
                btn41.BackColor = Color.Red;
            }
        }

        private void Btn42_Click(object sender, EventArgs e)
        {
            if (btn42.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(42);
                btn42.BackColor = Color.Red;
            }
        }

        private void Btn43_Click(object sender, EventArgs e)
        {
            if (btn43.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(43);
                btn43.BackColor = Color.Red;
            }
        }

        private void Btn44_Click(object sender, EventArgs e)
        {
            if (btn44.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(44);
                btn44.BackColor = Color.Red;
            }
        }

        private void Btn45_Click(object sender, EventArgs e)
        {
            if (btn45.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(45);
                btn45.BackColor = Color.Red;
            }
        }

        private void Btn46_Click(object sender, EventArgs e)
        {
            if (btn46.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(46);
                btn46.BackColor = Color.Red;
            }
        }

        private void Btn47_Click(object sender, EventArgs e)
        {
            if (btn47.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(47);
                btn47.BackColor = Color.Red;
            }
        }

        private void Btn48_Click(object sender, EventArgs e)
        {
            if (btn48.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(48);
                btn48.BackColor = Color.Red;
            }
        }

        private void Btn49_Click(object sender, EventArgs e)
        {
            if (btn49.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(49);
                btn49.BackColor = Color.Red;
            }
        }

        private void Btn50_Click(object sender, EventArgs e)
        {
            if (btn50.BackColor == Color.Red)
            {
                MessageBox.Show("Essa pergunta já foi respondida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Jogo jogo = new Jogo();
                jogo.CreatePergunta(50);
                btn50.BackColor = Color.Red;
            }
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            txtPontuacao1.Text = "0";
            txtPontuacao2.Text = "0";
            txtPontuacao3.Text = "0";
            txtPontuacao4.Text = "0";
            btn1.BackColor = Color.White;
            btn2.BackColor = Color.White;
            btn3.BackColor = Color.White;
            btn4.BackColor = Color.White;
            btn5.BackColor = Color.White;
            btn6.BackColor = Color.White;
            btn7.BackColor = Color.White;
            btn8.BackColor = Color.White;
            btn9.BackColor = Color.White;
            btn10.BackColor = Color.White;
            btn11.BackColor = Color.White;
            btn12.BackColor = Color.White;
            btn13.BackColor = Color.White;
            btn14.BackColor = Color.White;
            btn15.BackColor = Color.White;
            btn16.BackColor = Color.White;
            btn17.BackColor = Color.White;
            btn18.BackColor = Color.White;
            btn19.BackColor = Color.White;
            btn20.BackColor = Color.White;
            btn21.BackColor = Color.White;
            btn22.BackColor = Color.White;
            btn23.BackColor = Color.White;
            btn24.BackColor = Color.White;
            btn25.BackColor = Color.White;
            btn26.BackColor = Color.White;
            btn27.BackColor = Color.White;
            btn28.BackColor = Color.White;
            btn29.BackColor = Color.White;
            btn30.BackColor = Color.White;
            btn31.BackColor = Color.White;
            btn32.BackColor = Color.White;
            btn33.BackColor = Color.White;
            btn34.BackColor = Color.White;
            btn35.BackColor = Color.White;
            btn36.BackColor = Color.White;
            btn37.BackColor = Color.White;
            btn38.BackColor = Color.White;
            btn39.BackColor = Color.White;
            btn40.BackColor = Color.White;
            btn41.BackColor = Color.White;
            btn42.BackColor = Color.White;
            btn43.BackColor = Color.White;
            btn44.BackColor = Color.White;
            btn45.BackColor = Color.White;
            btn46.BackColor = Color.White;
            btn47.BackColor = Color.White;
            btn48.BackColor = Color.White;
            btn49.BackColor = Color.White;
            btn50.BackColor = Color.White;
        }
    }
}
