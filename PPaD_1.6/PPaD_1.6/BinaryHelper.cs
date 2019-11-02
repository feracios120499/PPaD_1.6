using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPaD_1._6
{
    public class BinaryHelper
    {

        public static string ToBinary(int originalNumber)
        {

            var tempNumber = Math.Abs(originalNumber);

            string resultStr = Convert.ToString(tempNumber, 2);

            if (originalNumber < 0)
            {
                string negativeResult = string.Empty;
                for (int i = 0; i < resultStr.Length; i++)
                {
                    negativeResult+= resultStr[i] == '1' ? '0' : '1';
                }

                return negativeResult.Insert(0, "1,");
            }
            return resultStr;
        }

        public static string ToDopBinary(int originalNumber)
        {
            var resultStr = ToBinary(originalNumber);
            var resultArray = resultStr.ToArray();
            resultArray[resultStr.Length-1] = '1';

            return new string(resultArray);
        }

        public static float ToIEEE754(int originalNumber)
        {
            int fb = originalNumber;

            int sign = (int)((fb >> 31) & 1);
            int exponent = (int)((fb >> 23) & 0xFF);
            int mantissa = (int)(fb & 0x7FFFFF);

            float fMantissa;
            float fSign = sign == 0 ? 1.0f : -1.0f;

            if (exponent != 0)
            {
                exponent -= 127;
                fMantissa = 1.0f + (mantissa / (float)0x800000);
            }
            else
            {
                if (mantissa != 0)
                {
                    // denormal
                    exponent -= 126;
                    fMantissa = 1.0f / (float)0x800000;
                }
                else
                {
                    // +0 and -0 cases
                    fMantissa = 0;
                }
            }

            float fExponent = (float)Math.Pow(2.0, exponent);
            float ret = fSign * fMantissa * fExponent;
            return ret;
        }
    }
}
