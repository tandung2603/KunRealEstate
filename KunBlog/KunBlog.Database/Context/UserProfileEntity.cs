using System;

namespace KunBlog.Database.Context
{
    public class UserProfileEntity : BaseEntity
    {
        public string Name { get; set; }

        public string Role { get; set; }

        public string Email { get; set; }

        public string AdminNote { get; set; }

        public Guid IdentityUserId { get; set; }
    }
}
