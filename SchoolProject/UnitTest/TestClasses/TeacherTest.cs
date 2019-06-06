using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectTest.TestClasses
{
    [TestClass]
    public class TeacherTest
    {
        [TestMethod]
        public void CreateTeacher()
        {
            var subjects = new List<Subject>()
            {
                new Subject("Math",30,15),
                new Subject("Eng",30,15),
                new Subject("Programing",30,15),
            };

            Teacher teacher = new Teacher(subjects);

            try
            {
                Teacher teacher2 = new Teacher("", "", subjects);

            }
            catch (ArgumentException ex) { }

            Teacher teacher3 = new Teacher("test", "test", subjects);

            try
            {
                Teacher teacher4 = new Teacher(null);

            }
            catch (ArgumentException ex) { }

            try
            {
                Teacher teacher5 = new Teacher(null, null, subjects);

            }
            catch (ArgumentException ex) { }
            try
            {
                Teacher teacher6 = new Teacher("test", "test space", subjects);

            }
            catch (ArgumentException ex) { }


        } 

    }
}
