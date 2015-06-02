using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PirateTreasure.Models
{
    public class Treasure
    {
        public double CalculateMinimumNumberOfCoins(double numberOfPirates)
        {
            if (numberOfPirates == 2)
                return Math.Pow(numberOfPirates, numberOfPirates + 2) - (numberOfPirates - 1);
            else
                return Math.Pow(numberOfPirates, numberOfPirates + 1) - (numberOfPirates - 1);
        }
    }
}