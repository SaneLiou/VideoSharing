using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using VideoSharing.Repository.Interfaces;
using VideoSharing.Repository.Repositories;


namespace VideoSharing.Repository
{
    public static class ServiceExtensions
    {
        public static IServiceCollection ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            return services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}
