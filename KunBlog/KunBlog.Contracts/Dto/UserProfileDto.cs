using System;

namespace KunBlog.Contracts.Dto
{
    public class UserProfileDto : BaseDto
    {
        public string Name { get; set; }

        public string Role { get; set; }

        public string Email { get; set; }

        public string AdminNote { get; set; }

        public Guid IdentityUserId { get; set; }
    }
}
