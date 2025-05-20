using Microsoft.Extensions.DependencyInjection;
using Softbreak.OnionArch.APPLICATION.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softbreak.OnionArch.APPLICATION.DependencyResolvers
{
    public static class ApplicationMappingServiceInjection
    {
        public static IServiceCollection AddApplicationMapperService(this IServiceCollection services)
        {
            return services.AddAutoMapper(typeof(MapProfile));
        } 
    }
}
