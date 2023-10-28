namespace _05._Teamwork_Projects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            InitializeTeams(teams);
            JoinTeam(teams);
            PrintValidTeams(teams);
            PrintDisbandTeams(teams);

        }

        static void PrintDisbandTeams(List<Team> teams)
        {
            List<Team> teamsToDisband = teams
                .Where(t => t.Members.Count == 0)
                .OrderBy(t => t.Name)
                .ToList();

            Console.WriteLine("Teams to disband: ");

            foreach (Team disbandTeam in teamsToDisband)
            {
                Console.WriteLine($"{disbandTeam.Name}");
            }
        }

        static void PrintValidTeams(List<Team> teams)
        {
            List<Team> teamsWithMembers = teams
                            .Where(t => t.Members.Count > 0)
                            .OrderByDescending(t => t.Members.Count)
                            .ThenBy(t => t.Name)
                            .ToList();

            foreach (Team team in teamsWithMembers)
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");

                foreach (string member in team.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
        }

        static void JoinTeam(List<Team> teams)
        {
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] commandArgs = command
                         .Split("->", StringSplitOptions.RemoveEmptyEntries);

                string user = commandArgs[0];
                string teamName = commandArgs[1];

                if (!TeamAlreadyExists(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (AlreadyAMember(teams, user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    Team teamToJoin = teams
                        .First(t => t.Name == teamName);
                    teamToJoin.AddMember(user);
                }
            }
        }

        static bool AlreadyAMember(List<Team> teams, string user)
        {
            return teams.Any(t => t.Members.Contains(user)) ||
                   teams.Any(t => t.Creator == user);
        }

        static void InitializeTeams(List<Team> teams)
        {
            int teamsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < teamsCount; i++)
            {
                string[] teamArgs = Console.ReadLine()
                         .Split('-', StringSplitOptions.RemoveEmptyEntries);

                string creator = teamArgs[0];
                string teamName = teamArgs[1];

                if (TeamAlreadyExists(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (AlreadyCreated(teams, creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team newTeam = new Team(teamName, creator);
                    teams.Add(newTeam);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }
        }

        static bool AlreadyCreated(List<Team> teams, string creator)
        {
            return teams.Any(t => t.Creator == creator);
        }

        static bool TeamAlreadyExists(List<Team> teams, string teamName)
        {
            return teams.Any(t => t.Name == teamName);
        }
    }

    public class Team
    {
        private readonly List<string> members;

        public Team(string name, string creator)
        {
            this.Name = name;
            this.Creator = creator;

            this.members = new List<string>();
        }

        public string Name { get; set; }    

        public string Creator { get; set; }

        //Get-Only Property
        public List<string> Members
            => this.members;

        public void AddMember(string memberName) 
        {
            this.members.Add(memberName);
        }
    }
}
