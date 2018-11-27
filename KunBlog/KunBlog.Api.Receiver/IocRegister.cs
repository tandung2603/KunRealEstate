using KunBlog.Business;
using KunBlog.Contracts.ServiceInterface;
using Microsoft.Extensions.DependencyInjection;

namespace KunBlog.Api.Receiver
{
    public class IocRegister
    {
        public static void StartUpIocRegister(IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IPropertyService, PropertyService>();
        }
    }
}
