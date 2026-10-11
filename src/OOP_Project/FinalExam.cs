using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    internal class FinalExam : Exam
    {
        public FinalExam(int timeInMinutes, int numberOfQuestions, Question[] questions)
            : base(timeInMinutes, numberOfQuestions, questions) { }

        public override void ShowExam()
        {
            int totalGrade = 0;
            foreach (var q in Questions)
            {
                q.Display();
                totalGrade += q.Mark;
            }
            Console.WriteLine($"Total Grade: {totalGrade}");
        }
    }
}
