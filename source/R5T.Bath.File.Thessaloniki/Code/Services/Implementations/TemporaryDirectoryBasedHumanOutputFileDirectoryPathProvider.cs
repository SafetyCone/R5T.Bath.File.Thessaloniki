using System;

using R5T.Bath.File.Default;
using R5T.Thessaloniki;using R5T.T0064;


namespace R5T.Bath.File.Thessaloniki
{[ServiceImplementationMarker]
    public class TemporaryDirectoryBasedHumanOutputFileDirectoryPathProvider : IHumanOutputFileDirectoryPathProvider,IServiceImplementation
    {
        private ITemporaryDirectoryPathProvider TemporaryDirectoryPathProvider { get; }


        public TemporaryDirectoryBasedHumanOutputFileDirectoryPathProvider(ITemporaryDirectoryPathProvider temporaryDirectoryPathProvider)
        {
            this.TemporaryDirectoryPathProvider = temporaryDirectoryPathProvider;
        }

        public string GetHumanOutputFileDirectoryPath()
        {
            var humanOutputFileDirectoryPath = this.TemporaryDirectoryPathProvider.GetTemporaryDirectoryPath();
            return humanOutputFileDirectoryPath;
        }
    }
}
