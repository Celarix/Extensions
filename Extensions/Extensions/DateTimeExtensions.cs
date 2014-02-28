using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class DateTimeExtensions
    {
        public static bool DatesEqual(this DateTime a, DateTime b)
        {
            return (a.Year == b.Year) &&
                   (a.Month == b.Month) &&
                   (a.Day == b.Day);
        }
    }
}
