using System;
class Account : User {
    private string _name;
    private int _accountId;
    private string _accountType;
    private int _balance;
    private int _deposit;
    private int _withdraw;
    private int _transfer;

    public Account(int id, int accountId, string username, string useremail, string userpassword, string name, string accountType, int balance)
       : base(id , username, useremail, userpassword){
        _name = name;
        _accountId = accountId;
        _accountType = accountType;
        _balance = balance;
       }

       public int GetBalance(){
        return _balance;
       }

       public void DepositAmount(int amount){
        _balance += amount;
       }
       public void WithdrawAmount(int amount){
        _balance -= amount;
       }
       public void TransferAmount(Account dest, int amount){
        WithdrawAmount(amount);
        dest.DepositAmount(amount);
       }
    }












/*
public class Account{
public int accountId{ get; set }
public string accountName{ get; set }
public float accountBalance{ get; set }
   }
}
class accountName : accounts{
public string  _firstName = "Ezra";
public string  _lastName = "Senanu";
public string _typeofAccount = "Checking";
public (int id, string name, float balance) {}

}
*/

