using System;

using F10Y.T0003;


namespace F10Y.Z0000
{
    [ValuesMarker]
    public partial interface INuGetPackageIDs
    {
        #region Examples

        /// <inheritdoc cref="F10Y_L0000"/>
        public string Example_NuGetPackage_Exists => this.F10Y_L0000;

        /// <inheritdoc cref="F10Y_S0000"/>
        public string Example_NuGetPackage_NotExists => this.F10Y_S0000;

        #endregion

        /// <summary>
        /// <para><value>F10Y.L0000</value></para>
        /// </summary>
        public string F10Y_L0000 => "F10Y.L0000";

        /// <summary>
        /// <para><value>F10Y.S0000</value></para>
        /// </summary>
        public string F10Y_S0000 => "F10Y.S0000";

        /// <summary>
        /// <para><value>Newtonsoft.Json</value></para>
        /// </summary>
        public string Newtonsoft_Json => "Newtonsoft.Json";
    }
}
