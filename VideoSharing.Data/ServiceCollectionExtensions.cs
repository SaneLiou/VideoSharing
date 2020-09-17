using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using VideoSharing.Data.Context;
using Microsoft.Extensions.Configuration;
using VideoSharing.Data.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace VideoSharing.Data
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterDataServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<VideoSharingContext>(o => o.UseSqlServer(configuration.GetConnectionString("VideoSharingDB")));
            return services;
        }

        public static IServiceCollection AddIdentityToProject(this IServiceCollection services)
        {
            services.AddIdentity<User, IdentityRole>(opt =>
            {
                opt.Password.RequiredLength = 7;
                opt.Password.RequireDigit = false;
                opt.Password.RequireUppercase= false;

            }
                ).AddEntityFrameworkStores<VideoSharingContext>();
            return services;
        }


    }
}
