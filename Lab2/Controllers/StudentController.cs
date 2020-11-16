using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2.Models;

namespace Lab2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        static List<Student> students = new List<Student>()
        {
            new Student() {id = 1, name = "Amr", age = 25},
            new Student() {id = 2, name = "Ahmed", age = 35},
            new Student() {id = 3, name = "Sherif", age = 40},
            new Student() {id = 4, name = "Mohamed", age = 20}
        };
        // GET: Department
        public ActionResult Index()
        {
            return View(students);
        }

        public ActionResult CreateView()
        {
            return View();
        }

        public ActionResult Create(Student stud)
        {
            students.Add(stud);
            return RedirectToAction("Index");
        }

        public ActionResult EditView(int id)
        {
            Student stud = students.FirstOrDefault(d => d.id == id);
            return View(stud);
        }

        public ActionResult Edit(Student stud, int id)
        {
            Student Edited_stud = students.FirstOrDefault(d => d.id == id);
            Edited_stud.name = stud.name;
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Student Deleted_stud = students.FirstOrDefault(d => d.id == id);
            students.Remove(Deleted_stud);
            return RedirectToAction("Index");
        }
    }
}