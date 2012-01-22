using System;
using NUnit.Framework.Helpers.Extensions;

namespace NUnit.Framework.Helpers.Tests.Extensions
{
    [TestFixture]
    public class AssertionExtensionsTest
    {
        [Test]
        public void ShouldBeNull_IsNull_ShouldPass()
        {
            ((string) null).ShouldBeNull();
        }

        [Test]
        public void ShouldBeNull_IsNotNull_ShouldThrowAssertionException()
        {
            Assert.Throws<AssertionException>(() => String.Empty.ShouldBeNull());
        }

        [Test]
        public void ShouldNotBeNull_IsNotNull_ShouldPass()
        {
            String.Empty.ShouldNotBeNull();
        }

        [Test]
        public void ShouldNotBeNull_IsNull_ShouldThrowAssertionException()
        {
            Assert.Throws<AssertionException>(() => ((string) null).ShouldNotBeNull());
        }

        [Test]
        public void ShouldBeNullOrEmpty_IsNullOrEmpty_ShouldPass()
        {
            ((string) null).ShouldBeNullOrEmpty();
            String.Empty.ShouldBeNullOrEmpty();
        }

        [Test]
        public void ShouldBeNullOrEmpty_IsNotNullOrEmpty_ShouldThrowAssertionException()
        {
            Assert.Throws<AssertionException>(() => "foo".ShouldBeNullOrEmpty());
        }

        [Test]
        public void ShouldNotBeNullOrEmpty_IsNotNullOrEmpty_ShouldPass()
        {
            "foo".ShouldNotBeNullOrEmpty();
        }

        [Test]
        public void ShouldNotBeNullOrEmpty_IsNullOrEmpty_ShouldThrowAssertionException()
        {
            Assert.Throws<AssertionException>(() => ((string)null).ShouldNotBeNullOrEmpty());
            Assert.Throws<AssertionException>(() => String.Empty.ShouldNotBeNullOrEmpty());
        }
    }
}
