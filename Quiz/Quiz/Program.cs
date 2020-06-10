using System;
using System.Collections.Generic;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            //TESTING MULTIPLE CHOICE
            List<string> options = new List<string> { "Mitch", "Shea", "Victor", "Krombopulous Michael"};
            MultipleChoice TestQuestion = new MultipleChoice("What is my name?", options, 'a');
            Console.WriteLine(TestQuestion.ToString());
            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine("\n" + TestQuestion.GradeAnswer(choice) + "\n");

        }
    }
}
