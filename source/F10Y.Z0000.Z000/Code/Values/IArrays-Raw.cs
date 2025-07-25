using System;

using F10Y.T0003;


namespace F10Y.Z0000.Z000.Raw
{
    [ValuesMarker]
    public partial interface IArrays
    {
        /// <summary>
        /// <list type="bullet">
        /// <item>"a"</item>
        /// <item>"b"</item>
        /// <item>"c""</item>
        /// </list>
        /// </summary>
        public string[] N_0001 => new string[]
        {
            "a",
            "b",
            "c"
        };
    }
}
