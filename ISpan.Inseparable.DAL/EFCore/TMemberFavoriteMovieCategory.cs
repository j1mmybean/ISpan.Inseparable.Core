using System;
using System.Collections.Generic;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class TMemberFavoriteMovieCategory
    {
        public int FId { get; set; }
        public int FMemberId { get; set; }
        public int FMovieCategoryId { get; set; }

        public virtual TMember FMember { get; set; } = null!;
        public virtual TMovieCategory FMovieCategory { get; set; } = null!;
    }
}
