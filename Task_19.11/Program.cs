using System;
using System.Collections.Generic;
using System.Threading;

namespace Task_19._11
{
    class Program
    {
        static void RepeatTheMainProcess(int i, List<string> appropriateTeams, List<string> teams)
        {
            Console.WriteLine($"Кто с кем будет играть в {BigRace.Games[i]} из этого списка? (Напиши через пробел)");
            DisplayTeams(teams);
            string[] enemy = Console.ReadLine().Split(" ");
            if (enemy[0] == enemy[1])
            {
                Console.WriteLine($"{enemy[0]} не может играть с командой {enemy[1]}, это одна и та же команда.");
                Console.ReadKey();
                Console.Clear();
                RepeatTheMainProcess(i, appropriateTeams, teams);
            }
            else if (!IsThisTeamAppropriate(appropriateTeams, enemy[0]) || (!IsThisTeamAppropriate(appropriateTeams, enemy[1])))
            {
                Console.WriteLine($"{enemy[0]} не может играть с командой {enemy[1]}, таких команд нет.");
                Console.ReadKey();
                Console.Clear();
                RepeatTheMainProcess(i, appropriateTeams, teams);
            
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine($"{enemy[0]} сыграл(а) с {enemy[1]} в {BigRace.Games[i]}");
                Console.ReadKey();
                Console.Clear();

            }
            
        }
        static void DisplayTeams(List<string> teams)
        {
            for(int i = 0; i<teams.Count; i++)
            {
                Console.WriteLine(teams[i]);
            }
        }
        static bool IsThisTeamAppropriate(List<string> appropriateTeams, string team)
        {
            foreach(string element in appropriateTeams)
            {
                if(team == element)
                {
                    return true;
                }
            }
            return false;

        }
        static void Main(string[] args)
        {
            List<string> appropriateTeams = new List<string>{ "Россия", "Франция", "Китай", "Украина" };
            List<string> teams = new List<string> { };
            while (teams.Count != 4)
            {
                Console.WriteLine("Какую команду хотите создать");
                string country = Console.ReadLine();
                if (!IsThisTeamAppropriate(appropriateTeams, country))
                {
                    Console.WriteLine("Not appropriate team, try again");
                    Thread.Sleep(2000);
                }
                else
                {
                    bool temp = true; 
                    for (int i = 0; i<teams.Count; i++)
                    {
                        if (teams[i] == country)
                        {
                            Console.WriteLine("Такая команда уже есть. Попробуй еще раз.");
                            temp = false;
                            Thread.Sleep(2000);
                            break;
                        }
                    }
                    if (temp == true)
                    {
                        teams.Add(country);
                    }
                    
                }
                Console.Clear();
            }

            for (int i = 0; i < BigRace.Games.Count; i++)
            {
                Console.WriteLine($"Кто с кем будет играть в {BigRace.Games[i]} из этого списка? (Напиши через пробел)");
                DisplayTeams(teams);
                string[] enemy = Console.ReadLine().Split(" ");
                if (enemy[0] == enemy[1])
                {
                    Console.WriteLine($"{enemy[0]} не может играть с командой {enemy[1]}, это одна и та же команда.");
                    Console.ReadKey();
                    Console.Clear();
                    RepeatTheMainProcess(i, appropriateTeams, teams);
                }
                else if (!IsThisTeamAppropriate(appropriateTeams, enemy[0]) || (!IsThisTeamAppropriate(appropriateTeams, enemy[1])))
                {
                    Console.WriteLine($"{enemy[0]} не может играть с командой {enemy[1]}, таких команд нет.");
                    Console.ReadKey();
                    Console.Clear();
                    RepeatTheMainProcess(i, appropriateTeams, teams);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine($"{enemy[0]} сыграл(а) с {enemy[1]} в {BigRace.Games[i]}");
                    Console.ReadKey();
                    Console.Clear();
                }
            }


            bool flag = false;
            while (!flag)
            {
                Console.WriteLine("Команды наигрались (да или нет)");
                string answer = Console.ReadLine().ToLower();
                if (answer == "да")
                {
                    flag = true;
                    Console.Clear();
                    Console.WriteLine("Конец игры.");
                }
                else if (answer == "нет")
                {
                    Console.WriteLine("В какие игры еще они поиграют? (напиши названия игр через два пробела)");                    
                    new BigRace().AddGame(Console.ReadLine().Split("  "));
                    int index = BigRace.Games.Count;
                    for (int i = index; i< BigRace.Games.Count; i++)
                    {
                        RepeatTheMainProcess(i, appropriateTeams, teams);
                    }
                    flag = true;
                    Console.Clear();
                    Console.WriteLine("Конец игры");
                }
                else
                {
                    Console.WriteLine("Неверный ответ");
                }
            }
        }
    }
}
