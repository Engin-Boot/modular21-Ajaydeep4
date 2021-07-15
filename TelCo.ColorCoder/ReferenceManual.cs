using System;
using System.Diagnostics;

namespace TelCo.ColorCoder
{
    public delegate void ManualDelegate();

    public class ReferenceManual
    {
        private static readonly int maj_size = PairsDataModel.colorMapMajor.Length;
        private static readonly int min_size = PairsDataModel.colorMapMinor.Length;

        public static void Manual(ManualDelegate funcAddress)
        {
            funcAddress.Invoke();
        }
        public static void PrintManual()
        {
            int pair_no = 1;
            for (int i=0; i<maj_size; ++i)
                for(int j=0; j<min_size; ++j)
                {
                    Console.WriteLine("Major-color : {0}, Minor-color : {1}, Pair : {2}", PairsDataModel.colorMapMajor[i], PairsDataModel.colorMapMinor[j], pair_no);
                    pair_no++;
                }

        }
        public static void ManualTesting()
        {
            int pair_no = 1;
            for (int i = 0; i < maj_size; ++i)
                for (int j = 0; j < min_size; ++j)
                {
                    PairsDataModel.ColorPair testPair = GetColor.GetColorFromPairNumber(pair_no);
                    Debug.Assert(testPair.majorColor == PairsDataModel.colorMapMajor[i]);
                    Debug.Assert(testPair.minorColor == PairsDataModel.colorMapMinor[j]);

                    testPair = new PairsDataModel.ColorPair()
                    {
                        majorColor = PairsDataModel.colorMapMajor[i],
                        minorColor = PairsDataModel.colorMapMinor[j]
                    };
                    int pairNumberReceived = GetPair.GetPairNumberFromColor(testPair);
                    Debug.Assert(pair_no == pairNumberReceived);

                    pair_no++;
                }
        }
    }
}
