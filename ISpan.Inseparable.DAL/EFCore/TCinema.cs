using System;
using System.Collections.Generic;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class TCinema
    {
        public TCinema()
        {
            TOrders = new HashSet<TOrder>();
            TProducts = new HashSet<TProduct>();
            TRooms = new HashSet<TRoom>();
            TSessions = new HashSet<TSession>();
        }

        public int FCinemaId { get; set; }
        public string FCinemaName { get; set; } = null!;
        public string FCinemaRegion { get; set; } = null!;
        public string FCinemaAddress { get; set; } = null!;
        public string FCinemaTel { get; set; } = null!;

        public virtual ICollection<TOrder> TOrders { get; set; }
        public virtual ICollection<TProduct> TProducts { get; set; }
        public virtual ICollection<TRoom> TRooms { get; set; }
        public virtual ICollection<TSession> TSessions { get; set; }
    }
}
