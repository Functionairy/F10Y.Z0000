using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0000
{
    [ValuesMarker]
    public partial interface IArrays :
        Z000.IArrays
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public new Raw.IArrays _Raw => Raw.Arrays.Instance;

        [Ignore]
        public Z000.IArrays _Z000 => Z000.Arrays.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IArrays.N_0001"/>
        public string[] Example_Strings_UpperCase => _Raw.N_0001;

        /// <inheritdoc cref="Example_Strings_UpperCase"/>
        public string[] Example_Strings => this.Example_Strings_UpperCase;
    }
}
