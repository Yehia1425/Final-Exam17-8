using Final_Exam17_8.Exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam17_8
{
    internal abstract class Question
    {
        #region Propeties
        public string? Header { get; set; }
        public string? Body { get; set; }
        public int Mark { get; set; }

        public Answer[]? Answers { get; set; }

        public Answer? CorrectAnswer { get; set; }

        public int RightAnswerId { get; set; }

        #endregion


        #region Constructor
        public Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }
        #endregion

        #region Method

        public abstract void DisplayQuestion();
        #endregion



        
    }
}
