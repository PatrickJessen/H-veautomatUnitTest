using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HæveautomatUnitTest
{
    public class Validation
    {
        public bool IsPinCodeValid(int pinCode, int input)
        {
            if (pinCode == input)
                return true;
            return false;
        }
    }
}
