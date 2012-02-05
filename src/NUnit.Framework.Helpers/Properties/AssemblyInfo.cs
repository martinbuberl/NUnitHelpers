using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("NUnitHelpers")]
[assembly: AssemblyDescription("NUnitHelpers is a library of useful NUnit helpers.")]
[assembly: AssemblyCompany("Martin Buberl")]

[assembly: ComVisible(false)]

[assembly: Guid("92ebe020-7fd9-4bc5-92d2-42a8137b7c74")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else // RELEASE
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: AssemblyVersion("0.1.0.0")]
[assembly: AssemblyFileVersion("0.1.0.0")]
