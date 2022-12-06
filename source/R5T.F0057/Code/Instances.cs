using System;

using R5T.F0002;


namespace R5T.F0057
{
    public static class Instances
    {
        public static IDirectoryNames DirectoryNames => F0057.DirectoryNames.Instance;
        public static IDirectoryPaths DirectoryPaths { get; } = F0057.DirectoryPaths.Instance;
        public static IFileNames FileNames { get; } = F0057.FileNames.Instance;
        public static IPathOperator PathOperator { get; } = F0002.PathOperator.Instance;
        public static IRepositoryDirectoryNameOperator RepositoryDirectoryNameOperator { get; } = F0057.RepositoryDirectoryNameOperator.Instance;
    }
}