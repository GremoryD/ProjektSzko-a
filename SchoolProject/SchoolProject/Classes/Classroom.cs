using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Classes
{
    public class Classroom
    {
        private string _name;

        public String Name
        {
            get => _name; set
            {
                CheckStringInput(value);
                _name = value;
            }
        }

        public List<Teacher> teachers;

        public Classroom(String name)
        {
            Name = name;
            teachers = new List<Teacher>();
        }

        public Classroom(String name, List<Teacher> list)
        {
            CheckListInput(list);
            Name = name;
            teachers = list;
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
        }


        /// <summary>
        /// Check list input parameter
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        private void CheckListInput<T>(List<T> list)
        {
            if (list == null) throw new ArgumentNullException(nameof(list));
            if (list.Count == 0) throw new ArgumentException($"{nameof(list)} cannot be empty", nameof(list));
        }

    }
}
