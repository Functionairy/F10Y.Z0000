using System;

using F10Y.T0003;


namespace F10Y.Z0000.Z001
{
    [ValuesMarker]
    public partial interface IFileNames
    {
        /// <summary>
        /// <para><value>Example.json</value></para>
        /// </summary>
        public string Example_json => "Example.json";

        /// <summary>
        /// <para><value>Example.xml</value></para>
        /// </summary>
        public string Example_xml => "Example.xml";
    }
}
