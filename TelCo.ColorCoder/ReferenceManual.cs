using System;

namespace TelCo.ColorCoder
{
    public class ReferenceManual
    {
        public static void PrintManual()
        {
        int pair_no = 1;
            int maj_size = PairsDataModel.colorMapMajor.Length  ;
            int min_size = PairsDataModel.colorMapMajor.Length;
            for(int i=0; i<maj_size; ++i)
                for(int j=0; j<min_size; ++j)
                {
                Console.WriteLine("Major-color : {0}, Minor-color : {1}, Pair : {2}", PairsDataModel.colorMapMajor[i], PairsDataModel.colorMapMajor[j], pair_no);
                }

    }

}
}
