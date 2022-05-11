using System;
using System.Collections.Generic;

#nullable disable

namespace AoDPedia_Site
{
    public partial class TModelType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? RuleId { get; set; }
    }
}
