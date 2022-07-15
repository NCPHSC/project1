using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using project1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace project1.Controllers
{
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult String()
        {
            return Content("Gamer");
        }
        public IActionResult File()
        {
            return File("hari.txt", "text/plain");
        }
        public IActionResult Filedownload()
        {
            return File("hari.txt", "text/plain","hari.txt");
        }
        public IActionResult Json()
        {
            return Json(new { Name="Hari",Roll="606" });
        }
        [HttpGet]
        public IActionResult Redirect()
        {
          
            return Redirect("File");
        }
        public IActionResult Student()
        {
            StudentModel student = new StudentModel();
            {
                student.Name = "hari";
                student.Age = 21;
                student.Phone = "43039";
                student.Address = "kavre";
                student.Reg_no = 48952054;
               return View(student);

            }
        }
        public ActionResult Studentlist()
        {
            List<StudentModel> student = BusinessService.students;
            
            return View(student);

        }
        public ActionResult Studentform()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Studentform(StudentModel student)
        {
            List<StudentModel> students = BusinessService.students;
            students.Add(student);
            return RedirectToAction("Studentlist");
        }
        public IActionResult Edit(int Reg_no)
        {
            List<StudentModel> students = BusinessService.students;
            StudentModel student = students.Where(x=>x.Reg_no == Reg_no).FirstOrDefault();
            return View(student);
        }
        [HttpPost]
        public IActionResult Edit(StudentModel student)
        {
            List<StudentModel> students = BusinessService.students;
            StudentModel p=students.Where (x=>x.Reg_no==student.Reg_no).FirstOrDefault();
            p.Reg_no = student.Reg_no;
            p.Name = student.Name;
            return RedirectToAction("Studentlist");
        }
    }
}
