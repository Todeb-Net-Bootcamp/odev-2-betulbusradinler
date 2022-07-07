using Models.Concrete;
using System;

namespace ObjectOrientedProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var iste = new IskenderunTecnichalUniversity("Büşra Betül");
            iste.studentLastName = "DİNLER";
            iste.studentDepartment = "Computer Engineer";
            iste.WriteStudentName();


            var iste2 = new IskenderunTecnichalUniversity("Eren");
            iste2.studentLastName = "DİNLER";
            iste2.studentDepartment = "Electric Engineer";
            iste.WriteStudentName();
        }
    }
}
