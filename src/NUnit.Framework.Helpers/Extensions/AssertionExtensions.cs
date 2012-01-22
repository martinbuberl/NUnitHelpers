using System.Diagnostics;

namespace NUnit.Framework.Helpers.Extensions
{
    [DebuggerStepThrough]
    [DebuggerNonUserCode]
    public static class AssertionExtensions
    {
        public static void ShouldBeNull(this object actual)
        {
            // NUnit, VSTS
            Assert.IsNull(actual);
        }
    }
}
