using System;

class Program
{
    static void Main(string[] args)
    {
       Assignment a1 = new Assignment("Kofi Senanu", "Division");
       Console.WriteLine(a1.GetSummary());

       MathAssignment a2 = new MathAssignment("Kofi Senanu", "Division","2.3","3-7");
       Console.WriteLine(a2.GetSummary());
       Console.WriteLine(a2.GetHomeworkList());

       WritingAssignment a3 = new WritingAssignment("Kofi Senanu", "Division","How to Divide Fractions");
       Console.WriteLine(a3.GetSummary());
       Console.WriteLine(a3.GetWritingInformation());
    }
}