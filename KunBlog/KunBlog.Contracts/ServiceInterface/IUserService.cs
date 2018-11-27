using KunBlog.Contracts.Dto;
using System.Collections.Generic;

namespace KunBlog.Contracts.ServiceInterface
{
    public interface IUserService : IKunBlogService
    {
        UserProfileDto Get(string userName);

        List<UserProfileDto> GetAll();

        SaveResultDto AddUserProfile(UserProfileDto user);
    }
}
