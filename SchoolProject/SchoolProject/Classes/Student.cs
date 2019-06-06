using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Classes
{
    public class Student
    { 
        private string _name;
        private string _surname; 

        public uint ID;

        public Student(int iD, string name, string surname)
        {
            if (iD < 0) throw new ArgumentException($"{nameof(iD)} cannot be below zero", nameof(iD));

            ID = Convert.ToUInt32(iD);
            Name = name;
            Surname = surname;
        }

        public String Name
        {
            get => _name; set
            {
                CheckStringInput(value);
                _name = value.ToUpper();
            }
        }

        public String Surname
        {
            get => _surname; set
            {
                CheckStringInput(value);
                _surname = value.ToUpper();
            }
        } 

        /// <summary>
        /// Check string input parameter
        /// </summary>
        /// <param name="input"></param>
        private void CheckStringInput(String input)
        {
            switch (input)
            {
                case null: throw new ArgumentNullException(nameof(input));
                case "": throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
            }

            if (input.Contains(' '))
            {
                throw new ArgumentException($"{nameof(input)} only one word", nameof(input));
            }
        }

    }
}
