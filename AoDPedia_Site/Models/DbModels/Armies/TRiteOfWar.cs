using System;
using System.Collections.Generic;

#nullable disable

namespace AoDPedia_Site
{
    public partial class TRiteOfWar
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? ArmyId { get; set; }
        public string Fluff { get; set; }
        public string Benefits { get; set; }
        public string Limitations { get; set; }
    }
}
