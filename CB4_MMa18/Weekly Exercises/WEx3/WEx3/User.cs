using System;

namespace WEx3
{
    /// <summary>
    /// Describes a user.
    /// </summary>
    public class User
    {
        /// <summary>
        /// User id.
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// User display name.
        /// </summary>
        public string Username { get; set; }
    }
}
