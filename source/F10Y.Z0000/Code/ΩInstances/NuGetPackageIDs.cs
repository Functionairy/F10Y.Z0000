using System;


namespace F10Y.Z0000
{
    public class NuGetPackageIDs : INuGetPackageIDs
    {
        #region Infrastructure

        public static INuGetPackageIDs Instance { get; } = new NuGetPackageIDs();


        private NuGetPackageIDs()
        {
        }

        #endregion
    }
}
