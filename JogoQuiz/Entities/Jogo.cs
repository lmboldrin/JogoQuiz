using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace JogoQuiz.Entities
{
    class Jogo
    {
        FrmPrincipal form = new FrmPrincipal();
        public int PerguntaAtual { get; set; }
        public static string RespostaCertaAtual { get; set; }
        public List<Pergunta> pergunta = new List<Pergunta>();

        public Jogo()
        {
            string path = @"c:\Users\Lucas Boldrin\Documents\PROJETOS\C#\JogoQuiz\Base de Dados\PerguntasEvangelho.txt";
            StreamReader sr = File.OpenText(path);
            
            while (!sr.EndOfStream)
            {
                string[] campos = sr.ReadLine().Split(',');
                int numero = int.Parse(campos[0]);
                string questao = campos[1];
                string alternativaA = campos[2];
                string alternativaB = campos[3];
                string alternativaC = campos[4];
                string alternativaD = campos[5];
                string alternativaCorreta = campos[6];

                pergunta.Add(new Pergunta(numero, questao, alternativaA, alternativaB, alternativaC, alternativaD, alternativaCorreta));

            }

        }



        public void CreateTeams(int qtd)
        {
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


        public void CreatePergunta(int numero)
        {
            FrmPergunta frmPergunta = new FrmPergunta();
            frmPergunta.Show();
            PerguntaAtual = numero;
            frmPergunta.lblPergunta.Text = ObtainContent(pergunta.Where(p => p.Number == numero).Select(p => p.Question));
            frmPergunta.btnA.Text = ObtainContent(pergunta.Where(p => p.Number == numero).Select(p => p.OptionA));
            frmPergunta.btnB.Text = ObtainContent(pergunta.Where(p => p.Number == numero).Select(p => p.OptionB));
            frmPergunta.btnC.Text = ObtainContent(pergunta.Where(p => p.Number == numero).Select(p => p.OptionC));
            frmPergunta.btnD.Text = ObtainContent(pergunta.Where(p => p.Number == numero).Select(p => p.OptionD));
            RespostaCertaAtual = ObtainContent(pergunta.Where(p => p.Number == numero).Select(p => p.RightOption));
        }


        static string ObtainContent<T>(IEnumerable<T> collection)
        {
            string content;
            foreach(T obj in collection)
            {
                content = obj.ToString();
                return content;
            }
            return "0";
        }

        public static bool VerificarResposta(string answer)
        {
            if (Jogo.RespostaCertaAtual == answer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
