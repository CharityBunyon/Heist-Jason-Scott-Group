using System;
using System.Collections.Generic;
using System.Linq;

namespace Heist_Jason_Scott_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            var rng = new Random();
            var success = 0;
            var failure = 0;
           

            Console.WriteLine("Plan Your Heist!");
            Console.Write("Set the bank's difficulty level: ");
            var bankDifficultyLevel = int.Parse(Console.ReadLine());


            List<TeamMember> myTeam = new List<TeamMember>();

            var addTeammate = true;
            Console.WriteLine("Would you like to add a team member (y/n)?");
            var response = Console.ReadLine();
            if (response.Equals("n", StringComparison.OrdinalIgnoreCase)) ;
            {
                Console.WriteLine("Sorry, invalid entry. Would you like to add a team member (y/n)?");
                response = Console.ReadLine();
            }

            while (addTeammate)
            {
                if (response == "y" || response == "Y")
                //if (response.Equals("y",StringComparison.OrdinalIgnoreCase))
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

            Console.WriteLine("How many trial runs would you like?");
            var trialRuns = int.Parse(Console.ReadLine());

            for (int i = 0; i < trialRuns; i++)
            {
                var luckValue = rng.Next(-10, 10);
                bankDifficultyLevel += luckValue;
                var teamStrength = myTeam.Sum(person => person.SkillLevel);
                Console.WriteLine($"Your team skill level is {teamStrength}.\nThe bank difficulty level is {bankDifficultyLevel}.");
                if (teamStrength >= bankDifficultyLevel)
                {
                    Console.WriteLine("You're rich! You've completed the heist!");
                    success += 1;
                }
                else
                {
                    Console.WriteLine("Bummer! You're going to jail!");
                    failure += 1;
                }
                bankDifficultyLevel -= luckValue;
            }
            Console.WriteLine($"You completed {success} successful attempts, and {failure} failed attempts.");
            Console.ReadLine();
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
