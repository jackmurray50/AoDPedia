using System;
using System.Collections.Generic;

#nullable disable

namespace AoDPedia_Site
{
    public partial class TWarlordTrait
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Fluff { get; set; }
        public string Description { get; set; }
        public Guid? ArmyId { get; set; }
    }
}
