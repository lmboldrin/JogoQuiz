using System;
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
            Jogo jogo = new Jogo();
            jogo.CreatePergunta(1);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Jogo jogo = new Jogo();
            jogo.CreatePergunta(2);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Jogo jogo = new Jogo();
            jogo.CreatePergunta(3);
        }
    }
}
