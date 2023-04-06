using System;
using System.Collections.Generic;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class TComment
    {
        public int FCommentId { get; set; }
        public int FArticleId { get; set; }
        public int FItemNumber { get; set; }
        public int FMemberId { get; set; }
        public DateTime FCommentPostingDate { get; set; }
        public int FCommentLikes { get; set; }
        public string FCommentContent { get; set; } = null!;

        public virtual TArticle FArticle { get; set; } = null!;
        public virtual TMember FMember { get; set; } = null!;
    }
}
