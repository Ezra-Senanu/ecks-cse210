using System;

class Report{
    public void Display(){}
}

class AccountReport : Report {
    private string _accountType;
    private int _time;
    private int _userId;

    public AccountReport(string accountType, int time, int userId){
        _accountType = accountType;
        _time = time;
        _userId = userId;
    }

class TransactionReport : Report {
    private int time;
    private int userId;
    
    public TransactionReport(int time, int userId) {
        this.time = time;
        this.userId = userId;
    }
    
}
}