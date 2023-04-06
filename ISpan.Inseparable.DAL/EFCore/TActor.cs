using System;
using System.Collections.Generic;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class TActor
    {
        public TActor()
        {
            TMovieActorDetails = new HashSet<TMovieActorDetail>();
        }

        public int FActorId { get; set; }
        public string FActorName { get; set; } = null!;

        public virtual ICollection<TMovieActorDetail> TMovieActorDetails { get; set; }
    }
}
