using System.Reflection;
using System.Runtime.InteropServices;

#if DEBUG
[assembly: AssemblyTitle("NUnitHelpers (Debug)")]
#else // RELEASE
[assembly: AssemblyTitle("NUnitHelpers")]
#endif

[assembly: AssemblyDescription("NUnitHelpers is a library of useful helpers to add behavior-driven development to NUnit.")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]

[assembly: Guid("92ebe020-7fd9-4bc5-92d2-42a8137b7c74")]
