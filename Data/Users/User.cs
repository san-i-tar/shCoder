using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace shCoder.Data.Users
{
    public class User : IdentityUser
    {
        public User()
        {
            UserLocks = new HashSet<UserLock>();
        }

        public int Year { get; set; }        

        public DateTime RegisterDateTime { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public VerifyLevel VerifyLevel { get; set; }

        [MaxLength(250)]
        public string TimeZoneId { get; set; } = "Russian Standard Time";

        [MaxLength(10)] public string Lang { get; set; } = "ru";

        public ICollection<UserLock> UserLocks { get; set; }
    }

    public enum VerifyLevel
    {
        Incognito,
        Personal
    }
}
