using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAMSDB.Data
{
    public static class LinqHelper
    {

        public static double? WeightedAverage<T>(this IEnumerable<T> records, Func<T, double> value, Func<T, double> weight)
        {
            double weightedValueSum = records.Sum(x => value(x) * weight(x));
            double weightSum = records.Sum(x => weight(x));

            if (weightSum != 0)
                return Math.Round(weightedValueSum / weightSum, 2);
            else
                return null ;
             //   throw new DivideByZeroException("Your message here");
        }
    }

    
}
