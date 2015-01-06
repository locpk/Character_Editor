using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Editor
{
    public class Character
    {
        string firstname;
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        string lastname;
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        decimal age;
        
        public decimal Age
        {
            get { return age; }
            set { age = value; }
        }

        CharacterRace race;

        public CharacterRace Race
        {
            get { return race; }
            set { race = value; }
        }

       

        CharacterSkills skills;

        public CharacterSkills Skills
        {
            get { return skills; }
            set { skills = value; }
        }

        

        public Character Empty
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public override string ToString()
        {
            return firstname + "\t" + lastname + "\t" + age + "\t" + race;
        }
    }
}
