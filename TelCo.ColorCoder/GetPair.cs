using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    public class GetPair
    {

        /// <summary>
        /// Given the two colors the function returns the pair number corresponding to them
        /// </summary>
        /// <param name="pair">Color pair with major and minor color</param>
        /// <returns></returns>
        private static int GetIndex(Color[] array, Color element )
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == element)
                    return i;
            
            return -1;
        }
        public static int GetPairNumberFromColor(PairsDataModel.ColorPair pair)
        {
            // Find the major color in the array and get the index
            int majorIndex = GetIndex(PairsDataModel.colorMapMajor, pair.majorColor);

            // Find the minor color in the array and get the index
            int minorIndex = GetIndex(PairsDataModel.colorMapMinor, pair.minorColor);
            
            // If colors can not be found throw an exception
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }

            // Compute pair number and Return  
            // (Note: +1 in compute is because pair number is 1 based, not zero)
            return (majorIndex * PairsDataModel.colorMapMinor.Length) + (minorIndex + 1);
        }
    }

}