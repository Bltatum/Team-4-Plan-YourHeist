using System;
using System.Collections.Generic;

namespace bankHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            int bankDifficulty = 100;
            List<TeamMember> TeamMemberList = new List<TeamMember>();

            Console.WriteLine("Plan your Heist!!");
            Console.WriteLine("How many members are on your team?");
            int TeamMemberCount = int.Parse(Console.ReadLine());

            while (TeamMemberCount > 0)
            {
                Console.Write("Enter Team Member Name: ");
                string TeamMemberName = Console.ReadLine();

                if (TeamMemberName == "")
                {
                    TeamMemberCount = 0;
                    break;
                }

                Console.Write("Enter Team Member skill level 1 - 50: ");
                int TeamMemberSkillLevel = int.Parse(Console.ReadLine());

                Console.Write("Enter Team Member Courage Level 0.0 - 2.0: ");
                double TeamMemberCourage = double.Parse(Console.ReadLine());
                TeamMember newMember = new TeamMember()
                {
                    Name = TeamMemberName,
                    SkillLevel = TeamMemberSkillLevel,
                    Courage = TeamMemberCourage

                };

                TeamMemberList.Add(newMember);
                newMember.GetMemberDetails();
                TeamMemberCount--;
            }

            if (TeamMemberCount == 0)
            {
                Console.WriteLine($"You have {TeamMemberList.Count} members on your team");
                int skillMemberSum = 0;
                foreach (TeamMember member in TeamMemberList)
                {
                    skillMemberSum += member.SkillLevel;
                }
                if (skillMemberSum >= bankDifficulty)
                {
                    Console.WriteLine("Success!");
                }
                else
                {
                    Console.WriteLine("Fail!");

                }
            }

        }
    }
}