using System;
using System.Collections.Generic;

#nullable disable

namespace AoDPedia_Site
{
    public partial class TModelWeapon
    {
        public Guid Id { get; set; }
        public Guid? ModelId { get; set; }
        public Guid? WeaponId { get; set; }
    }
}
