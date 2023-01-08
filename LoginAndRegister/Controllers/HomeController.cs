namespace LoginAndRegister.Controllers;

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LoginAndRegister.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using details;
using  static System.IO.File;
using System.Collections.Generic;
public class HomeController : Controller
{

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }


        public IActionResult Validate(string uname, string pass)
    {
        string path=@"C:\data\Aniket CDAC data\IACSD DATA\Module files\Dot Net\own notes\program to ref\DotNet-Practice\LoginAndRegister\wwwroot\file\details.json";
        var str=ReadAllText(path);
        List<Authorisations> users = JsonSerializer.Deserialize<List<Authorisations>>(str);
       
       foreach(Authorisations auth in users)
       {
        if(uname==auth.UserName && pass==auth.Password)
        {
              return Redirect("/home/Welcome");
        }
       }
    //    System.Windows.Forms.MessageBox.Show("Invalid credentials");
        return Redirect("/Home/Login");
    }

        public IActionResult Login()
    {
        return View();
    }

   public IActionResult Register()
    {
        return View();
    }


       public IActionResult RegistrationPost(string uname,string pass,string pass1)
    {
        string path=@"C:\data\Aniket CDAC data\IACSD DATA\Module files\Dot Net\own notes\program to ref\DotNet-Practice\LoginAndRegister\wwwroot\file\details.json";
        var options=new JsonSerializerOptions{IncludeFields=true};
          List<Authorisations> list=new List<Authorisations>();
        var obj = ReadAllText(path);
        list = JsonSerializer.Deserialize<List<Authorisations>>(obj);
        Authorisations us = new Authorisations(uname,pass);
        list.Add(us);
        var obj1 = JsonSerializer.Serialize<List<Authorisations>>(list,options);
          WriteAllText(path,obj1);
        return Redirect("/Home/Index");
    }


        public IActionResult Welcome()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
