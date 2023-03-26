using System;

class Transaction {
    private int _id;
    private string _type;
    private int _amount;
    private DateTime _timestamp;
    private int _accountId;
    
    public Transaction(int id, string type, int amount, DateTime timestamp, int accountId) {
        _id = id;
        _type = type;
        _amount = amount;
        _timestamp = timestamp;
        _accountId = accountId;
    }
    
    public int GetId() {
        return _id;
    }
    
    public string GetType() {
        return _type;
    }
    
    public int GetAmount() {
        return _amount;
    }
    
    public DateTime GetTimestamp() {
        return _timestamp;
    }
    
    public int GetAccountId() {
        return _accountId;
    }
}
