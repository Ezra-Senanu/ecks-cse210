using System;

interface IUser {
    bool Login();
    void Logout();
    void Transaction();
    void Display();
    void CreateAccount();
}

class User : IUser {
    private int _id;
    private string _username;
    private string _useremail;
    private string _userpassword;

    public User(int id, string username, string useremail, string userpassword){
        _id = id;
        _username = username;
        _useremail = useremail;
        _userpassword = userpassword;
    }
    public bool Login(){
        return true;
    }
    public void Logout(){}
    public void Transaction(){}
    public void Display(){}
    public void CreateAccount(){}


}
