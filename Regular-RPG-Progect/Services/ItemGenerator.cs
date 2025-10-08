using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Regular_RPG_Progect.Entities.Items;

namespace Regular_RPG_Progect.Services.Items
{
    abstract class ItemGenerator<T>
    {
        public abstract T Generate(int lvl);

        protected int CalculatePrice(int value)
        {
            return value * (40 + Utils.CustomRandom.Next(1, 10));
        }
    }
}
