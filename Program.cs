using System;

namespace bankHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your Heist!!");
            Console.Write("Enter Team Member Name: ");
            string TeamMemberName = Console.ReadLine();

            Console.Write("Enter Team Member skill level 1- 10: ");
            int TeamMemberSkillLevel = int.Parse(Console.ReadLine());

            Console.Write("Enter Team Member Courage Level 0.0 - 2.0: ");
            double TeamMemberCourage = double.Parse(Console.ReadLine());
            TeamMember member1 = new TeamMember()
            {
                Name = TeamMemberName,
                SkillLevel = TeamMemberSkillLevel,
                Courage = TeamMemberCourage

            };
            member1.GetMemberDetails();
        }
    }
}