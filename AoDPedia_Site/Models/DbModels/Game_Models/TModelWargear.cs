using System;
using System.Collections.Generic;

#nullable disable

namespace AoDPedia_Site
{
    public partial class TModelWargear
    {
        public int Id { get; set; }
        public Guid? ModelId { get; set; }
        public Guid? WargearId { get; set; }
    }
}
