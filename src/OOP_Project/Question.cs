namespace OOP_Project
{
    internal abstract class Question : ICloneable, IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] AnswerList { get; set; }
        public int CorrectAnswerId { get; set; }

        protected Question(string header, string body, int mark, Answer[] answerList, int correctAnswerId)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = answerList;
            CorrectAnswerId = correctAnswerId;
        }

        public abstract void Display();

        public override string ToString()
            => $"{Header}: {Body} (Mark: {Mark})";

        public int CompareTo(Question other)
            => this.Mark.CompareTo(other?.Mark ?? 0);

        public object Clone() => this.MemberwiseClone();
    }
}
