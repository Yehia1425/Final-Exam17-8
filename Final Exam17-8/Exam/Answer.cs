using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam17_8.Exam
{
    internal class Answer:ICloneable , IComparable<Answer>
    {
        #region Properties
        public int AnswerId { get; set; }
        public string? AnswerText { get; set; }
        #endregion

        #region Constructor
        public Answer(int id, string text)
        {
            AnswerId = id;
            AnswerText = text;
        }
        #endregion

        #region Method
        public int CompareTo(Answer? other)
        {
            if (other == null) 
                return 1; 
            return AnswerId.CompareTo(other.AnswerId);
        }
        public object Clone()
        {
            return new Answer(AnswerId, AnswerText);
        }
        public override string ToString()
        {
            return $"{AnswerId} , {AnswerText}";
        }
        #endregion
    }
}
