using System;
using System.Collections.Generic;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class TAdministrator
    {
        public int FId { get; set; }
        public string FAdministratorId { get; set; } = null!;
        public string FLastName { get; set; } = null!;
        public string FFirstName { get; set; } = null!;
        public string FEmail { get; set; } = null!;
        public string FPasswordHash { get; set; } = null!;
        public string FPasswordSalt { get; set; } = null!;
        public string? FSignUpTime { get; set; }
    }
}
