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

        public static void ShouldBe<TExpected>(this object actual)
        {
            Assert.IsInstanceOf<TExpected>(actual);
        }

        public static void ShouldBeAssignableFrom<TExpected>(this object actual)
        {
            // Assert.IsAssignableFrom is not implemented properly, see https://bugs.launchpad.net/nunitv2/+bug/809679
            Assert.That(actual is TExpected);
        }

        public static void ShouldBeLess(this decimal actual, decimal expected)
        {
            Assert.Less(actual, expected);
        }

        public static void ShouldBeLess(this double actual, double expected)
        {
            Assert.Less(actual, expected);
        }

        public static void ShouldBeLess(this float actual, float expected)
        {
            Assert.Less(actual, expected);
        }

        public static void ShouldBeLess(this int actual, int expected)
        {
            Assert.Less(actual, expected);
        }

        public static void ShouldBeLess(this long actual, long expected)
        {
            Assert.Less(actual, expected);
        }

        public static void ShouldBeLess(this uint actual, uint expected)
        {
            Assert.Less(actual, expected);
        }

        public static void ShouldBeLess(this ulong actual, ulong expected)
        {
            Assert.Less(actual, expected);
        }

        public static void ShouldBeLessOrEqual(this decimal actual, decimal expected)
        {
            Assert.LessOrEqual(actual, expected);
        }

        public static void ShouldBeLessOrEqual(this double actual, double expected)
        {
            Assert.LessOrEqual(actual, expected);
        }

        public static void ShouldBeLessOrEqual(this float actual, float expected)
        {
            Assert.LessOrEqual(actual, expected);
        }

        public static void ShouldBeLessOrEqual(this int actual, int expected)
        {
            Assert.LessOrEqual(actual, expected);
        }

        public static void ShouldBeLessOrEqual(this long actual, long expected)
        {
            Assert.LessOrEqual(actual, expected);
        }

        public static void ShouldBeLessOrEqual(this uint actual, uint expected)
        {
            Assert.LessOrEqual(actual, expected);
        }

        public static void ShouldBeLessOrEqual(this ulong actual, ulong expected)
        {
            Assert.LessOrEqual(actual, expected);
        }

        public static void ShouldBeGreater(this decimal actual, decimal expected)
        {
            Assert.Greater(actual, expected);
        }

        public static void ShouldBeGreater(this double actual, double expected)
        {
            Assert.Greater(actual, expected);
        }

        public static void ShouldBeGreater(this float actual, float expected)
        {
            Assert.Greater(actual, expected);
        }

        public static void ShouldBeGreater(this int actual, int expected)
        {
            Assert.Greater(actual, expected);
        }

        public static void ShouldBeGreater(this long actual, long expected)
        {
            Assert.Greater(actual, expected);
        }

        public static void ShouldBeGreater(this uint actual, uint expected)
        {
            Assert.Greater(actual, expected);
        }

        public static void ShouldBeGreater(this ulong actual, ulong expected)
        {
            Assert.Greater(actual, expected);
        }

        public static void ShouldBeGreaterOrEqual(this decimal actual, decimal expected)
        {
            Assert.GreaterOrEqual(actual, expected);
        }

        public static void ShouldBeGreaterOrEqual(this double actual, double expected)
        {
            Assert.GreaterOrEqual(actual, expected);
        }

        public static void ShouldBeGreaterOrEqual(this float actual, float expected)
        {
            Assert.GreaterOrEqual(actual, expected);
        }

        public static void ShouldBeGreaterOrEqual(this int actual, int expected)
        {
            Assert.GreaterOrEqual(actual, expected);
        }

        public static void ShouldBeGreaterOrEqual(this long actual, long expected)
        {
            Assert.GreaterOrEqual(actual, expected);
        }

        public static void ShouldBeGreaterOrEqual(this uint actual, uint expected)
        {
            Assert.GreaterOrEqual(actual, expected);
        }

        public static void ShouldBeGreaterOrEqual(this ulong actual, ulong expected)
        {
            Assert.GreaterOrEqual(actual, expected);
        }
    }
}
