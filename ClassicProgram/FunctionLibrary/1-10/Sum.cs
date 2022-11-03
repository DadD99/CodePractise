using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionLibrary._1_10
{
    public static class Sum
    {
        public static int TinhTongCacChuSo(string a)
        {
            int sum = 0;
            if (!int.TryParse(a, out int Number))
            {
                throw new Exception("Invalid value");
            }
            else
            {
                while (Number >0)
                {
                    int nRem = Number % 10;
                    sum += nRem;
                    Number = Number / 10;
                }
                return sum;
            }
            return sum;
        }
    }
}
