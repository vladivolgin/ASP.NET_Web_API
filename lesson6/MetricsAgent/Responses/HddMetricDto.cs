﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsAgent
{
    public class HddMetricDto
    {
        public TimeSpan Time { get; set; }
        public long Value { get; set; }
        public int Id { get; set; }
    }
}
