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
    public class StudentTest
    {

        [TestMethod]
        public void CreateStudent()
        {
            try
            {
                Student student = new Student(1, "", "");
            }
            catch (ArgumentException ex) { }
            try
            {
                Student student2 = new Student(1, null, null);
            }
            catch (ArgumentException ex) { }
            try
            {
                Student student3 = new Student(-1, null, "");
            }
            catch (ArgumentException ex) { }
            try
            {
                Student student5 = new Student(1, "Test", "Test test");
            }
            catch (ArgumentException ex) { }
            Student student4 = new Student(1, "Test", "Test");
        }
    }
}
