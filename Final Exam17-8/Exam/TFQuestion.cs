using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam17_8.Exam
{
    internal class TFQuestion:Question
    {
        public TFQuestion(string header, string body, int mark) : base(header, body, mark)
        {
            Answer[] answer = new Answer[]
            {
          new Answer(1, "True"),
          new Answer(2, "False")
            };
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
