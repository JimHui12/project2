using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Demo2.Controllers
{
    public class DataStore
    {
        private static DataStore _instance;

        public static DataStore Instance()
        {
            if (_instance == null)
            {
               
                _instance = new DataStore();
            }
            return _instance;
        }

        private List<Course> _Courses;
        private static List<Course> CreateCourse ()
        {
            List<Course> courselist = new List<Course>();
            courselist.Add(new Course
            {
                Id = 1,
                Name = "Python",
                ClassID = 123,
                MaximumNum = 100,
                Credit = 2
            });
            courselist.Add(new Course
            {
                Id = 2,
                Name = "Java",
                ClassID = 132,
                MaximumNum = 200,
                Credit = 4
            });
            courselist.Add(new Course
            {
                Id = 3,
                Name = "C#",
                ClassID = 312,
                MaximumNum = 200,
                Credit = 6
            });
            return courselist;
        }

        private List<Student> _Students;
        private static List<Student> CreateStudent ()
        {
            List<Student> studentlist = new List<Student>();
            studentlist.Add(new Student
            {
                Id = 13,
                Name = "Tim",
                StudentFee = 4280,
                CreditLimited = 1
            });
            studentlist.Add(new Student
            {
                Id = 80,
                Name = "Tom",
                StudentFee = 4440,
                CreditLimited = 2
            });
            studentlist.Add(new Student
            {
                Id = 37,
                Name = "Tom",
                StudentFee = 4680,
                CreditLimited = 5
            });
            return studentlist;
        }

        private List<Lecturer> _Lecturers;
        private static List<Lecturer> CreateLecturer ()
        {
            List<Lecturer> lecturerlist = new List<Lecturer>();
            lecturerlist.Add(new Lecturer
            {
                Id = 1111,
                Name = "Lecturer 1",
                Payroll = 6000,
                MessageFromStudent = "Hello Professor 1"
            });
            lecturerlist.Add(new Lecturer
            {
                Id = 2222,
                Name = "Lecturer 2",
                Payroll = 9000,
                MessageFromStudent = "Hello Professor 2"
            });
            lecturerlist.Add(new Lecturer
            {
                Id = 3333,
                Name = "Lecturer 3",
                Payroll = 10000,
                MessageFromStudent = "Hello Professor 3"
            });
            return lecturerlist;
        }



        public DataStore()
        {

            _Courses = CreateCourse();
            _Students = CreateStudent();
            _Lecturers = CreateLecturer();
        }

        public List<Course> GetAllCourses()
        {
            return _Courses;
        }

        public List<Student> GetAllStudents()
        {
            return _Students;
        }

        public List<Lecturer> GetAllLecturers()
        {
            return _Lecturers;
        }


        public Course GetCourseByID(int Id)
        {
            Course result = _Courses.FirstOrDefault((Course arg) => arg.Id == Id);
            return result;
        }

        public Student GetStudenteByID(int Id)
        {
            Student result = _Students.FirstOrDefault((Student arg) => arg.Id == Id);
            return result;
        }

        public Lecturer GetLecturersByID(int Id)
        {
            Lecturer result = _Lecturers.FirstOrDefault((Lecturer arg) => arg.Id == Id);
            return result;
        }

        public void AddCourse(Course newCourse)
        {
            _Courses.Add(newCourse);
        }

        public void AddStudent(Student newStudent)
        {
            _Students.Add(newStudent);
        }

        public void AddLecturer (Lecturer newLecturer)
        {
            _Lecturers.Add(newLecturer);
        }


        public Course UpdateCourse(Course newCourse)
        {
            Course result = _Courses.FirstOrDefault((Course arg) => arg.Id == newCourse.Id);
            if (result != null)
            {
                result.Name = newCourse.Name;
                result.ClassID = newCourse.ClassID;
                result.Id = newCourse.Id; ;
                result.MaximumNum = newCourse.MaximumNum;
                result.Credit = newCourse.Credit;
            }
            return result;

        }

        public Student UpdateStudent(Student newStudent)
        {
            Student result = _Students.FirstOrDefault((Student arg) => arg.Id == newStudent.Id);
            if (result != null)
            {
                result.Name = newStudent.Name;
                result.Id= newStudent.Id;
                result.StudentFee = newStudent.StudentFee; 
                result.CreditLimited = newStudent.CreditLimited;
            }
            return result;

        }

        public Lecturer UpdateLecturer (Lecturer newLecturer)
        {
            Lecturer result = _Lecturers.FirstOrDefault((Lecturer arg) => arg.Id == newLecturer.Id);
            if (result != null)
            {
                result.Name = newLecturer.Name;
                result.Id = newLecturer.Id;
                result.Payroll = newLecturer.Payroll;
                result.MessageFromStudent = newLecturer.MessageFromStudent;
            }
            return result;

        }
        public bool DeleteCourse(int Id)
        {
            bool result = false;
            Course obj = _Courses.FirstOrDefault((Course arg) => arg.Id == Id);
            if (obj != null)
            {
                _Courses.Remove(obj);
                result = true;
            }
            return result;
        }

        public bool DeleteStudent(int Id)
        {
            bool result = false;
            Student obj = _Students.FirstOrDefault((Student arg) => arg.Id == Id);
            if (obj != null)
            {
                _Students.Remove(obj);
                result = true;
            }
            return result;
        }

        public bool DeleteLecturer(int Id)
        {
            bool result = false;
            Lecturer obj = _Lecturers.FirstOrDefault((Lecturer arg) => arg.Id == Id);
            if (obj != null)
            {
                _Lecturers.Remove(obj);
                result = true;
            }
            return result;
        }


    }
}
