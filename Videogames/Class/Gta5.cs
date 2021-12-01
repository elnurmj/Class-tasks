using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Gta5 : Video_games
    {
        public Gta5(string name, string surname, string game, string experience)
        {
            this.name = name;
            this.surname = surname;
            this.game = game;
            this.experience = experience;
            Console.WriteLine(FullData());
        }
    }

}
