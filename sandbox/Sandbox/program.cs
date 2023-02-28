class program{
    static void Main(string[] args)
    {
        var salary = new Employee();
        var hourly = new HourlyEmployee();

        Console.WriteLine() 

    }
    class Employee{
        int salary = 100000;
        virtual public int CalculateYearlyPay(){
            return salary;

        }
    class HourlyEmployee: Employee{
        int HourlyWage = 25;

        int HoursPerYear = 2000;
        public override int CalculateYearlyPay(){
            return HourlyWage * HoursPerYear;
        }
    class Executive: Employee{
        private int Bonus = 100000;
    }    
    abstract class Person{
        abstract public string Speak();

    }
    class BeautifulPerson: Person{
        public override string Speak(){
            return"Hello. You are very beautiful";
        }
    class RichPerson: Person{
        public override string Speak(){
            return"Hello. I can buy your whole life ";
        }
    }
    }
    }
}//method overiding 
//when a child class provides its own implemetation of a method 