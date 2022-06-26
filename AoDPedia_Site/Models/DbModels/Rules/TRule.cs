using System;
using System.Collections.Generic;

#nullable disable

namespace AoDPedia_Site
{
    public partial class TRule
    {
        public Guid Id { get; set; }
        public Guid? RuleType { get; set; }
        public Guid? ParentId { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Fluff { get; set; }
        public Guid? SourceId { get; set; }
        public int? SourcePage { get; set; }
    }
}
