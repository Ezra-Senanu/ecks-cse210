using System;

public class Resume{
    public string _firstName;
    public string _middleName;
    public string _lastName;

    public List<Job> _jobs = new List<Job>();

    public void Display(){
        Console.WriteLine($"Full Name: {_lastName}, {_firstName} {_middleName}");
        Console.WriteLine($"Jobs: ");

        foreach (Job job in _jobs){
            job.Display();
        }
    }
}