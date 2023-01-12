using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90){
            letter = "A";
        }
        else  if (percent >= 80){
            letter = "B";
        }
        else  if (percent >= 70){
            letter = "C";
        }
        else  if (percent >= 60){
            letter = "D";
        }
        else{
            letter = "F";
        }
        Console.WriteLine($"Your grade is:{letter}");

        if (percent >= 70){
           Console.WriteLine("You passed!");
        
        }
        else{
            Console.WriteLine("You failed.Better luck next time! :[ zthere is no next time");
        }
    }
}


//strech challenge 
/**using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your garde percentage?: ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 93)
        {
            Console.WriteLine("A");
        }
        else if (percent >= 90)
        {
            Console.WriteLine("A-");
        }
        else if (percent >= 87)
        {
            Console.WriteLine("B+");
        }
        else if (percent >= 83)
        {
            Console.WriteLine("B");
        }
        else if (percent>= 80)
        {
            Console.WriteLine("B-");
        }
        else if (percent >= 77)
        {
            Console.WriteLine("C+");
        }
        else if (percent >= 73)
        {
            Console.WriteLine("C");
        }
        else if (percent >= 70)
        {
            Console.WriteLine("C-");
        }
        else if (percent >= 67)
        {
            Console.WriteLine("D+");
        }
        else if (percent >= 63)
        {
            Console.WriteLine("D");
        }
        else if (percent >= 60)
        {
            Console.WriteLine("D-");
        }
        else
        {
            Console.WriteLine("F");
        }
        Console.WriteLine($"Your grade is:{letter}");

        if (percent >= 70){
           Console.WriteLine("You passed!");
        
        }
        else{
            Console.WriteLine("You failed.Better luck next time! :[ there is no next time");
        }
    }
}
***/