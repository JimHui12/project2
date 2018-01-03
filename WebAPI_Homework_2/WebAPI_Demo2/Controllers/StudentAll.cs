using System;


namespace WebAPI_Demo2.Controllers
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ClassID { get; set; }
        public int MaximumNum { get; set; }
        public int Credit { get; set; }
        public Course()
        {
        }

        public override string ToString()
        {
            return string.Format("[Course]");
        }
    }

    public class Lecturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Payroll { get; set; }
        public string MessageFromStudent { get; set; }

        public Lecturer()
        {
        }

        public override string ToString()
        {
            return string.Format("[Lecturer]");
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StudentFee { get; set; }
        public int CreditLimited { get; set; }

        public Student()
        {
        }

        public override string ToString()
        {
            return string.Format("[Student]");
        }
    }


}
