using System;


namespace F10Y.Z0000.Z001
{
    public static class Instances
    {
        public static IFileNames FileNames => Z001.FileNames.Instance;
        public static IFilesDirectoryOperator FilesDirectoryOperator => Z001.FilesDirectoryOperator.Instance;
        public static IValues Values => Z001.Values.Instance;
    }
}