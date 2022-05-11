using System;
using System.Collections.Generic;

#nullable disable

namespace AoDPedia_Site
{
    public partial class TUnit
    {
        public Guid Id { get; set; }
        public Guid? Name { get; set; }
        public int? Cost { get; set; }
        public string Fluff { get; set; }
    }
}
