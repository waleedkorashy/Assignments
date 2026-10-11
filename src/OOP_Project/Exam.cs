using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    internal abstract class Exam : ICloneable, IComparable<Exam>
    {
        public int TimeInMinutes { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }

        protected Exam(int timeInMinutes, int numberOfQuestions, Question[] questions)
        {
            TimeInMinutes = timeInMinutes;
            NumberOfQuestions = numberOfQuestions;
            Questions = questions;
        }

        public abstract void ShowExam();

        public override string ToString()
            => $"Exam ({NumberOfQuestions} questions, {TimeInMinutes} minutes)";

        public int CompareTo(Exam other)
            => this.NumberOfQuestions.CompareTo(other?.NumberOfQuestions ?? 0);

        public object Clone() => this.MemberwiseClone();
    }
}
