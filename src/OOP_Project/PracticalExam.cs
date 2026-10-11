using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int timeInMinutes, int numberOfQuestions, Question[] questions)
            : base(timeInMinutes, numberOfQuestions, questions) { }

        public override void ShowExam()
        {
            foreach (var q in Questions)
            {
                q.Display();
                Console.WriteLine($"Correct Answer: {q.CorrectAnswerId}"); 
            }
        }

    }
}
