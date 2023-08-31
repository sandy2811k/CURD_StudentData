using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD_StudentData
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int no = 0;
            StudentCRUD studentCRUD = new StudentCRUD();
            {
                do
                {
                    Console.WriteLine("___________________________");
                    Console.WriteLine("1 Student List: ");
                    Console.WriteLine("2 Get Student By Id ");
                    Console.WriteLine("3 Add Student: ");
                    Console.WriteLine("4 Update student: ");
                    Console.WriteLine("5 Delete student: ");


                    Console.WriteLine("Enter your choice: ");
                    int ch = Convert.ToInt32(Console.ReadLine());

                    switch (ch)
                    {
                        case 1:
                            List<Student> result = studentCRUD.GetStudent();
                            Console.WriteLine("Roll_No\t Name\t Address\t Percentage\t");
                            foreach (Student item in result)
                            {
                                Console.WriteLine($"{item.Roll_No},  {item.Name},  {item.Address},  {item.Percentage}");
                            }
                            break;

                        case 2:
                            Console.WriteLine("Enter Roll Number: ");
                            int rollno = Convert.ToInt32(Console.ReadLine());
                            Student s = studentCRUD.GetStudentByRollNo(rollno);
                            Console.WriteLine("Roll_No\t Name\t Address\t Percentage\t");
                            Console.WriteLine($"{s.Roll_No},  {s.Name}, {s.Address}, {s.Percentage}");
                            break;

                        case 3:
                            Student s1 = new Student();
                            Console.WriteLine("enter Roll no: ");
                            s1.Roll_No = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter name: ");
                            s1.Name = Console.ReadLine();
                            Console.WriteLine("Enter Address: ");
                            s1.Address = Console.ReadLine();
                            Console.WriteLine("Enter percentage: ");
                            s1.Percentage = Convert.ToInt32(Console.ReadLine());
                            studentCRUD.AddStudent(s1);
                            break;

                        case 4:
                            Student s2 = new Student();
                            Console.WriteLine("Roll no");
                            s2.Roll_No = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Name: ");
                            s2.Name = Console.ReadLine();
                            Console.WriteLine("Enter Address: ");
                            s2.Address = Console.ReadLine();
                            Console.WriteLine("Enter Percentage: ");
                            s2.Percentage = Convert.ToInt32(Console.ReadLine());
                            studentCRUD.UpdateStudent(s2);
                            Console.WriteLine("Updated Uucessfully...........................");
                            break;

                        case 5:
                            Console.WriteLine("Enter Roll No: ");
                            int Roll = Convert.ToInt32(Console.ReadLine());
                            studentCRUD.DeleteStudent(Roll);
                            Console.WriteLine("Deleted Successfully............................");
                            break;
                    }
                    Console.WriteLine("Press 1 if Continue........");
                    no = Convert.ToInt32(Console.ReadLine());
                } while (no == 1);


            }
        }
    }
}
