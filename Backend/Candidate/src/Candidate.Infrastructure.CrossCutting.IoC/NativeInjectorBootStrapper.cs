using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Candidate.Infrastructure.CrossCutting.IoC
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }
    }
}
