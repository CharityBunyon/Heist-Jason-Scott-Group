using System;
using System.Collections.Generic;
using System.Linq;

namespace Heist_Jason_Scott_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankDifficultyLevel = 100;

        Console.WriteLine("Plan Your Heist!");

            List<TeamMember> myTeam = new List<TeamMember>();

            var addTeammate = true;
            Console.WriteLine("Would you like to add a team member (y/n)?");
            var response = Console.ReadLine();

            while (addTeammate)
            {
                if (response == "y" || response == "Y")
                {
                    myTeam.Add(CreateTeamMember());
                    Console.WriteLine($"Your team currently includes {myTeam.Count()} team member(s). Would you like to add another team member (y/n)?");
                    response = Console.ReadLine();
                }
                else
                {
                    addTeammate = false;
                }
            }

            var teamStrength = myTeam.Sum(person => person.SkillLevel);
            if (teamStrength >= bankDifficultyLevel)
            {
                Console.WriteLine("You're rich! You've completed the heist!");
            }
            else
            {
                Console.WriteLine("Bummer! You're going to jail!");
            }
        }

        static TeamMember CreateTeamMember()
        {
            Console.Write("Enter your team member's name: ");
            var teamMemberName = Console.ReadLine();
            Console.Write("Enter your team member's skill level (this should be a positive integer): ");
            var teamMemberSkillLevel = int.Parse(Console.ReadLine());
            if (teamMemberSkillLevel < 0)
            {
                Console.Write("Sorry, that is not a valid entry. Enter your team member's skill level (this should be a positive integer): ");
                teamMemberSkillLevel = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter your team member's courage factor between 0.0 and 2.0: ");
            var teamMemberCourageFactor = decimal.Parse(Console.ReadLine());
            if (teamMemberCourageFactor < 0.0m || teamMemberCourageFactor > 2.0m)
            {
                Console.Write("Sorry, you did not enter a valid number. Enter your team member's courage factor between 0.0 and 2.0: ");
                teamMemberCourageFactor = decimal.Parse(Console.ReadLine());
            }
            TeamMember newTeamMember = new TeamMember(teamMemberName, teamMemberSkillLevel, teamMemberCourageFactor);
            return newTeamMember;
        }
    }
}
