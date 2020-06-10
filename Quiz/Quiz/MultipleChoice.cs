using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class MultipleChoice : Question
    {
        public char CorrectAnswer { get; }

        public MultipleChoice(string questionText, List<string> possibleSelections, char correctAnswer) : base(questionText, possibleSelections)
        {
            CorrectAnswer = correctAnswer;
        }

        public string GradeAnswer(char choice)
        {
            if (Char.ToLower(choice) == CorrectAnswer)
            {
                return "\nCorrect!";
            }
            else
            {
                return "\nSorry, that is incorrect.";
            }
        }
    }
}
