using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Abstract
{
    public abstract class UniversityStudent
    {
        protected string _studentFirstName { get; set; }
        public UniversityStudent(string studentFirstName)
        {
             _studentFirstName = studentFirstName;
        }

        public string studentNumber { get; set; }
        public string studentDepartment { get; set; }
        public string studentMail { get; set; }
        public string studentPhone { get; set; }
        public string studentLastName { get; set; }
       // public string takeTheClass { get; set; }

        //Öğrenci bilgisini yazdırıyor
        public void WriteStudentName()
        { 
            Console.WriteLine(_studentFirstName);
        }

        public virtual void WriteStudentInformation()
        {

            Console.WriteLine( " Adı: "+ _studentFirstName + " Soyadı: " + studentLastName + " Bölümü " + studentDepartment);
        }
    }
}
