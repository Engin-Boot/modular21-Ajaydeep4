﻿using System;
using System.Diagnostics;
using System.Drawing;
//using Class PairsDataModel;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// The 25-pair color code, originally known as even-count color code, 
    /// is a color code used to identify individual conductors in twisted-pair 
    /// wiring for telecommunications.
    /// This class provides the color coding and 
    /// mapping of pair number to color and color to pair number.
    /// </summary>
    class Testing
    {
        private static void Main(string[] args)
        {
            ReferenceManual.PrintManual();
            //for(int i=0; i< PairsDataModel.colorMapMajor.Length; ++i)
            //    for(int i=0; i< PairsDataModel.colorMapMinor.Length; ++i)
            //        Debug.Assert()

            
            //Testing for getting color code from pair numbers
            int pairNumber = 1;
            for (int i = 0; i < PairsDataModel.colorMapMajor.Length; ++i)
                for (int j = 0; j < PairsDataModel.colorMapMinor.Length; ++j)
                {
                    PairsDataModel.ColorPair testPair = GetColor.GetColorFromPairNumber(pairNumber);
                    Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair);
                    Debug.Assert(testPair.majorColor == PairsDataModel.colorMapMajor[i]);
                    Debug.Assert(testPair.minorColor == PairsDataModel.colorMapMinor[j]);
                    pairNumber++;

                }

            PairsDataModel.ColorPair testPair2 = new PairsDataModel.ColorPair() { majorColor = Color.Yellow, minorColor = Color.Green };
            pairNumber = GetPair.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            Debug.Assert(pairNumber == 18);

            testPair2 = new PairsDataModel.ColorPair() { majorColor = Color.Red, minorColor = Color.Blue };
            pairNumber = GetPair.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}", testPair2, pairNumber);
            Debug.Assert(pairNumber == 6);
        }
    }
}
