using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_006.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public static IEnumerable<Student> GetStudents()
        {
            var students = new List<Student>()
            {
                new Student { Id = 1, Name = "Farxod", Points = 65 },
                new Student { Id = 2, Name = "Diyorbek", Points = 45 },
                new Student { Id = 3, Name = "Kamron", Points = 52 },
                new Student { Id = 4, Name = "Atxam", Points = 74 },
                new Student { Id = 5, Name = "Baxtiyor", Points = 99 },
                new Student { Id = 6, Name = "Karim", Points = 99 },
            };
            return students;
        }
    }
}
