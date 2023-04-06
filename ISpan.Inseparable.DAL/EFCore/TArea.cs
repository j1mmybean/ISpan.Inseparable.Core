using System;
using System.Collections.Generic;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class TArea
    {
        public TArea()
        {
            TMembers = new HashSet<TMember>();
        }

        public int FAreaId { get; set; }
        public string FName { get; set; } = null!;
        public int FCityId { get; set; }

        public virtual TCity FCity { get; set; } = null!;
        public virtual ICollection<TMember> TMembers { get; set; }
    }
}
