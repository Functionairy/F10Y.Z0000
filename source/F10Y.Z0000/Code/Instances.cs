using System;


namespace F10Y.Z0000
{
    public static class Instances
    {
        public static L0000.IStrings Strings => L0000.Strings.Instance;
        public static L0000.IVersionOperator VersionOperator => L0000.VersionOperator.Instance;
    }
}