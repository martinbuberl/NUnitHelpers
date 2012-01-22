using System.Diagnostics;

namespace NUnit.Framework.Helpers.Extensions
{
    [DebuggerStepThrough]
    [DebuggerNonUserCode]
    public static class AssertionExtensions
    {
        public static void ShouldBeNull(this object actual)
        {
            Assert.IsNull(actual);
        }

        public static void ShouldNotBeNull(this object actual)
        {
            Assert.IsNotNull(actual);
        }

        public static void ShouldBeNullOrEmpty(this string actual)
        {
            Assert.IsNullOrEmpty(actual);
        }

        public static void ShouldNotBeNullOrEmpty(this string actual)
        {
            Assert.IsNotNullOrEmpty(actual);
        }
    }
}
