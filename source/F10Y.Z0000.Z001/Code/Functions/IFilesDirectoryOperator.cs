using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.Z0000.Z001
{
    [FunctionsMarker]
    public partial interface IFilesDirectoryOperator :
        L0001.L001.IFilesDirectoryOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0001.L001.IFilesDirectoryOperator _L0001_L001 => L0001.L001.FilesDirectoryOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles

        public string Get_Path_FromFilesDirectoryRelativePath(string path_FilesDirectoryRelative)
        {
            var output = this.Get_Path_FromFilesDirectoryRelativePath(
                Instances.Values.ProjectName,
                path_FilesDirectoryRelative);

            return output;
        }
    }
}
