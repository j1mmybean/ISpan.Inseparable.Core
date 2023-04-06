using System;
using System.Collections.Generic;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class TSeat
    {
        public TSeat()
        {
            TTicketOrderDetails = new HashSet<TTicketOrderDetail>();
        }

        public int FSeatId { get; set; }
        public string FSeatRow { get; set; } = null!;
        public int FSeatColumn { get; set; }

        public virtual ICollection<TTicketOrderDetail> TTicketOrderDetails { get; set; }
    }
}
