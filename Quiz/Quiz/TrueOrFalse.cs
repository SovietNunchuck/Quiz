using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class TrueOrFalse : Question
    {
        public TrueOrFalse(string questionText, char correctAnswer) : base(questionText)
        {
            CorrectAnswer = correctAnswer;
        }


        public override string ToString()
        {
            string formattedQuestion = $"True (a) or false (b)? {QuestionText}\n";
            return formattedQuestion;
        }
    }
}
