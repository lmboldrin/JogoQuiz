using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoQuiz
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public void CreateTeams(int qtd)
        {
            if (qtd == 1)
            {
                lblTime1.Visible = true;
                txtPontuacao1.Visible = true;
            }
            else if (qtd == 2)
            {

                lblTime1.Visible = true;
                txtPontuacao1.Visible = true;
                lblTime2.Visible = true;
                txtPontuacao2.Visible = true;

            }
            else if (qtd == 3)
            {
                lblTime1.Visible = true;
                txtPontuacao1.Visible = true;
                lblTime2.Visible = true;
                txtPontuacao2.Visible = true;
                lblTime3.Visible = true;
                txtPontuacao3.Visible = true;
            }
            else
            {
                lblTime1.Visible = true;
                txtPontuacao1.Visible = true;
                lblTime2.Visible = true;
                txtPontuacao2.Visible = true;
                lblTime3.Visible = true;
                txtPontuacao3.Visible = true;
                lblTime4.Visible = true;
                txtPontuacao4.Visible = true;
            }
        }


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
