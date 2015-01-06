using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Character_Editor
{
    public struct CharacterSkills
    {
        private decimal bravery;

        public decimal Bravery
        {
            get { return bravery; }
            set { bravery = value; }
        }

        private decimal cheating;

        public decimal Cheating
        {
            get { return cheating; }
            set { cheating = value; }
        }

        private decimal disguise;

        public decimal Disguise
        {
            get { return disguise; }
            set { disguise = value; }
        }

        private decimal endurance;

        public decimal Endurance
        {
            get { return endurance; }
            set { endurance = value; }
        }

        private decimal healing;

        public decimal Healing
        {
            get { return healing; }
            set { healing = value; }
        }

        private decimal knowledge;

        public decimal Knowledge
        {
            get { return knowledge; }
            set { knowledge = value; }
        }

        private decimal leadership;

        public decimal Leadership
        {
            get { return leadership; }
            set { leadership = value; }
        }

        private decimal stealth;

        public decimal Stealth
        {
            get { return stealth; }
            set { stealth = value; }
        }
        public override string ToString()
        {
            return bravery + "\t" + cheating + "\t" + disguise + "\t" + endurance
                 + "\t" + healing + "\t" + knowledge + "\t" + leadership + "\t" + stealth;
        }
        public string ToFile()
        {
            return bravery + "," + cheating + "," + disguise + "," + endurance
                 + "," + healing + "," + knowledge + "," + leadership + "," + stealth;
        }
    }
}
