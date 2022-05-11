using System;
using System.Collections.Generic;

#nullable disable

namespace AoDPedia_Site
{
    public partial class TUnitCompositionWargear
    {
        public int Id { get; set; }
        public Guid? UnitId { get; set; }
        public Guid? WargearId { get; set; }
        public int? Count { get; set; }
    }
}
