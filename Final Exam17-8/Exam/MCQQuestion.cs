using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam17_8.Exam
{
    internal class MCQQuestion:Question
    {
        public MCQQuestion(string header, string body, int mark) : base(header, body, mark)
        {



        }

        public override void DisplayQuestion()
        {
            Console.WriteLine($" Header:{Header} , Body:{Body} , Mark:{Mark}");

            foreach (var item in Answers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
