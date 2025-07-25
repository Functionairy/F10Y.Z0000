using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0000
{
    /// <summary>
    /// Example versions.
    /// </summary>
    [ValuesMarker]
    public partial interface IVersions :
        L0000.IVersions
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0000.IVersions _L0000 => L0000.Versions.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Example_MajorMinorBuild"/>
        public Version Example => this.Example_MajorMinorBuild;

        /// <summary>
        /// <para><value>3.2</value></para>
        /// </summary>
        public Version Example_MajorMinor => Instances.VersionOperator.From(3, 2);

        /// <summary>
        /// <para><value>3.2.1</value></para>
        /// </summary>
        public Version Example_MajorMinorBuild => Instances.VersionOperator.From(3, 2, 1);

        /// <summary>
        /// <para><value>3.2.1.4</value></para>
        /// </summary>
        public Version Example_MajorMinorBuildRevision => Instances.VersionOperator.From(3, 2, 1, 4);
    }
}
