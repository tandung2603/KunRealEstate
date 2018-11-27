using KunBlog.Contracts.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KunBlog.Contracts.WebInterface
{
    public interface IPropertyWebApi : IKunBlogWebApi
    {
        Task<List<PropertyDto>> GetListProperties(string search);
    }
}
