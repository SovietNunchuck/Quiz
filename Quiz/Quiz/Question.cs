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
        public char CorrectAnswer { get; set; }
        public char[] CorrectAnswers { get; set; }

        public Question(string questionText, List<string> possibleSelections)
        {
            QuestionText = questionText;
            PossibleSelections = possibleSelections;
        }

        public Question(string questionText)
            : this(questionText, new List<string> { "" }) {}

        public Question()
            : this("No question text entered.", new List<string> { "" }) {}


        public virtual string GradeAnswer(char[] choice)
        {
            if (Char.ToLower(choice[0]) == CorrectAnswer)
            {
                return "\nCorrect!";
            }
            else
            {
                return "\nSorry, that is incorrect.";
            }
        }

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
