using System;
using System.Collections.Generic;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> options = new List<string> { "Mitch", "Shea", "Victor", "Krombopulous Michael"};

            //TESTING MULTIPLE CHOICE
            //MultipleChoice TestQuestion = new MultipleChoice("What is my name?", options, 'a');
            //Console.WriteLine(TestQuestion.ToString());
            //char choice = Console.ReadKey().KeyChar;
            //Console.WriteLine("\n" + TestQuestion.GradeAnswer(choice) + "\n");

            //TESTING CHECKBOX
            //Checkbox TestQuestion = new Checkbox("Who are my friends? (Choose 2)", options, new char[] { 'b', 'c' });
            //Console.WriteLine(TestQuestion.ToString() + "\nFirst choice: ");
            //char choice1 = Console.ReadKey().KeyChar;
            //Console.WriteLine("\nSecond choice: ");
            //char choice2 = Console.ReadKey().KeyChar;
            //char[] choices = { choice1, choice2 };
            //Console.WriteLine("\n" + TestQuestion.GradeAnswer(choices) + "\n");

            //TESTING TRUEORFALSE


        }
    }
}
