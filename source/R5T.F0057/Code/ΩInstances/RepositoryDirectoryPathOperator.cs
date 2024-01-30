using System;


namespace R5T.F0057
{
	public class RepositoryDirectoryPathOperator : IRepositoryDirectoryPathOperator
	{
		#region Infrastructure

	    public static IRepositoryDirectoryPathOperator Instance { get; } = new RepositoryDirectoryPathOperator();

	    private RepositoryDirectoryPathOperator()
	    {
        }

	    #endregion
	}
}