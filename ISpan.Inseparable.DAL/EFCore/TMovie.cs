using System;
using System.Collections.Generic;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class TMovie
    {
        public TMovie()
        {
            TMovieActorDetails = new HashSet<TMovieActorDetail>();
            TMovieCategoryDetails = new HashSet<TMovieCategoryDetail>();
            TMovieDirectorDetails = new HashSet<TMovieDirectorDetail>();
            TMovieKeywordDetails = new HashSet<TMovieKeywordDetail>();
            TSessions = new HashSet<TSession>();
            TTicketOrderDetails = new HashSet<TTicketOrderDetail>();
        }

        public int FMovieId { get; set; }
        public string FMovieName { get; set; } = null!;
        public string FMovieIntroduction { get; set; } = null!;
        public int FMovieLevelId { get; set; }
        public DateTime FMovieOnDate { get; set; }
        public DateTime? FMovieOffDate { get; set; }
        public int FMovieLength { get; set; }
        public string FMovieImagePath { get; set; } = null!;
        public int FMovieScore { get; set; }

        public virtual TMovieLevel FMovieLevel { get; set; } = null!;
        public virtual ICollection<TMovieActorDetail> TMovieActorDetails { get; set; }
        public virtual ICollection<TMovieCategoryDetail> TMovieCategoryDetails { get; set; }
        public virtual ICollection<TMovieDirectorDetail> TMovieDirectorDetails { get; set; }
        public virtual ICollection<TMovieKeywordDetail> TMovieKeywordDetails { get; set; }
        public virtual ICollection<TSession> TSessions { get; set; }
        public virtual ICollection<TTicketOrderDetail> TTicketOrderDetails { get; set; }
    }
}
