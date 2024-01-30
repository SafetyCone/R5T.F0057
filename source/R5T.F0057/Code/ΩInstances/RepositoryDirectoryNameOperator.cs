using System;


namespace R5T.F0057
{
	public class RepositoryDirectoryNameOperator : IRepositoryDirectoryNameOperator
	{
		#region Infrastructure

	    public static IRepositoryDirectoryNameOperator Instance { get; } = new RepositoryDirectoryNameOperator();

	    private RepositoryDirectoryNameOperator()
	    {
        }

	    #endregion
	}
}