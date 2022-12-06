using System;

using R5T.T0131;


namespace R5T.F0057
{
	[ValuesMarker]
	public partial interface IDirectoryNames : IValuesMarker
	{
        public string RepositorySourceDirectoryName => "source";
    }
}