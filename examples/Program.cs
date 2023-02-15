using System;
class Program {
    static void Main(string[] args) {
        
        var divider =  new IntegerDivision();
        divider.lhs = 10;
        divider.rhs = 1;
        divider.DisplayResult();

        divider.lhs = 0;
        divider.rhs = 100;
        divider.DisplayResult();

        divider.lhs = 5;
        divider.rhs = 0;
        divider.DisplayResult();

        divider.lhs = 25;
        divider.rhs = 5;
        divider.DisplayResult();
    }
}

class IntegerDivision {
    private int _lhs = 1;
    private int _rhs = 1;

    public int GetLHS(){
        return _lhs;
    }
    public void SetLHS(int newLHS){
        _lhs = newLHS;
    }
    public int GetRHS(){
        return _rhs;
    }
    public void SetRHS(int newRHS){
        _rhs = newRHS;

        if (newRHS == 0){
        Console.WriteLine("You cannot divide by zero");
        
        }
    }

    public int Result() {
        return _lhs / _rhs;
    }

    public void DisplayResult() {
        var result = Result();
        Console.WriteLine($"{lhs} divided by {rhs} is {result}");
    }
}
