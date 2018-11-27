using KunBlog.Contracts.Dto;
using KunBlog.Contracts.ServiceInterface;
using KunBlog.Contracts.WebInterface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KunBlog.Web.Controllers
{
    public class PropertyController : BaseController
    {
        private readonly IPropertyService _propertyService;

        public PropertyController(IConfiguration configuration, IPropertyService propertyService) : base(configuration)
        {
            _propertyService = propertyService;
        }

        public async Task<IActionResult> Index()
        {
            List<PropertyDto> properties = await _propertyService.GetListProperties(string.Empty);

            return View(properties);
        }

        [HttpPost]
        public async Task<JsonResult> GetListPropertiesAsync()
        {
            List<PropertyDto> properties = await _propertyService.GetListProperties(string.Empty);

            return Json(new {
                data = properties
            });
        }
    }
}