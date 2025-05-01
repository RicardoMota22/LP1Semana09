using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager3
{
    public class Player : IComparable<Player>
    {
        //Properties
        public string Name { get;}
        public int Score { get; set;}

        //Constructor
        public Player(string name, int score)
    {
        Name = name;
        Score = score;
    }
        //Interface IComparable<T>
        public int CompareTo(Player other)
        {
            if (other == null) return 1;
            //return Score.CompareTo(other.Score);//ascendente
            return other.Score.CompareTo(Score);
        }

    }
}