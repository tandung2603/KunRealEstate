using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.Filters;

namespace KunBlog.Web.Controllers
{
    [Authorize]
    public abstract class BaseController : Controller
    {
        private IConfiguration AppSettings { get; set; }

        protected BaseController(IConfiguration configuration)
        {
            AppSettings = configuration;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            ViewData["IsDebugging"] = IsDebugging;
        }

        private bool? _isDebugging = null;

        internal bool IsDebugging
        {
            get
            {
                if (_isDebugging != null)
                    return _isDebugging.Value;

                bool debugValue;
                bool.TryParse(AppSettings["IsDebug"], out debugValue);
                _isDebugging = debugValue;
                return _isDebugging.Value;
            }
        }

    }
}
