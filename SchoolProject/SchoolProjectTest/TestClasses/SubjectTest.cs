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
    public class SubjectTest
    {

        [Test]
        public void CreateSubject()
        {
            Subject subject = new Subject("Test", 30, 30);
            Subject subject2 = new Subject(null, 30, 30);
            Subject subject3 = new Subject("", 30, 30);
        }
    }
}
