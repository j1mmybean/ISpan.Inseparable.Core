using System;
using System.Collections.Generic;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class TMemberPoint
    {
        public int FId { get; set; }
        public int FMemberId { get; set; }
        public int FItemNo { get; set; }
        public int? FPointsAdded { get; set; }
        public int? FPointDeducted { get; set; }
        public string? FDescription { get; set; }
        public string FCreateTime { get; set; } = null!;

        public virtual TMember FMember { get; set; } = null!;
    }
}
