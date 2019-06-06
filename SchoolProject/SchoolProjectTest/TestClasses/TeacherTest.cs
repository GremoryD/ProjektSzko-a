using NUnit.Framework;
using SchoolProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectTest.TestClasses
{
    [TestFixture]
    public class TeacherTest
    {
        [Test]
        public void CreateTeacher()
        {
            var subjects = new List<Subject>()
            {
                new Subject("Math",30,15),
                new Subject("Eng",30,15),
                new Subject("Programing",30,15),
            };

            Teacher teacher = new Teacher(subjects); 
            Teacher teacher2 = new Teacher("", "", subjects);
            Teacher teacher3 = new Teacher("test", "test", subjects);
            Teacher teacher4 = new Teacher(null); 
            Teacher teacher5 = new Teacher(null, null, subjects);
            Teacher teacher6 = new Teacher("test", "test space", subjects);    


        }



    }
}
