using System;
using System.Collections.Generic;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class TMovieKeywordDetail
    {
        public int FSerialNumber { get; set; }
        public int FMovieId { get; set; }
        public int FKeywordId { get; set; }

        public virtual TKeyword FKeyword { get; set; } = null!;
        public virtual TMovie FMovie { get; set; } = null!;
    }
}
