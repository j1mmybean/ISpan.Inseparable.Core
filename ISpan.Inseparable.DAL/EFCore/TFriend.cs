using System;
using System.Collections.Generic;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class TFriend
    {
        public int FId { get; set; }
        public int FMemberId { get; set; }
        public int FFriendNo { get; set; }
        /// <summary>
        /// 好友的ID
        /// </summary>
        public int FFriendId { get; set; }
        /// <summary>
        /// 成為好友的時間
        /// </summary>
        public string FFriendDateTime { get; set; } = null!;

        public virtual TMember FMember { get; set; } = null!;
    }
}
