using System;

using F10Y.T0003;


namespace F10Y.Z0000.Raw
{
    [ValuesMarker]
    public partial interface IArrays
    {
        /// <summary>
        /// <list type="bullet">
        /// <item><inheritdoc cref="L0000.IStrings.A" path="descendant::value"/></item>
        /// <item><inheritdoc cref="L0000.IStrings.B" path="descendant::value"/></item>
        /// <item><inheritdoc cref="L0000.IStrings.C" path="descendant::value"/></item>
        /// </list>
        /// </summary>
        public string[] N_0001 => new string[]
        {
            Instances.Strings.A,
            Instances.Strings.B,
            Instances.Strings.C
        };
    }
}
