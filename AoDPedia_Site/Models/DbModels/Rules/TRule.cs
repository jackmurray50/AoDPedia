using System;
using System.Collections.Generic;

#nullable disable

namespace AoDPedia_Site
{
    public partial class TRule
    {
        public Guid Id { get; set; }
        public string RuleType { get; set; }
        public Guid? RuleCategoryId { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Fluff { get; set; }
    }
}
