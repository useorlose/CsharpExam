using MVCQuestion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCQuestion.Controllers
{
    public class EmpDataController : Controller
    {
        public ViewResult GetAllRecords()
        {
            var context = new gooddatabaseEntities();
            var model = context.EmpTables.ToList();
            return View(model);
        }

        public ViewResult Update(string id)
        {
            int empId = int.Parse(id);
            var context = new gooddatabaseEntities();
            var model = context.EmpTables.FirstOrDefault((e) => e.EmpId == empId);
            return View(model);

        }
       
        [HttpPost]
        public ActionResult Update(EmpTables emp)
        {
            var context = new gooddatabaseEntities();
            var model = context.EmpTables.FirstOrDefault((e) => e.EmpId == emp.EmpId);
            model.EmpName = emp.EmpName;
            model.EmpAddress = emp.EmpAddress;
            model.EmpSalary = emp.EmpSalary;
            context.SaveChanges();
            return RedirectToAction("GetAllRecords");
        }

        public ViewResult NewEmployee()
        {
            var model = new EmpTables();
            return View(model);
        }

        [HttpPost]
        public ActionResult NewEmployee(EmpTables emp)
        {
            try
            {
                var context = new gooddatabaseEntities();
                context.EmpTables.Add(emp);
                context.SaveChanges();
                return RedirectToAction("GetAllRecords");
            }
            catch
            {
                return RedirectToAction("GetAllRecords");
            }

            
        }

        public ActionResult Delete(string id)
        {
            int empId = int.Parse(id);
            var context = new gooddatabaseEntities();
            var model = context.EmpTables.FirstOrDefault((e) => e.EmpId == empId);
            context.EmpTables.Remove(model);
            context.SaveChanges();
            return RedirectToAction("GetAllRecords");
        }
    }
}