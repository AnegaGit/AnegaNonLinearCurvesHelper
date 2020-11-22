using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnegaNonLinearCurvesHelper
{
    /// <summary>
    /// Static fuctions
    /// </summary>
    static class GlobalFunc
    {
        static Random random = new Random();

        /// <summary>
        /// Guarantee min &lt;= value &lt;= max
        /// </summary>
        /// <returns>value, adapted if necessary</returns>
        public static int KeepInRange(int value, int min, int max)
        {
            if (value < min) value = min;
            if (value > max) value = max;
            return value;
        }
        public static double KeepInRange(double value, double min, double max)
        {
            if (value < min) value = min;
            if (value > max) value = max;
            return value;
        }

        /// <summary>
        /// First character in string to upper
        /// </summary>
        /// <example>"a nice function" => "A nice function"</example>
        public static string FirstToUpper(string value)
        {
            return value[0].ToString().ToUpper() + value.Substring(1);
        }

        /// <summary>
        /// Relative position of position to min in range min .. max
        /// </summary>
        /// <returns>0 .. 1</returns>
        public static double ProportionFromPosition(double position, double min, double max)
        {
            if (max > min)
            {
                KeepInRange(position, min, max);
            }
            else
            {
                KeepInRange(position, max, min);
            }
            return (position - min) / (max - min);
        }

        /// <summary>
        /// Position in min .. max according proportion
        /// </summary>
        /// <param name="proportion">0 .. 1</param>
        /// <remark>If min &gt; max proportion is distance to higher value</remark>
        /// <returns>min .. max</returns>
        public static double PositionFromProportion(double proportion, double min, double max)
        {
            KeepInRange(proportion, 0d, 1d);
            return min + (max - min) * proportion;
        }
    }

    public static class IListExtensions
    {
        static Random random = new Random();

        /// <summary>
        /// Shuffles the element order of the specified list.
        /// </summary>
        public static void Shuffle<T>(this IList<T> ts)
        {
            var count = ts.Count;
            var last = count - 1;
            for (var i = 0; i < last; ++i)
            {
                var r = random.Next(i, count);
                var tmp = ts[i];
                ts[i] = ts[r];
                ts[r] = tmp;
            }
        }
    }

}
