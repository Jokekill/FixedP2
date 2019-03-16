using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Q24_8 : FixedNumber
    {

        public Q24_8(int value)
        {
            this.ShiftAmount = 8;
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

        public static Q24_8 Add(Q24_8 a, Q24_8 b)
        {
            int tmp = a.Value + b.Value;     
            return new Q24_8(0) { Value = tmp };
        }
        public static Q24_8 Subtract(Q24_8 a, Q24_8 b)
        {
            int tmp = a.Value - b.Value;
            return new Q24_8(0){Value = tmp};
        }

        public static Q24_8 Multiply(Q24_8 a, Q24_8 b)
        {
            Int64 tmp = a.Value * b.Value;
            tmp = tmp >> a.ShiftAmount;
            return new Q24_8(0){ Value = (int)tmp};
        }

        public static Q24_8 Divide(Q24_8 a, Q24_8 b)
        {
            Int64 tmpa = a.Value << a.ShiftAmount;
            double tmp = (double)tmpa / b.Value;
            for (int i = 0; i < a.ShiftAmount; i++)
            {
                tmp = 2 * tmp;
            }

            Int64 tmpb = Convert.ToInt64(tmp);
            tmp = tmpb >> a.ShiftAmount;
            Q24_8 resoult = new Q24_8(0) { Value = (int)tmp };
            return resoult;
        }
    }
}
