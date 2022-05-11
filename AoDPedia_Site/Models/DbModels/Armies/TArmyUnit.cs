using System;
using System.Collections.Generic;

#nullable disable

namespace AoDPedia_Site
{
    public partial class TArmyUnit
    {
        public Guid Id { get; set; }
        public Guid? ArmyId { get; set; }
        public Guid? UnitId { get; set; }
    }
}
