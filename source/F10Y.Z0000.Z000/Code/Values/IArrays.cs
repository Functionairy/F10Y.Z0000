using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0000.Z000
{
    [ValuesMarker]
    public partial interface IArrays
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IArrays _Raw => Raw.Arrays.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IArrays.N_0001"/>
        public string[] Example_Strings_LowerCase => _Raw.N_0001;
    }
}
