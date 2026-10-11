using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, int mark, Answer[] answerList, int correctAnswerId)
            : base(header, body, mark, answerList, correctAnswerId) { }

        public override void Display()
        {
            Console.WriteLine(this);
            foreach (var a in AnswerList)
                Console.WriteLine($"{a.AnswerId}. {a.AnswerText}");
        }
    }
}
