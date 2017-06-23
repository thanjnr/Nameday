using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nameday
{
    public class NameDayModel
    {
        public int Month { get; }
        public int Day { get; }
        public IEnumerable<string> Names { get; }

        public NameDayModel(int month, int day, IEnumerable<string> names)
        {
            Month = month;
            Day = day;
            Names = names;
        }

        public string NameAsString => string.Join(",", Names);
    }
}
