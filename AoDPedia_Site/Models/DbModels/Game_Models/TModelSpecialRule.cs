using System;
using System.Collections.Generic;

#nullable disable

namespace AoDPedia_Site
{
    public partial class TModelSpecialRule
    {
        public int Id { get; set; }
        public Guid? ModelId { get; set; }
        public Guid? SpecialRuleId { get; set; }
    }
}
