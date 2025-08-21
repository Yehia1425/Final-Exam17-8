using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam17_8.Exam
{
    internal abstract class Exam01
    {
        #region Properies

        public int Time { get; set; }
        public int NumOfQuestions { get; set; }

        public Question[] questions { get; set; } 
        #endregion

        #region Constructor
        public Exam01(int time, int numofquestions)
        {
            Time = time;
            NumOfQuestions = numofquestions;
            questions = new Question[0];
        }
        #endregion

        #region Method
        public abstract void DisplayExam();
        #endregion


        
        public void ShowExam(int exam)
        {
          
            questions = new Question[NumOfQuestions];

            for (int i = 0; i < NumOfQuestions; i++)
            {
                Console.WriteLine($"\nEnter Question {i + 1} Details:");
                Console.Clear();
                Console.Write("Enter Question Header: ");
                string header = Console.ReadLine();
                Console.Clear();

                Console.Write("Enter Question Body: ");
                string body = Console.ReadLine();
                Console.Clear();

                Console.Write("Enter Question Mark: ");
                int mark = int.Parse(Console.ReadLine() ?? "1");
                Console.Clear();

                Question q;

                if (exam == 1)
                {
                    Console.Write("Enter Question Type (1: T/F, 2: MCQ): ");
                    int type = int.Parse(Console.ReadLine() ?? "1");
                    Console.Clear();

                    if (type == 1) 
                    {
                        q = new TFQuestion(header, body, mark);
                        q.Answers = new Answer[2];
                        q.Answers[0] = new Answer(1, "True");
                        q.Answers[1] = new Answer(2, "False");
                        Console.Clear();
                    }
                    else
                    {
                        q = new MCQQuestion(header, body, mark);
                        Console.Write("How many choices? ");
                        int ch = int.Parse(Console.ReadLine() ?? "0");
                        Console.Clear();
                        q.Answers = new Answer[ch];
                        for (int j = 0; j < ch; j++)
                        {
                            Console.Write($"Enter Choice {j + 1}: ");
                            q.Answers[j] = new Answer(j + 1, Console.ReadLine());
                            Console.Clear();
                        }
                    }
                }
                else
                {
                    q = new MCQQuestion(header, body, mark);
                    Console.Write("How many choices? ");
                    int ch = int.Parse(Console.ReadLine() ?? "0");
                    Console.Clear();
                    q.Answers = new Answer[ch];
                    for (int j = 0; j < ch; j++)
                    {
                        Console.Write($"Enter Choice {j + 1}: ");
                        q.Answers[j] = new Answer(j + 1, Console.ReadLine());
                        Console.Clear();
                    }
                }

                Console.Write("Enter Right Answer Id: ");
                q.RightAnswerId = int.Parse(Console.ReadLine() ?? "1");
                Console.Clear();


                questions[i] = q;
            }
        }



    }
}

      






