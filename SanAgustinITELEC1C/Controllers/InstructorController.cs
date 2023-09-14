using Microsoft.AspNetCore.Mvc;
using SanAgustinITELEC1C.Models;
using static SanAgustinITELEC1C.Models.Instructor;

namespace SanAgustinITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>()
        {
            new Instructor()
                {
                   InstructorID = 20040624, InstructorFirstName = "RK", InstructorLastName = "Quisel", IsTenured = "Permanent", Rank = Rank.Instructor, HiringDate = DateTime.Parse("6/24/2004")
                },
                new Instructor()
                {
                    InstructorID = 20020427, InstructorFirstName = "Herald", InstructorLastName = "Oliveros", IsTenured = "Permanent", Rank = Rank.AssistantProfessor, HiringDate = DateTime.Parse("4/27/2002")
                },
                new Instructor()
                {
                    InstructorID = 19750625, InstructorFirstName = "John", InstructorLastName = "Paolo", IsTenured = "Temporary", Rank = Rank.AssociateProfessor, HiringDate = DateTime.Parse("6/25/1975")
                },
                new Instructor()
                {
                    InstructorID = 19751001, InstructorFirstName = "Mika", InstructorLastName = "Felix", IsTenured = "Temporary", Rank = Rank.Professor, HiringDate = DateTime.Parse("10/1/1975")
                }
        };
        public IActionResult Index()
        {
            return View(InstructorList);
        }
        public IActionResult ShowDetails(int ID)
        {

            Instructor? inst = InstructorList.FirstOrDefault(il => il.InstructorID == ID);

            if (inst != null)
                return View(inst);

            return NotFound();
        }

    }
}

    
