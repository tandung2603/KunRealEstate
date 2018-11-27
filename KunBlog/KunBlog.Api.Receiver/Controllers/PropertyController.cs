using System.Collections.Generic;
using KunBlog.Contracts.Dto;
using KunBlog.Contracts.ServiceInterface;
using KunBlog.Contracts.WebInterface;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace KunBlog.Api.Receiver.Controllers
{
    [Route("api/Property")]
    [EnableCors("AllowAllOrigins")]
    //[Authorize(AuthenticationSchemes=JwtBearerDefaults.AuthenticationScheme)]
    public class PropertyController : Controller, IPropertyWebApi
    {
        private IPropertyService PropertyService;

        public PropertyController(IPropertyService propertyService)
        {
            PropertyService = propertyService;
        }

        public async System.Threading.Tasks.Task<List<PropertyDto>> GetListProperties(string search)
        {
            return await PropertyService.GetListProperties(search);
        }
    }
}