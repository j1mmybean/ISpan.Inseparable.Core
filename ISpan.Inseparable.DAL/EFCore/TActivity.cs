using System;
using System.Collections.Generic;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class TActivity
    {
        public TActivity()
        {
            TActivityParticipants = new HashSet<TActivityParticipant>();
        }

        public int FId { get; set; }
        public string FActivityId { get; set; } = null!;
        public string FActivityTitle { get; set; } = null!;
        public string FDateTime { get; set; } = null!;
        public int FmaxParticipants { get; set; }
        public string? FDescription { get; set; }
        public string? FCreateTime { get; set; }

        public virtual ICollection<TActivityParticipant> TActivityParticipants { get; set; }
    }
}
