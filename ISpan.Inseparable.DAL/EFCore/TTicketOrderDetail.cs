using System;
using System.Collections.Generic;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class TTicketOrderDetail
    {
        public int FId { get; set; }
        public int FTicketItemNo { get; set; }
        public int FOrderId { get; set; }
        public int FMovieId { get; set; }
        public int FSessionId { get; set; }
        public int FSeatId { get; set; }
        public int FRoomId { get; set; }
        public decimal FTicketUnitprice { get; set; }
        public decimal FTicketDiscount { get; set; }
        public decimal FTicketSubtotal { get; set; }

        public virtual TMovie FMovie { get; set; } = null!;
        public virtual TOrder FOrder { get; set; } = null!;
        public virtual TRoom FRoom { get; set; } = null!;
        public virtual TSeat FSeat { get; set; } = null!;
        public virtual TSession FSession { get; set; } = null!;
    }
}
