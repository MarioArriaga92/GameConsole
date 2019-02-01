using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    public class IronBonesDefence : ISpecialDefence
    {
        public int CalculateDamageReduction(int totalDamage)
        {
            return 5;
        }
    }
}
