using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_ClientApp2
{
    /// <summary>
    /// monster entity class
    /// </summary>
    public class Monster
    {
        public enum EmotionalState
        {
            none,
            happy,
            sad,
            angry,
            bored
        }

        public enum Tribe
        {
            none,
            Bloodhoof,
            Cliffwalker,
            Cloudsong,
            Darkmane,
            Gurubashi,
            Amani,
            Drakkari
        }

        #region PROPERTIES

        public string Name { get; set; }

        public int Age { get; set; }

        public EmotionalState Attitude { get; set; }

        public Tribe TribalAffiliation { get; set; }
        public bool Active { get; set; }
        public DateTime DOB { get; set; }

        #endregion

        #region CONSTRUCTORS

        public Monster()
        {

        }

        public Monster(string name, int age, EmotionalState attitude, Tribe tribe, bool active, DateTime dob)
        {
            Name = name;
            Age = age;
            Attitude = attitude;
            TribalAffiliation = tribe;
            Active = active;
            DOB = dob;
        }

        #endregion
        
        #region METHODS

        public string Greeting()
        {
            string greeting;

            switch (Attitude)
            {
                case EmotionalState.happy:
                    greeting = $"Hello, my name is {Name} and I am having a great day!";
                    break;

                case EmotionalState.sad:
                    greeting = $"{Name} is feeling bad.";
                    break;

                case EmotionalState.angry:
                    greeting = $"I'm {Name}, and stay away from me!";
                    break;

                case EmotionalState.bored:
                    greeting = $"I don't know what to do at {Age} years old.";
                    break;

                default:
                    greeting = $"Hello, my name is {Name}.";
                    break;
            }
                       
            return greeting;
        }

        #endregion
    }
}
