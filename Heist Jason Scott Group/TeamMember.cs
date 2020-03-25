using System;
using System.Collections.Generic;
using System.Text;

namespace Heist_Jason_Scott_Group
{
    class TeamMember
    {
        //private decimal _courageFactor;

        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public decimal CourageFactor { get; set; }


        public TeamMember(string name, int skill, decimal courage)
        {
            Name = name;
            SkillLevel = skill;
            CourageFactor = courage;
        }

    }
}
