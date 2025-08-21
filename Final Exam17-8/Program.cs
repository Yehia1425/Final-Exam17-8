using Final_Exam17_8.Exam;

namespace Final_Exam17_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Id: ");
            int id = int.Parse(Console.ReadLine() ?? "0");
            Console.Clear();

            Console.Write("Enter Name:");
            string name = (Console.ReadLine() ?? "Guest");
            
            Console.Clear();

            Subject subject = new Subject(id, name??"Guest");

            subject.MoveExam();


            Console.WriteLine(subject);

            Console.WriteLine("===== Exam Started =====");

            subject.Exam.DisplayExam();


            Console.WriteLine("===== Exam End =====");


        }
    }
}

