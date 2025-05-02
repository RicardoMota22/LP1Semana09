using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlayerManager4;

namespace ProjectManager4
{
    public class CompareByName
    {
        // CompareByName
        private readonly bool order;

        public CompareByName(bool aorder)
        {
            this.order = aorder;
        }
        public int Compare(Player x, Player y)
        {
            int comparison = string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
            if (order == true)
            {
                return comparison;
            }
            else
            {
                return -comparison;
            }
            
        }

        public class CompareByScore : IComparer<Player>
        {
            public int Compare(Player x, Player y)
            {
                if (x == null || y == null) return 0;

                return y.Score.CompareTo(x.Score); // Descendente
            }
        }

    }
}