using System;
using System.Collections.Generic;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class TSession
    {
        public TSession()
        {
            TTicketOrderDetails = new HashSet<TTicketOrderDetail>();
        }

        public int FSessionId { get; set; }
        public int FMovieId { get; set; }
        public int FRoomId { get; set; }
        public int FCinemaId { get; set; }
        public DateTime FSessionDate { get; set; }
        public TimeSpan FSessionTime { get; set; }
        public decimal? FTicketPrice { get; set; }

        public virtual TCinema FCinema { get; set; } = null!;
        public virtual TMovie FMovie { get; set; } = null!;
        public virtual TRoom FRoom { get; set; } = null!;
        public virtual ICollection<TTicketOrderDetail> TTicketOrderDetails { get; set; }
    }
}
