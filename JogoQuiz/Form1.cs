using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using JogoQuiz.Entities;

namespace JogoQuiz
{
    public partial class FrmInicio : Form
    {
        

        public FrmInicio()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Jogo jogo = new Jogo();
            jogo.CreateTeams(1);
            this.Hide();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Jogo jogo = new Jogo();
            jogo.CreateTeams(2);
            this.Hide();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Jogo jogo = new Jogo();
            jogo.CreateTeams(3);
            this.Hide();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Jogo jogo = new Jogo();
            jogo.CreateTeams(4);
            this.Hide();
        }
    }
}
