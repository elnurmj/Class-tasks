using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Cs_go : Video_games
    {
        public Cs_go(string name, string surname, string game, string experience) 
        {
            this.name = name;
            this.surname = surname;
            this.game = game;
            this.experience = experience;
            Console.WriteLine(FullData());

        }
      
    }
}
