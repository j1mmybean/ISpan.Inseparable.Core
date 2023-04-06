using System;
using System.Collections.Generic;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class TDirector
    {
        public TDirector()
        {
            TMovieDirectorDetails = new HashSet<TMovieDirectorDetail>();
        }

        public int FDirectorId { get; set; }
        public string FDitectorName { get; set; } = null!;

        public virtual ICollection<TMovieDirectorDetail> TMovieDirectorDetails { get; set; }
    }
}
