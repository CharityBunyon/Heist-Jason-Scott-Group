using System;

namespace Heist_Jason_Scott_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            var firstTeamMember = CreateTeamMember();
            Console.WriteLine($"My team member's name is {firstTeamMember.Name}.  Their skill level is {firstTeamMember.SkillLevel} and courage is {firstTeamMember.CourageFactor}");
        }

        static TeamMember CreateTeamMember()
        {
            Console.WriteLine("Enter your team member's name");
            var teamMemberName = Console.ReadLine();
            Console.WriteLine("Enter your team member's skill level (this should be a positive integer");
            var teamMemberSkillLevel = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter your team member's courage factor between 0.0 and 2.0");
            var teamMemberCourageFactor = decimal.Parse(Console.ReadLine());

            TeamMember newTeamMember = new TeamMember(teamMemberName, teamMemberSkillLevel, teamMemberCourageFactor);

            return newTeamMember;
        }
    }
}
