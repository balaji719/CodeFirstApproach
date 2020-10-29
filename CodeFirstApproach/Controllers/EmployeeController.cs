using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstApproach.Controllers
{
    public class EmployeeController : Controller
    {
        Models.EmployeContext ec = new Models.EmployeContext();
        // GET: Employee
        public ActionResult Index()
        {
            TempData["ie"] = ec.Employees.ToList();
            TempData.Keep();
            return View();
        }
        [HttpPost]
        public ActionResult Add(Models.Employee e,string b1)
        {
            if (b1 == "Save") { 
            ec.Employees.Add(e);
            ec.SaveChanges();
            }
            else
            {
                Models.Employee emp =  ec.Employees.Find(e.Eno);
                emp.Ename = e.Ename;
                emp.Esalary = e.Esalary;
                emp.Designation = e.Designation;
                ec.SaveChanges();

            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Models.Employee emp = ec.Employees.Find(id);
            ec.Employees.Remove(emp);
            ec.SaveChanges();
            return RedirectToAction("Index","Employee");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            TempData.Keep();
            Models.Employee emp = ec.Employees.Find(id);
           
            return View("Index",emp);
        }

    }
}