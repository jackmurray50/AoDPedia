using System;
using System.Collections.Generic;

#nullable disable

namespace AoDPedia_Site
{
    public partial class TUnitCompositionWeapon
    {
        public int Id { get; set; }
        public Guid? UnitId { get; set; }
        public Guid? WeaponId { get; set; }
        public int? Count { get; set; }
    }
}
