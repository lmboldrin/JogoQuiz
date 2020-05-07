using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JogoQuiz.Entities
{
    class Jogo
    {
        public void CreateTeams(int qtd)
        {
            FrmPrincipal form = new FrmPrincipal();
            form.Show();
            if (qtd == 1)
            {
                form.lblTime1.Visible = true;
                form.txtPontuacao1.Visible = true;
            }
            else if (qtd == 2)
            {

                form.lblTime1.Visible = true;
                form.txtPontuacao1.Visible = true;
                form.lblTime2.Visible = true;
                form.txtPontuacao2.Visible = true;

            }
            else if (qtd == 3)
            {
                form.lblTime1.Visible = true;
                form.txtPontuacao1.Visible = true;
                form.lblTime2.Visible = true;
                form.txtPontuacao2.Visible = true;
                form.lblTime3.Visible = true;
                form.txtPontuacao3.Visible = true;
            }
            else
            {
                form.lblTime1.Visible = true;
                form.txtPontuacao1.Visible = true;
                form.lblTime2.Visible = true;
                form.txtPontuacao2.Visible = true;
                form.lblTime3.Visible = true;
                form.txtPontuacao3.Visible = true;
                form.lblTime4.Visible = true;
                form.txtPontuacao4.Visible = true;
            }
        }
    }
}
