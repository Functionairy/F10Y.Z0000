using System;


namespace F10Y.Z0000
{
    public class Arrays : IArrays
    {
        #region Infrastructure

        public static IArrays Instance { get; } = new Arrays();


        private Arrays()
        {
        }

        #endregion
    }
}


namespace F10Y.Z0000.Raw
{
    public class Arrays : IArrays
    {
        #region Infrastructure

        public static IArrays Instance { get; } = new Arrays();


        private Arrays()
        {
        }

        #endregion
    }
}