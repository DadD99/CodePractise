using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionLibrary._1_10
{
    public static class Taxi
    {
        public static decimal CostCalculate(string a)
        {
            decimal cost = 0;
            if(!int.TryParse(a, out int km))
            {
                throw new Exception("Invalid value");
            }
            else
            {
                if(km < 0)
                {
                    throw new Exception("Invalid value");
                }
                if(km <=1)
                {
                    cost = km * 15000;
                    return cost;
                }
                if(km <=5)
                {
                    return cost = km * 13500;
                }
                if(km <=120)
                {
                    return cost = km * 11000;
                }
                if(km >120)
                {
                    return cost = (decimal)(km * (11000 * 0.9));
                }
                return cost;
            }

        }
    }
}
