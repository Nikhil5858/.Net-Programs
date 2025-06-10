using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Student
    {
        int Enrollment_No, Semester, CPI, SPI;
        String Student_Name;

        public Student(int en,int sem,int cpi,int spi,String sdname) {
            Enrollment_No = en;
            Semester = sem;
            CPI = cpi;
            SPI = spi;
            Student_Name = sdname;
        }
        public void DisplayStudentDetails() { 
            Console.WriteLine($"Enrollment_No : {Enrollment_No}, Student_Name : {Student_Name}, Semester : {Semester}, CPI : {CPI}, SPI : {SPI}");
        }
    }
}
