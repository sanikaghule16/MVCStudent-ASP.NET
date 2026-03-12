using MVCStudent.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStudent.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var students = new List<Student>
            {
                new Student{ Id=1, FirstName="Ram",LastName="khanna",Email="ramkhanna@gmail.com"},
                 new Student{ Id=2, FirstName="Geeta",LastName="khanna",Email="geeta@gmail.com"},
                  new Student{ Id=3, FirstName="Ram",LastName="khanna",Email="ramkhanna@gmail.com"},
                   new Student{ Id=4, FirstName="Ram",LastName="khanna",Email="ramkhanna@gmail.com"},
                    new Student{ Id=5, FirstName="Ram",LastName="khanna",Email="ramkhanna@gmail.com"}
            };
            return View(students);
        }
    }
}
