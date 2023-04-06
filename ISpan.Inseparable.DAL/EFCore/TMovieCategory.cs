using System;
using System.Collections.Generic;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class TMovieCategory
    {
        public TMovieCategory()
        {
            TMemberFavoriteMovieCategories = new HashSet<TMemberFavoriteMovieCategory>();
            TMovieCategoryDetails = new HashSet<TMovieCategoryDetail>();
        }

        public int FMovieCategoryId { get; set; }
        public string FMovieCategoryName { get; set; } = null!;

        public virtual ICollection<TMemberFavoriteMovieCategory> TMemberFavoriteMovieCategories { get; set; }
        public virtual ICollection<TMovieCategoryDetail> TMovieCategoryDetails { get; set; }
    }
}
