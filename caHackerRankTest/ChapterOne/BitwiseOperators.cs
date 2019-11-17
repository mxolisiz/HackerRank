using System;
using System.Diagnostics;

namespace caMcsdPractice.ChapterOne
{
    public class BitwiseOperators
    {
        public void UnaryVariantOperator()
        {
            bool isBest = false;
            bool isValue = true;
            if (isBest ^ isValue)//if one of the two is true
                Debug.WriteLine($"isBest:{isBest} & isValue:{isValue}");
            if (isBest && isValue)
                Debug.WriteLine($"isBest:{isBest} && isValue:{isValue}");

            short mxolisi = ~3;
            bool val = false;
            Debug.WriteLine(Convert.ToString(mxolisi, 2));//1111111111111100

        }
    }
}
