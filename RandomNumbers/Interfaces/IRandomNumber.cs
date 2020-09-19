using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    public interface IRandomNumber
    {
        int GenerateRandomInteger(int lowerNumber, int higherNumber);
    }
}
