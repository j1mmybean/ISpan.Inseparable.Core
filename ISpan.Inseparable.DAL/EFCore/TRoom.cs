using System;
using System.Collections.Generic;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class TRoom
    {
        public TRoom()
        {
            TSessions = new HashSet<TSession>();
            TTicketOrderDetails = new HashSet<TTicketOrderDetail>();
        }

        public int FRoomId { get; set; }
        public int FCinemaId { get; set; }
        public string FRoomName { get; set; } = null!;

        public virtual TCinema FCinema { get; set; } = null!;
        public virtual ICollection<TSession> TSessions { get; set; }
        public virtual ICollection<TTicketOrderDetail> TTicketOrderDetails { get; set; }
    }
}
