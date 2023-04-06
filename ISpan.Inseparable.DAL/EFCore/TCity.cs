using System;
using System.Collections.Generic;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class TCity
    {
        public TCity()
        {
            TAreas = new HashSet<TArea>();
        }

        public int FCityId { get; set; }
        public string FCityName { get; set; } = null!;

        public virtual ICollection<TArea> TAreas { get; set; }
    }
}
