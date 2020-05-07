using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoQuiz.Entities
{
    class Pergunta
    {
        public int Number { get; set; }
        public string Question { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string RightOption { get; set; }

        public Pergunta(int number, string question, string optionA, string optionB, string optionC, string optionD, string rightOption)
        {
            Number = number;
            Question = question;
            OptionA = optionA;
            OptionB = optionB;
            OptionC = optionC;
            OptionD = optionD;
            RightOption = rightOption;
        }


        public bool ConfirmAnswer(string answer)
        {
            if(answer == RightOption)
            {
                return true;
            }

            return false;
        }
    }
}
