using System;

using R5T.T0131;


namespace R5T.F0057
{
	[ValuesMarker]
	public partial interface IDirectoryNames : IValuesMarker
	{
		/// <summary>
		/// <para><value>.git (a hidden directory)</value></para>
		/// </summary>
		public string GitRepositoryDirectoryName => ".git";

		/// <summary>
		/// <para><value>source</value></para>
		/// </summary>
        public string RepositorySourceDirectoryName => "source";
    }
}