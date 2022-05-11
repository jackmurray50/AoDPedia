using System;
using System.Collections.Generic;

#nullable disable

namespace AoDPedia_Site
{
    public partial class TWeapon
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Range { get; set; }
        public string Strength { get; set; }
        public string Ap { get; set; }
        public string Type { get; set; }
        public string SpecialRules { get; set; }
    }
}
