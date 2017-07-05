using System;
using System.Collections.Generic;
using System.Text;

namespace FootballStats.Core
{
    public class StatQueryResult
    {
        public string SubjectName { get; set; }
        public IEnumerable<FootballStat> Stats { get; set; }
    }
}
