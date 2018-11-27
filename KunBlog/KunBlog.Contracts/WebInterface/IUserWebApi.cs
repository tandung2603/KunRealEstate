using KunBlog.Contracts.Dto;
using System.Collections.Generic;

namespace KunBlog.Contracts.WebInterface
{
    public interface IUserWebApi : IKunBlogWebApi
    {
        UserProfileDto Get(string userName);

        List<UserProfileDto> GetAll();
    }
}
