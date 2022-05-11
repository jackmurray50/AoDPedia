using System;
using System.Collections.Generic;

#nullable disable

namespace AoDPedia_Site
{
    public partial class TUnitOptionModel
    {
        public Guid Id { get; set; }
        public Guid? ModelId { get; set; }
        public int? Cost { get; set; }
        public int? Limit { get; set; }
        public bool? IsDedicatedTransport { get; set; }
        public int? MaxSquadSize { get; set; }
    }
}
