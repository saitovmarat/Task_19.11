using System;
using System.Collections.Generic;
using System.Text;

namespace Task_19._11
{

    class BigRace : IAddGames
    {
        static public List<string> Games = new List<string>  { "Пляж", "Мышеловка", "Море", "Рыбалка", "Почтальоны", "Горка" };
        public BigRace()
        {

        }
        public void AddGame(params string[] games)
        {
            foreach(string item in games)
            {
                Games.Add(item);
            }
            
        }
    }
}
