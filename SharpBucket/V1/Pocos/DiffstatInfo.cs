﻿using System;

namespace SharpBucket.V1.Pocos
{
    [Obsolete("Bitbucket Cloud v1 APIs are deprecated")]
    public class DiffstatInfo
    {
        public string type { get; set; }
        public string file { get; set; }
        public Diffstat diffstat { get; set; }
    }
}