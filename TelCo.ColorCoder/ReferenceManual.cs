using System;
using System.Diagnostics;

namespace TelCo.ColorCoder
{
    
    public class ReferenceManual
    {
        private static readonly int maj_size = PairsDataModel.colorMapMajor.Length;
        private static readonly int min_size = PairsDataModel.colorMapMinor.Length;

        //public static void Manual(Action obj)
        //{
        //    obj.Invoke();
        //}
        public static void PrintManual(IPrint printAddress)
        {
            int pair_no = 1;
            for (int i=0; i<maj_size; ++i)
                for(int j=0; j<min_size; ++j)
                {
                    //Debug.Assert(obj.Invoke() == )

                    printAddress.PrintLine($"Major-color : " + PairsDataModel.colorMapMajor[i] +", Minor-color : " +PairsDataModel.colorMapMinor[j] + ",Pair : "+pair_no);
                    pair_no++;
                }

        }
    }
}
