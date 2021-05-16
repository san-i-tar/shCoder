using System;
using System.ComponentModel.DataAnnotations;

namespace shCoder.Data.Users
{
    public class UserLock
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        public DateTime DateTime { get; set; }
        public DateTime ExpireDateTime { get; set; }

        public UserLockType LockType { get; set; }
        public UserLockReason Reason { get; set; }
    }

    public enum UserLockReason
    {
        PasswordChanged,
        TwoFaDisabled
    }

    public enum UserLockType
    {
        Withdrawals
    }
}