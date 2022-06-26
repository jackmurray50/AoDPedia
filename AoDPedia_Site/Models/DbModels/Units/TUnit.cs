﻿using System;
using System.Collections.Generic;

#nullable disable

namespace AoDPedia_Site
{
    public partial class TUnit
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int? Cost { get; set; }
        public string Role { get; set; }
        public string Fluff { get; set; }
        public Guid? Source { get; set; }
        public int? SourcePage { get; set; }
    }
}
