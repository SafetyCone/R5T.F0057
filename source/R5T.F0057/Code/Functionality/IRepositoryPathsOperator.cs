using System;

using R5T.T0132;


namespace R5T.F0057
{
	[FunctionalityMarker]
	public partial interface IRepositoryPathsOperator : IFunctionalityMarker
	{
        public string Get_GitDirectoryPath(string repositoryDirectoryPath)
        {
            var gitDirectoryPath = Instances.PathOperator.Get_DirectoryPath(
                repositoryDirectoryPath,
                Instances.DirectoryNames.GitRepositoryDirectoryName);

            return gitDirectoryPath;
        }

        public string GetGitIgnoreFilePath(string repositoryDirectoryPath)
        {
            var gitIgnoreFilePath = Instances.PathOperator.Get_FilePath(
                repositoryDirectoryPath,
                Instances.FileNames.GitIgnore);

            return gitIgnoreFilePath;
        }

        public string GetLicenseFilePath(string repositoryDirectoryPath)
        {
            var licenseFilePath = Instances.PathOperator.Get_FilePath(
                repositoryDirectoryPath,
                Instances.FileNames.License);

            return licenseFilePath;
        }

        public string GetSourceDirectoryPath(string repositoryDirectoryPath)
        {
            var repositorySourceDirectoryPath = Instances.PathOperator.Get_DirectoryPath(
                repositoryDirectoryPath,
                Instances.DirectoryNames.RepositorySourceDirectoryName);

            return repositorySourceDirectoryPath;
        }
    }
}