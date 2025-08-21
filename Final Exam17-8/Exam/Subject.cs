using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam17_8.Exam
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam01 Exam { get; set; }

        public Subject(int id, string name)
        {
            SubjectId = id;
            SubjectName = name;
        }

        public void CreateExam(Exam01 exam)
        {
            Exam = exam;
        }


        public void MoveExam()
        {
            Console.Write("Enter Exam Type (1: Final, 2: Practical): ");
            int type = int.Parse(Console.ReadLine() ?? "1");
            Console.Clear();

            Console.Write("Enter Exam Time in Minutes: ");
            int time = int.Parse(Console.ReadLine() ?? "60");
            Console.Clear();

            Console.Write("Enter Number of Questions: ");
            int numQ = int.Parse(Console.ReadLine() ?? "0");
            Console.Clear();

            if (type == 1)
                Exam = new FinalExam(time, numQ);
            else
                Exam = new PracticalExam(time, numQ);

            Exam.ShowExam(type);
        }

        public override string ToString()
        {
            Console.Clear();
            return $"Subject Id : {SubjectId}, Subject Name : {SubjectName} ";
        }
    }
}
