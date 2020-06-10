using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class Checkbox : Question
    {
        public char[] CorrectAnswers { get; }

        public Checkbox(string questionText, List<string> possibleSelections, char[] correctAnswers) : base(questionText, possibleSelections)
        {
            CorrectAnswers = correctAnswers;
        }

        public string GradeAnswer(char[] choices)
        {
            Array.Sort(CorrectAnswers);
            Array.Sort(choices);
            string answerKey = "";
            string userInput = "";
            foreach (char x in CorrectAnswers)
            {
                answerKey += x;
            }

            foreach (char x in choices)
            {
                userInput += x;
            }

            if (answerKey == userInput)
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
