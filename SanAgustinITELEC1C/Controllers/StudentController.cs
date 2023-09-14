using Microsoft.AspNetCore.Mvc;
using SanAgustinITELEC1C.Models;
namespace SanAgustinITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Student st = new Student();
            st.StudentId = 1;
            st.StudentName = "Ezrah San Agustin";
            st.DateEnrolled = DateTime.Parse("8/30/2023");
            st.Course = Course.BSIT;
            st.Email = "ezrahzechairah.sanagustin.cics@ust.edu.ph";

            ViewBag.Student = st;
            return View();

        }
    }
}
