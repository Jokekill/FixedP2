using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Q8_24 : FixedNumber
    {

        public Q8_24(int value)
        {
            this.ShiftAmount = 16;
            this.Value = value << ShiftAmount;
        }

        public override string ToString()
        {
            double tmp = Value;
            for (int i = 0; i < ShiftAmount; i++)
            {
                tmp = tmp / 2;
            }
            return (tmp).ToString();
        }

        public static Q16_16 Add(Q16_16 a, Q16_16 b)
        {
            int tmp = a.Value + b.Value;
            tmp = tmp >> a.ShiftAmount;
            return new Q16_16(tmp);
        }
        public static Q16_16 Subtract(Q16_16 a, Q16_16 b)
        {
            int tmp = a.Value - b.Value;
            tmp = tmp >> a.ShiftAmount;
            return new Q16_16(tmp);
        }

        public static Q16_16 Multiply(Q16_16 a, Q16_16 b)
        {
            Int64 tmp = (Int64)a.Value * (Int64)b.Value;
            tmp = tmp >> a.ShiftAmount * 2;
            return new Q16_16((int)tmp);
        }

        public static Q16_16 Divide(Q16_16 a, Q16_16 b)
        {
            Int64 tmpa = a.Value;
            tmpa = tmpa << a.ShiftAmount;
            double tmp = (double)tmpa / b.Value;
            for (int i = 0; i < a.ShiftAmount; i++)
            {
                tmp = 2 * tmp;
            }

            Int64 tmpb = Convert.ToInt64(tmp);
            tmp = tmpb >> a.ShiftAmount;
            Q16_16 resoult = new Q16_16(0) { Value = (int)tmp };
            return resoult;
        }
    }
}
