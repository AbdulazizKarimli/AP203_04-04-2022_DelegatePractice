using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal class Course
    {
        private List<Student> _students;

        public Course()
        {
            _students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            if (student == null)
                throw new NullReferenceException("xeta");

            _students.Add(student);
        }
        public Student GetStudentByName(string search)
        {
            if (string.IsNullOrWhiteSpace(search))
                throw new NullReferenceException("xeta");

            return _students.Find(s => s.Fullname.Contains(search));
        }
    }
}
