using System;

using F10Y.T0003;


namespace F10Y.Z0000.Z001
{
    [ValuesMarker]
    public partial interface IFilePaths
    {
        /// <summary>
        /// <inheritdoc cref="IFileNames.Example_json" path="descendant::value" />, in the Files output directory.
        /// </summary>
        public string Example_JsonFilePath => Instances.FilesDirectoryOperator.Get_Path_FromFilesDirectoryRelativePath(Instances.FileNames.Example_json);

        /// <summary>
        /// <inheritdoc cref="IFileNames.Example_xml" path="descendant::value" />, in the Files output directory.
        /// </summary>
        public string Example_XmlFilePath => Instances.FilesDirectoryOperator.Get_Path_FromFilesDirectoryRelativePath(Instances.FileNames.Example_xml);
    }
}
