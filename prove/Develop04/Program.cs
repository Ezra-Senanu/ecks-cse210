using System;

class Program
{
    static void Main(string[] args)
{
    ListingActivity listingActivity = new ListingActivity
    {
        Name = "Listing Activity",
        Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
        Duration = 10,
        Prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        }
    };

    ReflectingActivity reflectionActivity = new ReflectingActivity
    {
        Name = "Reflection Activity",
        Description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
        Duration = 8,
        Prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        },
        Questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        }
    };

    BreathingActivity breathingActivity = new BreathingActivity
    {
        Name = "Breathing Activity",
        Description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
        Duration = 5
    };

    Console.WriteLine("Select a choice from the menu:");
        Console.WriteLine("1.Start breathing activity");
        Console.WriteLine("2.Start reflecting activity");
        Console.WriteLine("3.Start listening activity");
        Console.WriteLine("4.Quit");

    int choice = int.Parse(Console.ReadLine());

    if (choice == 1)
        breathingActivity.RunActivity();
    else if (choice == 2)
        reflectionActivity.RunActivity();
    else if (choice == 3)
        listingActivity.RunActivity();
    else
        Console.WriteLine("Invalid choice!");
}
}


