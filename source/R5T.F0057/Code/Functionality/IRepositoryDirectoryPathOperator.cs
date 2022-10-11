using System;

using R5T.T0132;


namespace R5T.F0057
{
	[FunctionalityMarker]
	public partial interface IRepositoryDirectoryPathOperator : IFunctionalityMarker
	{
		public string GetRepositoryDirectory(
			string repositoryOwnerName,
			string repositoryName)
		{
			var repositoryOwnerDirectoryName = Instances.RepositoryDirectoryNameOperator.GetRepositoryOwnerDirectoryName(repositoryOwnerName);
			var repositoryDirectoryName = Instances.RepositoryDirectoryNameOperator.GetRepositoryDirectoryName(repositoryName);

			var gitHubRepositoriesDirectoryPath = Instances.DirectoryPaths.GitHubRepositoriesDirectory;

			var output = Instances.PathOperator.GetDirectoryPath(
				gitHubRepositoriesDirectoryPath,
				repositoryOwnerDirectoryName,
				repositoryDirectoryName);

			return output;
		}
	}
}