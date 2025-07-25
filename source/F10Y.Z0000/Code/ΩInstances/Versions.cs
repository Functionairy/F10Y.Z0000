using System;


namespace F10Y.Z0000
{
    public class Versions : IVersions
    {
        #region Infrastructure

        public static IVersions Instance { get; } = new Versions();


        private Versions()
        {
        }

        #endregion
    }
}
