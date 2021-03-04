using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeManagementData;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        UserData db = new UserData();

        public ActionResult Index()
        {
            List<EmployeeModel> employeeList = db.GetEmployeeList();
            return View(employeeList);
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            EmployeeModel employee = db.GetEmployee(Id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel employee)
        {
            db.UpdateEmployeeDetails(employee);
            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}