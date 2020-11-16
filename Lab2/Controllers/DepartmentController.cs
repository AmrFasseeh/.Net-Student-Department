using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2.Models;

namespace Lab2.Controllers
{
    public class DepartmentController : Controller
    {
        static List<Department> departments = new List<Department>()
        {
            new Department() {Dept_id = 1, Dept_name = "IT"},
            new Department() {Dept_id = 2, Dept_name = "Sales"},
            new Department() {Dept_id = 3, Dept_name = "Marketing"},
            new Department() {Dept_id = 4, Dept_name = "Production"}
        };
        // GET: Department
        public ActionResult Index()
        {
            return View(departments);
        }

        public ActionResult CreateView()
        {
            return View();
        }

        public ActionResult Create(Department dept)
        {
            departments.Add(dept);
            return RedirectToAction("Index");
        }

        public ActionResult EditView(int id)
        {
            Department dept = departments.FirstOrDefault(d => d.Dept_id == id);
            return View(dept);
        }

        public ActionResult Edit(Department dept, int id)
        {
            Department Edited_dept = departments.FirstOrDefault(d => d.Dept_id == id);
            Edited_dept.Dept_name = dept.Dept_name;
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Department Deleted_dept = departments.FirstOrDefault(d => d.Dept_id == id);
            departments.Remove(Deleted_dept);
            return RedirectToAction("Index");
        }
    }
}