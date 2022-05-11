using System;
using System.Collections.Generic;

#nullable disable

namespace AoDPedia_Site
{
    public partial class TRuleCategory
    {
        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        public string Name { get; set; }
    }
}
