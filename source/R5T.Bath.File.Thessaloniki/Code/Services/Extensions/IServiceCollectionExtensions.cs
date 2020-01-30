using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Bath.File.Default;
using R5T.Dacia;
using R5T.Thessaloniki;


namespace R5T.Bath.File.Thessaloniki
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="TemporaryDirectoryBasedHumanOutputFileDirectoryPathProvider"/> implementation of <see cref="IHumanOutputFileDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddTemporaryDirectoryBasedHumanOutputFileDirectoryPathProvider(this IServiceCollection services,
            ServiceAction<ITemporaryDirectoryPathProvider> addTemporaryDirectoryPathProvider)
        {
            services
                .AddSingleton<IHumanOutputFileDirectoryPathProvider, TemporaryDirectoryBasedHumanOutputFileDirectoryPathProvider>()
                .RunServiceAction(addTemporaryDirectoryPathProvider)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="TemporaryDirectoryBasedHumanOutputFileDirectoryPathProvider"/> implementation of <see cref="IHumanOutputFileDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IHumanOutputFileDirectoryPathProvider> AddTemporaryDirectoryBasedHumanOutputFileDirectoryPathProviderAction(this IServiceCollection services,
            ServiceAction<ITemporaryDirectoryPathProvider> addTemporaryDirectoryPathProvider)
        {
            var serviceAction = new ServiceAction<IHumanOutputFileDirectoryPathProvider>(() => services.AddTemporaryDirectoryBasedHumanOutputFileDirectoryPathProvider(
                addTemporaryDirectoryPathProvider));
            return serviceAction;
        }
    }
}
