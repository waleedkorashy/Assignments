using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, int mark, Answer[] answerList, int correctAnswerId)
        : base(header, body, mark, answerList, correctAnswerId) { }

        public override void Display()
        {
            Console.WriteLine(this);
            Console.WriteLine("1. True   2. False");
        }
    }
}
