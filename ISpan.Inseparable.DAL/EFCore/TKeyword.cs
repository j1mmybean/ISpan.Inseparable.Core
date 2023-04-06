using System;
using System.Collections.Generic;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class TKeyword
    {
        public TKeyword()
        {
            TArticleKeywordDetails = new HashSet<TArticleKeywordDetail>();
            TMovieKeywordDetails = new HashSet<TMovieKeywordDetail>();
        }

        public int FKeywordId { get; set; }
        public string FKeywordName { get; set; } = null!;

        public virtual ICollection<TArticleKeywordDetail> TArticleKeywordDetails { get; set; }
        public virtual ICollection<TMovieKeywordDetail> TMovieKeywordDetails { get; set; }
    }
}
