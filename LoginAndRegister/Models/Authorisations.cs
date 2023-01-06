namespace details;
using System.ComponentModel.DataAnnotations;
[Serializable]
public class Authorisations{

public string UserName{get;set;}
public string Password{get;set;}


public Authorisations(){

    UserName="Admin";
        UserName="Admin123";
}
public Authorisations(string uName, string pass)
{
UserName=uName;
Password=pass;
}
}