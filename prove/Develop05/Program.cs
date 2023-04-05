using System;

class Program {
    static void Main(string[] args) {
        User user = new User("Kofi");
        user.AddGoal("Run a 10k", GoalType.Simple, 1000);
        user.AddGoal("Read the scriptures", GoalType.Eternal, 100);
        user.AddGoal("Attend the temple", GoalType.Checklist, 50, 0, 10, 500);

        while (true) {
            Console.WriteLine($"Welcome, {user.username}! Your current score is {user.score}.");
            user.PrintGoals();
            Console.WriteLine("What goal have you accomplished? (or enter 'quit' to exit)");
            string input = Console.ReadLine();
            if (input == "quit") {
                break;
            } else {
                user.RecordEvent(input);
            }
        }
    }