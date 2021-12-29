using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Royal_Game_of_Ur
{
    class Dice
    {
        Random rnd = new Random();
        int rollOne()
        {
            int result = this.rnd.Next(0, 1);
            return result;
        }

        int[] rollAll()
        {
            int[] results = new int[5];
            int sum = 0;
            for (int i = 0; i < results.Length - 1; i++)
            {
                results[i] = this.rollOne();
                sum += results[i];
            }
            results[4] = sum;
            return results;
        }
    }
}
