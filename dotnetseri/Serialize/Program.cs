using Auth;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.IO.File;
List<Authorisation> list = new List<Authorisation>();
list.Add(new Authorisation());
list.Add(new Authorisation("Aniket1","Pune1"));
try{
var option=new JsonSerializerOptions{IncludeFields=true};
string path =@".\File.json";
var objJson=JsonSerializer.Serialize<List<Authorisation>>(list,option);

WriteAllText(path,objJson);

var autho = ReadAllText(path);
var aut = JsonSerializer.Deserialize<List<Authorisation>>(autho);
foreach(Authorisation a in aut )
{
Console.WriteLine(a.Name+" "+a.Add);
}
}catch(Exception e)
{

}





