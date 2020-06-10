using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Quiz
{
    public abstract class Question
    {
        public string QuestionText { get; set; }
        public List<string> PossibleSelections { get; set; } = new List<string>();

        public Question(string questionText, List<string> possibleSelections)
        {
            QuestionText = questionText;
            PossibleSelections = possibleSelections;
        }

        public Question()
            : this("No question text entered.", new List<string> { "Blank" }) {}


        public override string ToString()
        {
            string formattedAnswers = "";
            char[] choices = { 'A', 'B', 'C', 'D', 'E', 'F' };
            int x = 0;
            foreach (string selection in PossibleSelections)
            {
                formattedAnswers += choices[x] + ". " + selection + "\n";
                x++;
            }
            string formattedQuestion = $"{QuestionText}\n\n{formattedAnswers}";
            
            return formattedQuestion;
        }

    }
}
