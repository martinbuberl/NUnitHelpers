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

        public static void ShouldBeEqual(this object actual, object expected)
        {
            Assert.AreEqual(expected, actual);
        }

        public static void ShouldNotBeEqual(this object actual, object expected)
        {
            Assert.AreNotEqual(expected, actual);
        }

        public static void ShouldBeSame(this object actual, object expected)
        {
            Assert.AreSame(expected, actual);
        }

        public static void ShouldNotBeSame(this object actual, object expected)
        {
            Assert.AreNotSame(expected, actual);
        }

        public static void ShouldBeTrue(this bool actual)
        {
            Assert.IsTrue(actual);
        }

        public static void ShouldBeFalse(this bool actual)
        {
            Assert.IsFalse(actual);
        }
    }
}
