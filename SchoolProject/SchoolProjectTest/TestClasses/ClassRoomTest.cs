using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SchoolProject.Classes;

namespace SchoolProjectTest.TestClasses
{
    [TestFixture]
    public class ClassRoomTest
    {
        [Test]
        public void CreateRoom()
        {
            Classroom classroom = new Classroom("A1");
            Classroom classroom2 = new Classroom("");
            Classroom classroom3 = new Classroom(null);

            var teachers = new List<Teacher>()
            {
                new Teacher(  new List<Subject>()
                {
                    new Subject("Math",30,15),
                    new Subject("Eng",30,15),
                    new Subject("Programing",30,15),
                }),
                new Teacher(new List<Subject>()
                {
                    new Subject("Test",30,15),
                    new Subject("Test",30,15),
                    new Subject("Test2",30,15),
                }),
                new Teacher(new List<Subject>()
                {
                    new Subject("TestF",30,15),
                    new Subject("TestN",30,15), 
                }),
            };


            Classroom classroom4 = new Classroom("A1",teachers);
            Classroom classroom5 = new Classroom("A2",null);
            Classroom classroom6 = new Classroom("A2", new List<Teacher>());
        }

    }
}
