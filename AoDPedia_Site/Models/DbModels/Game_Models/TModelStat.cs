using System;
using System.Collections.Generic;

#nullable disable

namespace AoDPedia_Site
{
    public partial class TModelStat
    {
        public int Id { get; set; }
        public Guid? ModelId { get; set; }
        public Guid? StatId { get; set; }
        public int? Value { get; set; }
    }
}
