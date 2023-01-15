namespace Auth;
using System.ComponentModel.DataAnnotations;
[Serializable]

public class Authorisation{

public string Name{get;set;}
public string Add{get;set;}


public Authorisation(){
this.Name="Aniket";
this.Add="Pune";
}
public Authorisation(string nm,string ad){
this.Name=nm;
this.Add=ad;
}
}