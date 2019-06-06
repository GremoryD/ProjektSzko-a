using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolProject.Classes;

namespace SchoolProjectTest.TestClasses
{
    [TestClass]
    public class ClassRoomTest
    {
        [TestMethod]
        public void CreateRoom()
        {
            //No argument exceptions
            Classroom classroom = new Classroom("A1"); 

            try
            {
                Classroom classroom2 = new Classroom("");
            }
            catch (ArgumentException ex) { }

            try
            {
                Classroom classroom3 = new Classroom(null); 
            }
            catch (ArgumentException ex) { }

             
            var teachers = new List<Teacher>()
            {
                new Teacher(new List<Subject>()
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

            //No argument exceptions
            Classroom classroom4 = new Classroom("A1", teachers);  

            try
            {
                Classroom classroom5 = new Classroom("A2", null);
            }
            catch (ArgumentException ex) { }

            try
            {
                Classroom classroom6 = new Classroom("A2", new List<Teacher>());
            }
            catch (ArgumentException ex) { }
        }
    }
}
