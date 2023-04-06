using System;
using System.Collections.Generic;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class TMovieActorDetail
    {
        public int FSerialNumber { get; set; }
        public int FActorId { get; set; }
        public int FMovieId { get; set; }

        public virtual TActor FActor { get; set; } = null!;
        public virtual TMovie FMovie { get; set; } = null!;
    }
}
