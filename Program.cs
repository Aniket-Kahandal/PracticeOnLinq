using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOnLinq
{
    public class Student
    {
        public int roll { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int per { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] stdlist = {
            new Student(){roll=1, name="Aniket", age=21 ,per= 83 },
            new Student(){roll=2, name="Anil", age=25 , per = 54},
            new Student(){roll=3, name="Shubham", age=18, per = 29},
            new Student(){roll=4, name="Tejas", age=14 , per = 93},
            new Student(){roll=5, name="ABC", age=29, per = 35 }

        };
                // stdlist.Add(new Student { roll = 1, name = "Aniket", age = 15 });

                var valid_Voter = from student in stdlist
                                  where student.age > 18
                                  select student;
                Console.WriteLine("Teen Ager Student in class ");
                foreach (var ab in valid_Voter)
                {


                    Console.WriteLine("Roll= " + ab.roll + "\tName= " + ab.name + "\tAge= " + ab.age + "\tPer= " + ab.per);
                }

                //Failed Student;
                var passStud = stdlist.Where(student => student.per < 35);
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Fail Student List : ");

                foreach (var item in passStud)
                {
                    Console.WriteLine("Student Name = " + item.name);
                }

                var sortingByRoll = from st in stdlist
                                    orderby st.roll descending
                                    select st;
                Console.WriteLine("---------------------------------------");

                foreach (var item in sortingByRoll)
                {
                    Console.WriteLine("\tRoll = " + item.roll + "\tStudent Name = " + item.name);
                }
                Console.ReadKey();
            }
        }
    }

