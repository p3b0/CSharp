using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkNumber
{
    public class Check
    {
        public int Calculate(string socialNumber)
        {
            int numPos = 0;
            int lastNumber = 0;
            int oneTwo = 2;
            int total = 0;

            for (numPos = 0; numPos < 9; numPos++)
            {

                total += int.Parse(socialNumber.Substring(numPos, 1));

            }

            return lastNumber;
        }
    }
}
