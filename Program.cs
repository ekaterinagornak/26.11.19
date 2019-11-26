using System;
using System.Xml.Serialization;
using System.IO;
namespace _26._11._19
{
    public class Program
    {
        static void Main(string[] args)
        {
            var group = new StudentGroup();
            group.Name = "Group1";
            for (int i = 1; i < 10; i++)
            {
                var student = new Student();
                student.Name = "Студент " + i;
                student.LastName = "Last Name" + i;
                student.Age = 18 + i;
                group.Students.Add(student);
            }

            var serializer = new XmlSerializer(typeof(StudentGroup));
            using (var file = File.Create("students.xml"))
            {
                serializer.Serialize(file, group);
            }
        }
    }
}
