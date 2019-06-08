using System;

namespace GCConsole
{

    public static class ToCompareToLower
    {
        public enum AuxEnum
        {
            AttrA, AttrB, AttrC
        }

        public static bool IsEqualWithLower(this Enum auxEnum, string stringCompare)
        {
            return Enum.GetName(auxEnum.GetType(), auxEnum).ToLower() == stringCompare.ToLower();
        }

        public static bool IsEqualWithoutLower(this Enum auxEnum, string stringCompare)
        {
            return Enum.GetName(auxEnum.GetType(), auxEnum) == stringCompare;
        }

        public static bool IsEqualWithComparison(this Enum auxEnum, string stringCompare)
        {
            return Enum.GetName(auxEnum.GetType(), auxEnum).Equals(stringCompare, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
