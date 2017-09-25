using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    public class Dices
    {
        public void generateDice()
        {

        }

        public int ThrowDice(int noOfDice)
        {
            int diceSum = 0;

            for(int i = 0; i<noOfDice; i++)
            {
                var random = new Random();
                diceSum += random.Next(1,6);
            }
            //diceSum = 7;
            return diceSum;
        }
    }
}
