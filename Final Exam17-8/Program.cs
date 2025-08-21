using Final_Exam17_8.Exam;

namespace Final_Exam17_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Subject Id: ");
            int id = int.Parse(Console.ReadLine() ?? "0");
            Console.Clear();

            Console.Write("Enter Subject Name:");
            string name = (Console.ReadLine());
            
            Console.Clear();

            Subject subject = new Subject(id, name);

            subject.MoveExam();


            Console.WriteLine(subject);

            Console.WriteLine("===== Exam Started =====");

            subject.Exam.DisplayExam();


            Console.WriteLine("===== Exam End =====");


        }
    }
}

