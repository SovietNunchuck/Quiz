using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class MultipleChoice : Question
    {

        public MultipleChoice(string questionText, List<string> possibleSelections, char correctAnswer) : base(questionText, possibleSelections)
        {
            CorrectAnswer = correctAnswer;
        }
    }
}
