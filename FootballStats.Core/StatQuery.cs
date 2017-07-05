using System;
using System.Collections.Generic;

namespace FootballStats.Core
{
    public class StatQuery
    {
        public string Subject { get; set; }
        public IEnumerable<StatType> StatTypes { get; set; }
        public GroupingType Grouping { get; set; }
        public IEnumerable<int> Seasons { get; set; }
    }
}

