using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Classes
{
    public class Teacher
    {
        private string _name;
        private string _surname;
        private List<Subject> _subjects;


        public String Name { get => _name; set {
                CheckStringInput(value);
                _name = value.ToUpper();
            } 
        }
         
        public String Surname { get => _surname; set
            {
                CheckStringInput(value);
                _surname = value.ToUpper();
            }
        }
         

        public Teacher(String name, String surname, List<Subject> ls)
        {
            CheckListInput(ls);
            Name = name;
            Surname = surname;
            _subjects = ls;
        }


        public Teacher(List<Subject> ls)
        {
            CheckListInput(ls);
            Name = "NoName";
            Surname = "NoSurname";
            _subjects = ls;
        }

        /// <summary>
        /// Check string input parameter
        /// </summary>
        /// <param name="input"></param>
        private  void CheckStringInput(String input)
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

        /// <summary>
        /// Check list input parameter
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        private void CheckListInput<T>(List<T> list)
        {
            if(list == null) throw new ArgumentNullException(nameof(list));
            if(list.Count==0) throw new ArgumentException($"{nameof(list)} cannot be empty", nameof(list));
        }

        public void AddSubject(Subject subject)
        {
            if(subject==null) throw new ArgumentNullException(nameof(subject)); 
            _subjects.Add(subject); 
        }

        public void RemoveSubject(String name)
        {
            switch (name)
            {
                case null: throw new ArgumentNullException(nameof(name));
                case "": throw new ArgumentException($"{nameof(name)} cannot be empty", nameof(name));
            }

            var itemToRemove = _subjects.SingleOrDefault(r => r.Name == name);

            if (itemToRemove == null) throw new Exception($"{name} cannot be found");
                _subjects.Remove(itemToRemove); 
        }

    }
}
