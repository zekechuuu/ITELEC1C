using Microsoft.AspNetCore.Mvc;
using SanAgustinITELEC1C.Models;
using SanAgustinITELEC1C.Services;

namespace SanAgustinITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        private readonly IFake _dummyData;

        public StudentController(IFake dummyData)
        {
            _dummyData = dummyData;
        }
        public IActionResult Index()
        {
            return View(_dummyData.StudentsList);
        }

        public IActionResult ShowDetail(int id)
        {
            Student? student = _dummyData.StudentsList.FirstOrDefault (st => st.Id ==id);
            if (student != null)
                return View(student);
            return NotFound();
        }

        [HttpGet]
        public IActionResult addStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult addStudent(Student addStudent)
        {
            _dummyData.StudentsList.Add(addStudent);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult updateStudent(int id)
        {
            Student? student = _dummyData.StudentsList.FirstOrDefault(st => st.Id == id);
            if (student != null)
                return View(student);
            return NotFound();
           
        }
        [HttpPost]
        public IActionResult updateStudent(Student studentChanges)
        {
            Student? student = _dummyData.StudentsList.FirstOrDefault(st => st.Id == studentChanges.Id);
            if(student != null)
            {
                student.FirstName = studentChanges.FirstName;
                student.LastName = studentChanges.LastName;
                student.Email = studentChanges.Email;
                student.Course = studentChanges.Course;
                student.GPA = studentChanges.GPA;
                student.AdmissionDate = studentChanges.AdmissionDate;
            }

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult deleteStudent(int id)
        {
            Student? student = _dummyData.StudentsList.FirstOrDefault(st => st.Id == id);
            if (student != null)
                return View(student);
            return NotFound();

        }
        [HttpPost]
        public IActionResult deleteStudent(Student deleteStudent)
        {
            Student? student = _dummyData.StudentsList.FirstOrDefault(st => st.Id == deleteStudent.Id);
            if (student !=  null)
                _dummyData.StudentsList.Remove(student);
            return RedirectToAction("Index");
        }
    }
}
