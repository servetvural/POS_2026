using System;
using System.Collections.Generic;
using System.Text;

namespace POSLayer.Library;

public class DRNumeric
{

    public DRNumeric()
    {
    }

    public static float Round2(float val, decimal howmuch, bool down)
    {
        decimal given = (decimal)val;
        decimal lover = Math.Round(given, 1);
        if (down)
            return (float)lover;
        else
        {
            if (given > lover)
                return (float)(lover + howmuch);
            else
                return (float)lover;
        }
    }

    public static bool IsBitSet(int CombinedNumber, int BitValue)
    {
        if (BitValue == 0)
        {
            if (CombinedNumber == 0)
                return true;
            else
                return false;
        }
        return ((CombinedNumber & BitValue) == BitValue);
    }
    public static int SetBit(int CombinedNumber, int BitValue)
    {
        CombinedNumber |= BitValue;
        return CombinedNumber;
    }
    public static int UnSetBit(int CombinedNumber, int BitValue)
    {
        CombinedNumber &= CombinedNumber - BitValue;
        return CombinedNumber;
    }

}
