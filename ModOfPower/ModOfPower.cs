using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    // *****************************************
    // DON'T CHANGE CLASS OR FUNCTION NAME
    // YOU CAN ADD FUNCTIONS IF YOU NEED TO
    // *****************************************
    public static class ModOfPow
    {
        #region YOUR CODE IS HERE
        /// <summary>
        /// Calculate Mod of Power (B^P mod M) in an efficient way
        /// </summary>
        /// <param name="B">Base</param>
        /// <param name="P">Power</param>
        /// <param name="M">Modulus</param>
        /// <returns>Result of B^P mod M </returns>
        public static long ModOfPower(long B, long P, long M)
        {
            //REMOVE THIS LINE BEFORE START CODING
            //throw new NotImplementedException();
            if (B == 0 || M==0)
                return 0;
            if (P == 0)
                return 1;
            if (P == 1)
                return B % M;
            
            long R = ModOfPower(B, P / 2, M);
            if (P % 2 == 0)
            {
                R *= R;
                R %= M;
            }
            else
            {
                R *= R;
                R *= B;
                R %= M;
            }

            R %= M;
            return R;

        }

        #endregion
    }
}
