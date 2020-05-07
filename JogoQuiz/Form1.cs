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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {

            FrmPrincipal form = new FrmPrincipal();
            form.Show();
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is FrmPrincipal
                         select frm;

            if (qrForm != null && qrForm.Count() > 0)
            {
                ((FrmPrincipal)qrForm.First()).CreateTeams(1);
                
            }
            this.Hide();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            FrmPrincipal form = new FrmPrincipal();
            form.Show();
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is FrmPrincipal
                         select frm;

            if (qrForm != null && qrForm.Count() > 0)
            {
                ((FrmPrincipal)qrForm.First()).CreateTeams(2);
            }
            
            this.Hide();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            FrmPrincipal form = new FrmPrincipal();
            form.Show();
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is FrmPrincipal
                         select frm;

            if (qrForm != null && qrForm.Count() > 0)
            {
                ((FrmPrincipal)qrForm.First()).CreateTeams(3);
            }
            
            this.Hide();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            FrmPrincipal form = new FrmPrincipal();
            form.Show();
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is FrmPrincipal
                         select frm;

            if (qrForm != null && qrForm.Count() > 0)
            {
                ((FrmPrincipal)qrForm.First()).CreateTeams(4);
            }
            this.Hide();
        }
    }
}
