using Microsoft.AspNetCore.Mvc;
using samplewebmvcapp.Models;
using System;
using System.Collections.Generic;

namespace samplewebmvcapp.Controllers
{
    public class EmployeeController: Controller{
     
        public IActionResult Index(){
          var Emps = new EmployeeDatabase();
          return View(Emps);
        }
    }
}