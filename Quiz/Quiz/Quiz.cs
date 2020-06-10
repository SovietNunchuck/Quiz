using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class Quiz
    {
        private static List<string> options = new List<string> { "Mitch", "Shea", "Victor", "Krombopulous Michael" };

        //TESTING MULTIPLE CHOICE
        public static void Question1()
        {
            MultipleChoice McTestQuestion = new MultipleChoice("What is my name?", options, 'a');

            Console.WriteLine(McTestQuestion.ToString());
            char[] MCchoice = { Console.ReadKey().KeyChar };

            Console.WriteLine("\n" + McTestQuestion.GradeAnswer(MCchoice) + "\n");
        }

        //TESTING CHECKBOX
        public static void Question2()
        {
            Checkbox CheckboxTestQuestion = new Checkbox("Who are my friends? (Choose 2)", options, new char[] { 'b', 'c' });

            Console.WriteLine(CheckboxTestQuestion.ToString() + "\nFirst choice: ");
            char choice1 = Console.ReadKey().KeyChar;

            Console.WriteLine("\nSecond choice: ");
            char choice2 = Console.ReadKey().KeyChar;

            char[] choices = { choice1, choice2 };
            Console.WriteLine("\n" + CheckboxTestQuestion.GradeAnswer(choices) + "\n");
        }

        //TESTING TRUE OR FALSE
        public static void Question3()
        {
            TrueOrFalse TFTestQuestion = new TrueOrFalse("In reality, I have no friends.", 'a');

            Console.WriteLine(TFTestQuestion.ToString() + "\n");
            char[] TFchoice = { Console.ReadKey().KeyChar };

            Console.WriteLine("\n" + TFTestQuestion.GradeAnswer(TFchoice) + "\n");
        }
    }
}
