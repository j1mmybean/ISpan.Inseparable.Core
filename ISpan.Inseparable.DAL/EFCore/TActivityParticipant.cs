using System;
using System.Collections.Generic;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class TActivityParticipant
    {
        public int FId { get; set; }
        public int FActivityId { get; set; }
        public int? FParticipantNo { get; set; }
        public int FMemberId { get; set; }
        public string? FRegisteredTime { get; set; }

        public virtual TActivity FActivity { get; set; } = null!;
        public virtual TMember FMember { get; set; } = null!;
    }
}
