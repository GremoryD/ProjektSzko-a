using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Classes
{
    public class Subject
    {

        public string Name { get; set; }
        public int LectionCount { set; get; }
        public int ExerciseCount { set; get; }

        public Subject(string name, int lectionCount, int exerciseCount)
        {
            CheckStringInput(name);
            Name = name;
            LectionCount = lectionCount;
            ExerciseCount = exerciseCount;
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

    }
}
