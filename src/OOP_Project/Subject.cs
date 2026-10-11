using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace OOP_Project
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam SubjectExam { get; set; }

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        
        public void CreateExam(Exam exam)
        {
            SubjectExam = exam;
        }

        public override string ToString() => $"{SubjectId} - {SubjectName}";
    }
}
