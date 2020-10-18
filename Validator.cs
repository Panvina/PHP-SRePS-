using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP
{
    public class Validator
    {
        public static bool ValidateMinMaxInputs(int min, int max)
        {
            //Both min/max need to be greater than 0.
            if (min < 0 || max < 0)
            {
                return false;
            }

            //Min can't be lower than max.
            if (min > max)
            {
                return false;
            }

            return true;
        }
    }
}
