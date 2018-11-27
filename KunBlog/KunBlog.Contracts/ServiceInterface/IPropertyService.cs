using KunBlog.Contracts.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KunBlog.Contracts.ServiceInterface
{
    public interface IPropertyService : IKunBlogService
    {
        Task<List<PropertyDto>> GetListProperties(string search);
    }
}
