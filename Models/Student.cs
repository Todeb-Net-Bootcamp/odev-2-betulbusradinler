using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    // Student sınıfını, veri tabanında tablo oluşturmak için gerekli modeli hazırladık
    // Student sınıfında, gerçek hayatla benzer propertyler tanımladım. 
    public class Student
    {
        public int Id { get; set; }

        public string studentNo { get; set; }

        public string student_firstName { get; set; }

        public string student_lastName { get; set; }

        public string studentPhone { get; set; }

        public string studentMail { get; set; }

        

    }
}
