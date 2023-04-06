using System;
using System.Collections.Generic;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class TArticle
    {
        public TArticle()
        {
            TArticleKeywordDetails = new HashSet<TArticleKeywordDetail>();
            TComments = new HashSet<TComment>();
        }

        public int FArticleId { get; set; }
        public string FArticleTitle { get; set; } = null!;
        public int FMemberId { get; set; }
        public int FArticleCategoryId { get; set; }
        public DateTime FArticlePostingDate { get; set; }
        public int FArticleLikes { get; set; }
        public int FArticleClicks { get; set; }
        public string FArticleContent { get; set; } = null!;

        public virtual TMember FMember { get; set; } = null!;
        public virtual ICollection<TArticleKeywordDetail> TArticleKeywordDetails { get; set; }
        public virtual ICollection<TComment> TComments { get; set; }
    }
}
