using System;


namespace F10Y.Z0000
{
    public class XmlTexts : IXmlTexts
    {
        #region Infrastructure

        public static IXmlTexts Instance { get; } = new XmlTexts();


        private XmlTexts()
        {
        }

        #endregion
    }
}
