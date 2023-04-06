using System;
using System.Collections.Generic;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class TProductOrderDetail
    {
        public int FId { get; set; }
        public int FProductItemNo { get; set; }
        public int FOrderId { get; set; }
        public int FProductId { get; set; }
        public string FProductName { get; set; } = null!;
        public decimal FProductUnitprice { get; set; }
        public int FProductQty { get; set; }
        public decimal FProductDiscount { get; set; }
        public decimal FProductSubtotal { get; set; }

        public virtual TOrder FOrder { get; set; } = null!;
        public virtual TProduct FProduct { get; set; } = null!;
    }
}
