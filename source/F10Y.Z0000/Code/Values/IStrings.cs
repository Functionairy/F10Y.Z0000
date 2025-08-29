using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0000
{
    [ValuesMarker]
    public partial interface IStrings :
        Z000.IStrings
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Z000.IStrings _Z000 => Z000.Strings.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// <para><value>Apple</value></para>
        /// </summary>
        public string Apple => "Apple";

        /// <summary>
        /// <para><value>Banana</value></para>
        /// </summary>
        public string Banana => "Banana";

        /// <summary>
        /// <para><value>Cat</value></para>
        /// </summary>
        public string Cat => "Cat";
    }
}
