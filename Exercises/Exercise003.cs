using System;
namespace Exercises
{
    public class Exercise003
    {
        //define IceCreamFlavours
        public static string[] IceCreamFlavours = { "Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet" };

        public int IceCreamCode(string iceCreamFlavour)
        {
            if (string.IsNullOrEmpty(iceCreamFlavour))
                return -1; //return -1 if the input iceCreamFlavour is null or empty.
            else
            {
                for (int i = 0; i < IceCreamFlavours.Length; i++)
                    if (IceCreamFlavours[i].Equals(iceCreamFlavour))
                        return i;
            }

            //return -1 if iceCreamFlavour doesn't exist in IceCreamFlavours.
            return -1;
        }

    }
}
