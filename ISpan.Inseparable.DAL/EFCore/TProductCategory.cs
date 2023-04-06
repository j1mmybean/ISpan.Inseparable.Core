using System;
using System.Collections.Generic;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class TProductCategory
    {
        public TProductCategory()
        {
            TProducts = new HashSet<TProduct>();
        }

        public int FProductCategoryId { get; set; }
        public string FProductCategoryName { get; set; } = null!;

        public virtual ICollection<TProduct> TProducts { get; set; }
    }
}
