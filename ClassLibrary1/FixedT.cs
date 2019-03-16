using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Fixed<T> where T : FixedNumber, new() { 

    private static int ShiftAmount;
    private int value;
    
    public Fixed(int value)
    {
        ShiftAmount = (new T()).ShiftAmount;
        this.value = value << ShiftAmount;
    }

    public Fixed<T> Add(Fixed<T> x) 
    {
        int tmp = value + x.value;
        return new Fixed<T>(0) {value = tmp};
    }

    public Fixed<T> Substract(Fixed<T> x)
        {
        int tmp = value - x.value;
        return new Fixed<T>(0) { value = tmp };
        }

    public Fixed<T> Multiply(Fixed<T> x)
    {
        Int64 tmp = (Int64)value * (Int64)x.value;
        tmp = tmp >> ShiftAmount;
        return new Fixed<T>(0) { value = (int)tmp };
        }

    public Fixed<T> Divide(Fixed<T> x)
    {
        Int64 tmpa = (Int64)value << ShiftAmount;
        double tmp = (double) tmpa / x.value;
        for (int i = 0; i < ShiftAmount; i++)
        {
            tmp = 2 * tmp;
        }
        Int64 tmpb = Convert.ToInt64(tmp);
        tmp = tmpb >> ShiftAmount;
        return new Fixed<T>(0) { value = (int)tmp };
          
    }

        
        public override string ToString()
        {
            double tmp = value;
            for (int i = 0; i < ShiftAmount; i++)
            {
                tmp = tmp / 2;
            }
            return (tmp).ToString();
        }   
    }
}
