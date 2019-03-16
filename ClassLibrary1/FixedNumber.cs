using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuni.Arithmetics.FixedPoint
{
    public abstract class FixedNumber
    {    
        public abstract int ShiftAmount  {get;}       
    }

    public class Q24_8 : FixedNumber
    {
        public override int ShiftAmount { get => 8;}
    }
    public class Q16_16 : FixedNumber
    {
        public override int ShiftAmount { get => 16; }
    }
    public class Q8_24 : FixedNumber
    {
        public override int ShiftAmount { get => 24; }
    }
}

