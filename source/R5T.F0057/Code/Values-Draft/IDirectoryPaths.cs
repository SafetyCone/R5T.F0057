using System;

using R5T.T0131;


namespace R5T.F0057
{
	[DraftValuesMarker]
	public partial interface IDirectoryPaths : IDraftValuesMarker
	{
		public string GitHubRepositoriesDirectory => @"C:\Code\DEV\Git\GitHub";
		public string SafetyConeRepositoriesDirectory => @"C:\Code\DEV\Git\GitHub\SafetyCone";
	}
}