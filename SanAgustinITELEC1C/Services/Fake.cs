using SanAgustinITELEC1C.Models;
namespace SanAgustinITELEC1C.Services
{
    public class Fake : IFake
    {
        public List<Student> StudentsList { get; }

        public Fake()
        {
             StudentsList = new List<Student>
           {
             new Student()
            {
                Id = 1, FirstName= "Ezrah Zechairah", LastName = "San Agustin", Course = Course.BSIT, AdmissionDate = DateTime.Parse("2022-08-26"),
                GPA = 3, Email = "ezrahzechairah.sanagustin.cics@ust.edu.ph"
            },
             new Student()
            {
                Id = 2, FirstName= "Herald", LastName = "Oliveros", Course = Course.BSIS, AdmissionDate = DateTime.Parse("2023-09-21"),
                GPA = 1.5, Email = "herald.oliveros.cics@ust.edu.ph"
            },
             new Student()
            {
                Id = 3, FirstName= "Jampol", LastName = "Tan", Course = Course.BSCS, AdmissionDate = DateTime.Parse("2021-04-25"),
                GPA = 1, Email = "jampol.tan.cics@ust.edu.ph"
            }
          };

        }
    }

}
