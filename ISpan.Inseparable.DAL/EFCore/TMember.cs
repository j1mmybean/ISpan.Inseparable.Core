using System;
using System.Collections.Generic;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class TMember
    {
        public TMember()
        {
            TActivityParticipants = new HashSet<TActivityParticipant>();
            TArticles = new HashSet<TArticle>();
            TComments = new HashSet<TComment>();
            TFriends = new HashSet<TFriend>();
            TMemberFavoriteMovieCategories = new HashSet<TMemberFavoriteMovieCategory>();
            TMemberPoints = new HashSet<TMemberPoint>();
            TOrders = new HashSet<TOrder>();
        }

        public int FId { get; set; }
        public string FMemberId { get; set; } = null!;
        /// <summary>
        /// 姓氏
        /// </summary>
        public string FLastName { get; set; } = null!;
        /// <summary>
        /// 名字
        /// </summary>
        public string FFirstName { get; set; } = null!;
        public string FEmail { get; set; } = null!;
        /// <summary>
        /// 密碼
        /// </summary>
        public string FPasswordHash { get; set; } = null!;
        public string FPasswordSalt { get; set; } = null!;
        public string? FDateOfBirth { get; set; }
        public int? FGenderId { get; set; }
        /// <summary>
        /// 手機號碼
        /// </summary>
        public string? FCellphone { get; set; }
        public string? FAddress { get; set; }
        public int? FAreaId { get; set; }
        public string? FPhotoPath { get; set; }
        /// <summary>
        /// 個人簡介
        /// </summary>
        public string? FIntroduction { get; set; }
        public int? FTotalMemberPoint { get; set; }
        /// <summary>
        /// 註冊時間
        /// </summary>
        public string? FSignUpTime { get; set; }

        public virtual TArea? FArea { get; set; }
        public virtual TGender? FGender { get; set; }
        public virtual ICollection<TActivityParticipant> TActivityParticipants { get; set; }
        public virtual ICollection<TArticle> TArticles { get; set; }
        public virtual ICollection<TComment> TComments { get; set; }
        public virtual ICollection<TFriend> TFriends { get; set; }
        public virtual ICollection<TMemberFavoriteMovieCategory> TMemberFavoriteMovieCategories { get; set; }
        public virtual ICollection<TMemberPoint> TMemberPoints { get; set; }
        public virtual ICollection<TOrder> TOrders { get; set; }
    }
}
