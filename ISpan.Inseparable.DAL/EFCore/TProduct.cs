using System;
using System.Collections.Generic;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class TProduct
    {
        public TProduct()
        {
            TProductOrderDetails = new HashSet<TProductOrderDetail>();
        }

        public int FProductId { get; set; }
        public string FProductName { get; set; } = null!;
        public int FProductCategoryId { get; set; }
        public decimal FProductUnitprice { get; set; }
        public int FProductStock { get; set; }
        public string? FProductPicturePath { get; set; }
        public int FCinemaId { get; set; }

        public virtual TCinema FCinema { get; set; } = null!;
        public virtual TProductCategory FProductCategory { get; set; } = null!;
        public virtual ICollection<TProductOrderDetail> TProductOrderDetails { get; set; }
    }
}
