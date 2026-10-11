namespace OOP_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Answer[] answers =
            {
                new Answer(1, "Paris"),
                new Answer(2, "London"),
                new Answer(3, "Berlin")
            };

            Question[] questions =
            {
                new MCQQuestion("Q1", "Capital of France?", 5, answers, 1),
                new TrueFalseQuestion("Q2", "C# is object-oriented.", 5,
                new Answer[] { new Answer(1, "True"), new Answer(2, "False") }, 1)
            };

            Subject subject = new Subject(101, "Programming 101");
            Exam finalExam = new FinalExam(60, questions.Length, questions);
            subject.CreateExam(finalExam);

            subject.SubjectExam.ShowExam();
        }
    }
}
