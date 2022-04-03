using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadWpf
{
    public class FibCalc
    {
        int valueOne = 0;
        int valueTwo = 0;
        int result = 0;
        public FibCalc()
        {
        }
        public int GetNum()
        {
            if(valueOne == 0 && valueTwo == 0)
            {
                valueTwo++;
                return 0;
            }
            else if(valueOne == 0 && valueTwo == 1 && result == 0)
            {
                result = 1;
                return 1;
            }
            else
            {
                result = valueOne + valueTwo;
                valueOne = valueTwo;
                valueTwo = result;
                return result;
            }
        }
    }
}
