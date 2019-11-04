using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Team
    {
        public Team(string TeamName, string TeamCreator)
        {
            this.TeamName = TeamName;
            this.TeamCreator = TeamCreator;
            this.Members = new List<string>();
        }
        public string TeamName { get; set; }
        public string TeamCreator { get; set; }
        public List<string> Members { get; set; }

    }

    class Program
    {
        static void Main()
        {
            List<Team> teams = new List<Team>();
            int countOfTeams = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfTeams; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string teamCreator = input[0];
                string teamName = input[1];
                bool isExistingTeam = teams.Any(x => x.TeamName == teamName);
                bool isExistingTeamCreator = teams.Any(x => x.TeamCreator == teamCreator);

                if (!isExistingTeam && !isExistingTeamCreator)
                {
                    Team team = new Team(teamName, teamCreator);
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {teamCreator}!");
                }
                else if (isExistingTeamCreator)
                {
                    Console.WriteLine($"{teamCreator} cannot create another team!");
                }
                else if (isExistingTeam)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of assignment")
                {
                    break;
                }
                string[] splitedInput = input.Split("->");
                string member = splitedInput[0];
                string team = splitedInput[1];
                bool isTeamExisting = teams.Any(x => x.TeamName == team);
                bool isUserOrCreatorAMember = teams.Any(x => x.Members.Contains(member) || x.TeamCreator == member);

                if (!isTeamExisting)
                {
                    Console.WriteLine($"Team {team} does not exist!");
                    continue;
                }
                else if (isUserOrCreatorAMember)
                {
                    Console.WriteLine($"Member {member} cannot join team {team}!");
                    continue;
                }
                else 
                {
                    int indexOfTeam = teams.FindIndex(x => x.TeamName == team);
                    teams[indexOfTeam].Members.Add(member);
                }



            }
            List<Team> TeamsWithMembers = teams
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.TeamName)
                .ToList();
            List<Team> TeamsWithoutMembers = teams
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.TeamName)
                .ToList();
            foreach (var team in TeamsWithMembers)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine("- " + team.TeamCreator);
                Console.WriteLine(string.Join(Environment.NewLine, team.Members.Select(x => $"-- {x}")));
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in TeamsWithoutMembers)
            {
                Console.WriteLine(team.TeamName);
            }


        }

    }

}

