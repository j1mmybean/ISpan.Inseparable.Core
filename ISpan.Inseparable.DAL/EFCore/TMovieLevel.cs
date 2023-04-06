using System;
using System.Collections.Generic;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class TMovieLevel
    {
        public TMovieLevel()
        {
            TMovies = new HashSet<TMovie>();
        }

        public int FLevelId { get; set; }
        public string FLevelName { get; set; } = null!;

        public virtual ICollection<TMovie> TMovies { get; set; }
    }
}
