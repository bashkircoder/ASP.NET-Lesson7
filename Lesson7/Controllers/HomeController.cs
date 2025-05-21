using System.Diagnostics;
using Lesson7.Context;
using Microsoft.AspNetCore.Mvc;
using Lesson7.Models;

namespace Lesson7.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult About()
    {
        var company = new Company();
        company.Employees = DataContext.GetEmployees();
        return View(company);
    }
    
}