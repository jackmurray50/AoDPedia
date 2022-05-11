using System;
using System.Collections.Generic;

#nullable disable

namespace AoDPedia_Site
{
    public partial class TUnitOptionWargear
    {
        public Guid Id { get; set; }
        public Guid? UnitId { get; set; }
        public Guid? WargearId { get; set; }
        public int? ModelsPerWargear { get; set; }
        public bool? IsExchange { get; set; }
        public int? Cost { get; set; }
    }
}
