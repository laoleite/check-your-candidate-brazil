using Candidate.Infrastructure.CrossCutting.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Candidate.Api.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            NativeInjectorBootStrapper.RegisterServices(services);
        }
    }
}
