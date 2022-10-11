using System;

using R5T.T0132;


namespace R5T.F0057
{
	[FunctionalityMarker]
	public partial interface IRepositoryDirectoryNameOperator : IFunctionalityMarker
	{
		public string GetRepositoryOwnerDirectoryName(string repositoryOwnerName)
		{
			// The directory name is just the name.
			var output = repositoryOwnerName;
			return output;
		}

		public string GetRepositoryDirectoryName(string repositoryName)
		{
			// The directory name is just the name.
			var output = repositoryName;
			return output;
		}
	}
}