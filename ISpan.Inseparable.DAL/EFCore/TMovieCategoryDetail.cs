using System;
using System.Collections.Generic;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class TMovieCategoryDetail
    {
        public int FSerialNumber { get; set; }
        public int FMovieId { get; set; }
        public int FMovieCategoryId { get; set; }

        public virtual TMovie FMovie { get; set; } = null!;
        public virtual TMovieCategory FMovieCategory { get; set; } = null!;
    }
}
