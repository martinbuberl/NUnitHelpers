using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#if DEBUG
[assembly: AssemblyTitle("NUnit.Framework.Helpers (DEBUG)")]
#else // RELEASE
[assembly: AssemblyTitle("NUnit.Framework.Helpers")]
#endif

[assembly: AssemblyDescription("")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]

[assembly: Guid("92ebe020-7fd9-4bc5-92d2-42a8137b7c74")]

[assembly: InternalsVisibleTo("NUnit.Framework.Helpers.Tests")]

[assembly: AssemblyProduct("NUnit.Framework.Helpers")]

[assembly: AssemblyCompany("Martin Buberl")]
[assembly: AssemblyCopyright("Copyright (c) 2012, Martin Buberl")]
[assembly: AssemblyTrademark("")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else // RELEASE
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: AssemblyVersion("0.1.0.0")]
[assembly: AssemblyFileVersion("0.1.0.0")]
