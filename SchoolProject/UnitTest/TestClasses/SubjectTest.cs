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
    public class SubjectTest
    {

        [TestMethod]
        public void CreateSubject()
        {
            Subject subject = new Subject("Test", 30, 30);
            try
            {
                Subject subject2 = new Subject(null, 30, 30);
            }
            catch (ArgumentException ex) { }
            try
            {
                Subject subject3 = new Subject("", 30, 30);
            }
            catch (ArgumentException ex) { }
        }
    }
}
