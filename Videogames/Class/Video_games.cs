using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Video_games
    {
        public string name;
        public string surname;
        public string game;
        public string experience;

        public string FullName()
        {
            return $"{name} {surname}";
            
        }
        public string FullData()
        {
            return $"{FullName()} {game} {experience}";
        }
        
    }
}
