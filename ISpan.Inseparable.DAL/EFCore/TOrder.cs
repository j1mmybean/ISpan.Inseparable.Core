using System;
using System.Collections.Generic;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class TOrder
    {
        public TOrder()
        {
            TProductOrderDetails = new HashSet<TProductOrderDetail>();
            TTicketOrderDetails = new HashSet<TTicketOrderDetail>();
        }

        public int FOrderId { get; set; }
        public int FMemberId { get; set; }
        public int FCinemaId { get; set; }
        public DateTime FOrderDate { get; set; }
        public DateTime FModifiedTime { get; set; }
        public decimal FTotalMoney { get; set; }

        public virtual TCinema FCinema { get; set; } = null!;
        public virtual TMember FMember { get; set; } = null!;
        public virtual ICollection<TProductOrderDetail> TProductOrderDetails { get; set; }
        public virtual ICollection<TTicketOrderDetail> TTicketOrderDetails { get; set; }
    }
}
