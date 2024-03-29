﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Classes
{
    public class School
    {
        public Dictionary<String,Classroom> classrooms;
        public Dictionary<uint, Student> students; 

        public School()
        {
            this.classrooms = new Dictionary<String,Classroom>();
            this.students = new Dictionary<uint,Student>();
        }

        /// <summary>
        /// Add student to school
        /// </summary>
        /// <param name="student"></param>
        public void AddStudent(Student student)
        {
            uint key = students.Keys.Last()+1;
            student.ID = key;
            students.Add(student.ID, student);
        }

        /// <summary>
        /// Remove student by ID
        /// </summary>
        /// <param name="key">Student ID</param>
        public void RemoveStudent(int key)
        {
            if(key<0) throw new ArgumentException($"{nameof(key)} cannot be below zero", nameof(key));
            students.Remove((uint)key);
        }

        /// <summary>
        /// Add Classroom
        /// </summary>
        /// <param name="classroom"></param>
        public void AddClassroom(Classroom classroom)
        {
            classrooms.Add(classroom.Name, classroom);
        }

        /// <summary>
        /// REmove classroom
        /// </summary>
        /// <param name="name">Classroom name</param>
        public void RemoveClassroom(String name)
        {
            classrooms.Remove(name);
        }

    }
}
