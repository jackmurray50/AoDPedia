using System;
using System.Collections.Generic;

#nullable disable

namespace AoDPedia_Site
{
    public partial class TModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? Source { get; set; }
        public int? SourcePage { get; set; }
        public string Movement { get; set; }
        public string WeaponSkill { get; set; }
        public string BallisticSkill { get; set; }
        public string Strength { get; set; }
        public string Toughness { get; set; }
        public string AvFront { get; set; }
        public string AvSide { get; set; }
        public string AvRear { get; set; }
        public string Wounds { get; set; }
        public string HullPoints { get; set; }
        public string Initiative { get; set; }
        public string Attacks { get; set; }
        public string Leadership { get; set; }
        public string Save { get; set; }
    }
}
