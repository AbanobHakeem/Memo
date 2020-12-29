﻿using System;
using System.Collections.Generic;

  

namespace MemoSystem.Models
{
    public partial class AspNetUser
    {
        public AspNetUser()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaim>();
            AspNetUserLogins = new HashSet<AspNetUserLogin>();
            AspNetUserRoles = new HashSet<AspNetUserRole>();
            AspNetUserTokens = new HashSet<AspNetUserToken>();
            TbComments = new HashSet<TbComment>();
            TbPosts = new HashSet<TbPost>();
            TbRates = new HashSet<TbRate>();
            TbReaderBooks = new HashSet<TbReaderBook>();
        }

        public string Id { get; set; }
        public string FullName { get; set; }
        public string Quotes { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }

        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual ICollection<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual ICollection<TbComment> TbComments { get; set; }
        public virtual ICollection<TbPost> TbPosts { get; set; }
        public virtual ICollection<TbRate> TbRates { get; set; }
        public virtual ICollection<TbReaderBook> TbReaderBooks { get; set; }
    }
}
