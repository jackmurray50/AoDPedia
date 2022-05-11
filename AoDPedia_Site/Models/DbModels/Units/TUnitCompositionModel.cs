using System;
using System.Collections.Generic;

#nullable disable

namespace AoDPedia_Site
{
    public partial class TUnitCompositionModel
    {
        public Guid Id { get; set; }
        public Guid? UnitId { get; set; }
        public Guid? ModelId { get; set; }
        public int? Count { get; set; }
    }
}
