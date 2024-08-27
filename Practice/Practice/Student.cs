using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public void CreateStudent(int rollNo,string name,string gender,int age) 
        { 
            this.RollNo=rollNo;
            this.Name=name;
            this.Gender=gender;
            this.Age=age;
        }
        public void GetStudents() 
        {
            Console.WriteLine("Roll No :- {0}",RollNo);
            Console.WriteLine("Name :- {0}", Name);
            Console.WriteLine("Gender :- {0}", Gender);
            Console.WriteLine("Age :- {0}", Age);
        }

        static void Main(string[] args)
        {
            Student Akshay = new Student();
            Akshay.CreateStudent(11,"Akshay Shinde","Male",24);
            Akshay.GetStudents();



            Console.ReadLine();
        }
    }
}
