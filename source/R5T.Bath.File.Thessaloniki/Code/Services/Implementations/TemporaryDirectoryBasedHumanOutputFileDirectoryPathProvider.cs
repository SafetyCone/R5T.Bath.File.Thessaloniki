using System;

using R5T.Bath.File.Default;
using R5T.Thessaloniki;


namespace R5T.Bath.File.Thessaloniki
{
    public class TemporaryDirectoryBasedHumanOutputFileDirectoryPathProvider : IHumanOutputFileDirectoryPathProvider
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
