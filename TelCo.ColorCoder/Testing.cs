using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class Testing
    {
        public static void ManualTesting()
        {
            int pair_no = 1;
            for (int i = 0; i < PairsDataModel.colorMapMajor.Length; ++i)
            {
                for (int j = 0; j < PairsDataModel.colorMapMajor.Length; ++j)
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

        private static void Main(string[] args)
        {
            ManualTesting();

            //ManualDelegate _manualPrintingAddress = new ManualDelegate(ReferenceManual.PrintManual);
            ReferenceManual.PrintManual(new PrintOnConsole());
            //ManualDelegate _manualTestingAddress = new ManualDelegate(ReferenceManual.ManualTesting);
            //ReferenceManual.Manual(ReferenceManual.ManualTesting);

            PrintOnConsoleTest testPrintonConsole = new PrintOnConsoleTest();
            ReferenceManual.PrintManual(testPrintonConsole);
            Debug.Assert(testPrintonConsole.timesPrintOnConsoleCalled == PairsDataModel.colorMapMajor.Length*PairsDataModel.colorMapMinor.Length);


        }
    }
}