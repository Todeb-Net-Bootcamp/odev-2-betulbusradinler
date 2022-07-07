using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Abstract;

namespace Models.Concrete
{
    public class IskenderunTecnichalUniversity : UniversityStudent
    {
        public IskenderunTecnichalUniversity(string studentFirstName) : base(studentFirstName)
        {
        }
        public override void WriteStudentInformation()
        {
            Console.WriteLine($"{_studentFirstName} {studentLastName} {studentDepartment}");
            base.WriteStudentInformation();
        }
    }
}
