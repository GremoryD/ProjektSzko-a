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
    public class StudentTest
    {

        [Test]
        public void CreateStudent()
        {
            Student student = new Student(1, "", "");
            Student student2 = new Student(1, null,null);
            Student student3 = new Student(-1, null,"");
            Student student5 = new Student(1, "Test", "Test test");
            Student student4 = new Student(1, "Test", "Test");
        }
    }
}
