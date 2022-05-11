using System;
using System.Collections.Generic;

#nullable disable

namespace AoDPedia_Site
{
    public partial class TUnitOptionWeapon
    {
        public Guid Id { get; set; }
        public Guid? UnitId { get; set; }
        public Guid? WeaponId { get; set; }
        public int? ModelsPerWeapon { get; set; }
        public bool? IsExchange { get; set; }
        public int? Cost { get; set; }
    }
}
