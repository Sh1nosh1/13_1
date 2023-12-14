using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T13__1
{
    class Student
    {
        /// <summary>
        /// Student's surname
        /// </summary>
        private string surname;
        public string Surname { get => (surname!="") ? surname: "Unknown"; set => surname = value.ToUpper(); }
        /// <summary>
        /// Course
        /// </summary>
        private int course;
        public int Course { get => (course>=1)&(course<=4) ? course: 0 ; set => course = value; }

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Student() { }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="surname"></param>
        /// <param name="course"></param>
        public Student(string surname, sbyte course)
        {
            this.Surname = surname; this.Course = course;
        }
        public override string ToString()
        {
            return $"Surname: {Surname}\nCourse: {Course}\n";
        }

    }
}
