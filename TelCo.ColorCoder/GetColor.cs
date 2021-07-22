using System;
using System.Drawing;

namespace TelCo.ColorCoder
{

    public class GetColor
    {
        public static PairsDataModel.ColorPair GetColorFromPairNumber(int pairNumber)
        {
            // The function supports only 1 based index. Pair numbers valid are from 1 to 25
            int minorSize = PairsDataModel.colorMapMinor.Length;
            int majorSize = PairsDataModel.colorMapMajor.Length;
            if (pairNumber < 1 || pairNumber > minorSize * majorSize)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }

            // Find index of major and minor color from pair number
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;

            // Construct the return val from the arrays
            PairsDataModel.ColorPair pair = new PairsDataModel.ColorPair()
            {
                majorColor = PairsDataModel.colorMapMajor[majorIndex],
                minorColor = PairsDataModel.colorMapMinor[minorIndex]
            };

            // return the value
            return pair;
        }

    }

}