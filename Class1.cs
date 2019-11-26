using System;
using System.Collections.Generic;
using System.Text;

namespace _26._11._19
{
    public class StudentGroup
    {
        public string Name { get; set; } //свойство Name
        public List<Student> Students { get; set; } = new List<Student>();
        

    }

    public class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public int Age { get; set; }
        public List<int> Ratings { get; set; } = new List<int>();

    }
}
