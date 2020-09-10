using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using VideoSharing.Data.Context;
using Microsoft.Extensions.Configuration;

namespace VideoSharing.Data
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterDataServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<VideoSharingContext>(o => o.UseSqlServer(configuration.GetConnectionString("VideoSharingDB")));
            return services;
        }
    }
}
