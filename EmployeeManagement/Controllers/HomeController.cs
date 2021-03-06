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
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            else
            {
                try
                {
                    List<EmployeeModel> employeeList;
                    int result = db.DeleteEmployeeDetails(db.GetEmployee(id ?? default(int)));
                    if (result > 0)
                    {
                        employeeList = db.GetEmployeeList();
                        return PartialView("Index", employeeList);
                    }
                    else
                    {
                        ViewBag.err = "Something went wrong!";
                        return PartialView("Index", null);
                    }
                }
                catch
                {
                    throw new Exception("Something went wrong while deleteing the record!");
                }
            }

        }

        //public actionresult about()
        //{
        //    viewbag.message = "your application description page.";

        //    return view();
        //}

        //public actionresult contact()
        //{
        //    viewbag.message = "your contact page.";

        //    return view();
        //}
    }
}