using System.Reflection;

[assembly: AssemblyProduct("NUnitHelpers")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else // RELEASE
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: AssemblyCompany("Martin Buberl")]
[assembly: AssemblyCopyright("Copyright (c) 2012, Martin Buberl")]

[assembly: AssemblyVersion("0.1.2.0")]
[assembly: AssemblyFileVersion("0.1.2.0")]
