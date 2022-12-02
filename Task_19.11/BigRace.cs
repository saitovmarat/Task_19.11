using System;
using System.Collections.Generic;
using System.Text;

namespace Task_19._11
{

    class BigRace : IAddGames
    {
        static public List<Game> Games = new List<Game>  { new Game("Пляж"), new Game("Мышеловка"), new Game("Море"), new Game("Рыбалка"), new Game("Почтальоны"), new Game("Горка") };
        public BigRace()
        {

        }
        public void AddGame(List<Game> games)
        {
            foreach(Game item in games)
            {
                Games.Add(item);
            }
            
        }
    }
}
