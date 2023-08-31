using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD_StudentData
{
    public class Student
    {
        public int Roll_No { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public int Percentage { get; set; }
    }
    public class StudentCRUD
    {
        private List<Student> students;
        public StudentCRUD()
        {
            students = new List<Student>()
            {
                new Student{Roll_No = 01, Name = "Sandesh", Address = "Nagar", Percentage = 90},
                new Student{Roll_No = 02, Name = "Rohit", Address = "Solapur", Percentage = 80}
            };
        }
        public List<Student> GetStudent()          //case 1
        {
            return students;
        }
        public Student GetStudentByRollNo(int rollno)          //case 2
        {
            Student student = new Student();
            foreach (Student item in students)
            {
                if (item.Roll_No == rollno)
                {
                    student = item;
                    break;
                }
            }
            return student;
        }
        public void AddStudent(Student s)             //case 3
        {
            students.Add(s);
        }
        public void UpdateStudent(Student s)         //case 4
        {
            foreach (Student item in students)
            {
                if (item.Roll_No == s.Roll_No)
                {
                    item.Name = s.Name;
                    item.Address = s.Address;
                    item.Percentage = s.Percentage;
                    break;
                }
            }
        }
        public void DeleteStudent(int roll)    //case 5
        {
            foreach (Student item in students)
            {
                if (item.Roll_No == roll)
                {
                    students.Remove(item);
                    break;
                }
            }
        }
    }
}
