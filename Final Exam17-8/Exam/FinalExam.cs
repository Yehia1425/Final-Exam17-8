using Final_Exam17_8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam17_8.Exam
{
    internal class FinalExam: Exam01
    {
        public FinalExam(int time, int numofquestions) : base(time, numofquestions)
        {
        }

        public int TotalMarks()
        {
            int sum = 0;
            foreach (var q in questions) sum += q.Mark;
            return sum;
        }

        public override void DisplayExam()
        {
            Console.WriteLine("===== Final Exam =====");

            int score = 0;
            foreach (var q in questions)
            {
                q.DisplayQuestion();
                Console.Write("Enter your Answer Id: ");
                int userAns = int.Parse(Console.ReadLine() ?? "0");
                if (userAns == q.RightAnswerId)
                    score += q.Mark;

                Console.WriteLine($"Correct Answer is: {q.RightAnswerId}");
               
            }
            Console.WriteLine($"Your Score: {score}/{TotalMarks()}");
        }
    }

    }



