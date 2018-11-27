using KunBlog.Business;
using KunBlog.Contracts.ServiceInterface;
using Microsoft.Extensions.DependencyInjection;

namespace KunBlog.Web
{
    public class IocRegister
    {
        public static void StartUpIocRegister(IServiceCollection services)
        {
            //services.AddTransient<IUserWebApi, UserController>();
            //services.AddTransient<IPropertyWebApi, PropertyController>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IPropertyService, PropertyService>();
        }
    }
}
