﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsManager.DAL
{
    public class CpuMetricsCreateRequest
    {
        public TimeSpan Time { get; set; }
        public int Value { get; set; }
    }
}
