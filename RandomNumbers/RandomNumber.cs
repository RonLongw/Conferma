using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomNumbers;

namespace RandomNumbers
{
    public class RandomNumber : IRandomNumber 
    {
        public int GenerateRandomInteger(int lowerNumber, int higherNumber)
        {
            var generator = new Random();

            return generator.Next(lowerNumber, higherNumber + 1);
        }
    }
}
