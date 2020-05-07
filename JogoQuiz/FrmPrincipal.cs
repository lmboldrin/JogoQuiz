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
    }
}
