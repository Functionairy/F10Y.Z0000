using System;

using F10Y.T0003;


namespace F10Y.Z0000
{
    [ValuesMarker]
    public partial interface IXmlTexts
    {
        /// <summary>
        /// The contents of a moderately complex C# .NET project file.
        /// </summary>
        public string Example_01 =>
@"<Project Sdk=""Microsoft.NET.Sdk"">
  <PropertyGroup Label=""Main"">
    <OutputType>Exe</OutputType>
    <TargetFramework>net8.0</TargetFramework>
    <NoWarn>1573;1587;1591;IDE0130</NoWarn>
    <GenerateDocumentationFile>true</GenerateDocumentationFile>
  </PropertyGroup>
  <PropertyGroup Label=""Package"">
    <Version>1.0.0</Version>
    <Authors>DCoats</Authors>
    <Company>Functionairy</Company>
    <Copyright>Copyright (c) Functionairy 2025</Copyright>
    <Description>An XML writer settings experiment.</Description>
    <PackageLicenseExpression>MIT</PackageLicenseExpression>
    <PackageRequireLicenseAcceptance>true</PackageRequireLicenseAcceptance>
    <RepositoryUrl>https://github.com/Functionairy/F10Y.E0001.git</RepositoryUrl>
  </PropertyGroup>
  <ItemGroup>
    <ProjectReference Include=""..\..\..\F10Y.L0000\source\F10Y.L0000\F10Y.L0000.csproj"" />
    <ProjectReference Include=""..\..\..\F10Y.T0005\source\F10Y.T0005\F10Y.T0005.csproj"" />
    <ProjectReference Include=""..\..\..\F10Y.T0006\source\F10Y.T0006\F10Y.T0006.csproj"" />
  </ItemGroup>
  <ItemGroup>
    <None Update=""Files\Example.xml"">
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </None>
  </ItemGroup>
</Project>";

        /// <summary>
        /// The contents of a moderately complex C# .NET project file, with non-standard formatting.
        /// </summary>
        public string Example_02 =>
@"<Project Sdk=""Microsoft.NET.Sdk"">
  <PropertyGroup Label=""Main"">
    <OutputType>Exe</OutputType>
      <TargetFramework>net8.0</TargetFramework>
    <NoWarn>1573;1587;1591;IDE0130</NoWarn>
    <GenerateDocumentationFile>true</GenerateDocumentationFile>


  </PropertyGroup>
  <PropertyGroup Label=""Package"">
    <Version>1.0.0</Version>
    <Authors>DCoats</Authors>
    <Company>Functionairy</Company>
    <Copyright>Copyright (c) Functionairy 2025</Copyright>
    <Description>An XML writer settings experiment.</Description>
    <PackageLicenseExpression>MIT</PackageLicenseExpression>
    <PackageRequireLicenseAcceptance>true</PackageRequireLicenseAcceptance>
    <RepositoryUrl>https://github.com/Functionairy/F10Y.E0001.git</RepositoryUrl>
  </PropertyGroup>
  <ItemGroup>
    <ProjectReference Include=""..\..\..\F10Y.L0000\source\F10Y.L0000\F10Y.L0000.csproj"" />
    <ProjectReference Include=""..\..\..\F10Y.T0005\source\F10Y.T0005\F10Y.T0005.csproj"" />
    <ProjectReference Include=""..\..\..\F10Y.T0006\source\F10Y.T0006\F10Y.T0006.csproj"" />
  </ItemGroup>
  <ItemGroup>
    <None Update=""Files\Example.xml"">
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </None>
  </ItemGroup>
</Project>";
    }
}
