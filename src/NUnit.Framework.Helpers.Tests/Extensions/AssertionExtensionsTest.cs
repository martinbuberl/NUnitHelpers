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
            Assert.Throws<AssertionException>(() => ((string) null).ShouldNotBeNullOrEmpty());
            Assert.Throws<AssertionException>(() => String.Empty.ShouldNotBeNullOrEmpty());
        }

        [Test]
        public void ShouldBeEqual_IsEqual_ShouldPass()
        {
            string foo1 = new string(new[] {'f', 'o', 'o'});
            string foo2 = new string(new[] {'f', 'o', 'o'});

            foo1.ShouldBeEqual(foo2);
        }

        [Test]
        public void ShouldBeEqual_IsNotEqual_ShouldThrowAssertionException()
        {
            string foo = new string(new[] {'f', 'o', 'o'});
            string bar = new string(new[] {'b', 'a', 'r'});

            Assert.Throws<AssertionException>(() => foo.ShouldBeEqual(bar));
        }

        [Test]
        public void ShouldNotBeEqual_IsNotEqual_ShouldPass()
        {
            string foo = new string(new[] {'f', 'o', 'o'});
            string bar = new string(new[] {'b', 'a', 'r'});

            foo.ShouldNotBeEqual(bar);
        }

        [Test]
        public void ShouldNotBeEqual_IsEqual_ShouldThrowAssertionException()
        {
            string foo1 = new string(new[] {'f', 'o', 'o'});
            string foo2 = new string(new[] {'f', 'o', 'o'});

            Assert.Throws<AssertionException>(() => foo1.ShouldNotBeEqual(foo2));
        }

        [Test]
        public void ShouldBeSame_IsSame_ShouldPass()
        {
            string foo1 = new string(new[] {'f', 'o', 'o'});
            string foo2 = foo1;

            foo1.ShouldBeSame(foo2);
        }

        [Test]
        public void ShouldBeSame_IsNotSame_ShouldThrowAssertionException()
        {
            string foo1 = new string(new[] {'f', 'o', 'o'});
            string foo2 = new string(new[] {'f', 'o', 'o'});

            Assert.Throws<AssertionException>(() => foo1.ShouldBeSame(foo2));
        }

        [Test]
        public void ShouldNotBeSame_IsNotSame_ShouldPass()
        {
            string foo1 = new string(new[] {'f', 'o', 'o'});
            string foo2 = new string(new[] {'f', 'o', 'o'});

            foo1.ShouldNotBeSame(foo2);
        }

        [Test]
        public void ShouldNotBeSame_IsSame_ShouldThrowAssertionException()
        {
            string foo1 = new string(new[] {'f', 'o', 'o'});
            string foo2 = foo1;

            Assert.Throws<AssertionException>(() => foo1.ShouldNotBeSame(foo2));
        }

        [Test]
        public void ShouldBeTrue_IsTrue_ShouldPass()
        {
            true.ShouldBeTrue();
        }

        [Test]
        public void ShouldBeTrue_IsFalse_ShouldThrowAssertionException()
        {
            Assert.Throws<AssertionException>(() => false.ShouldBeTrue());
        }

        [Test]
        public void ShouldBeFalse_IsFalse_ShouldPass()
        {
            false.ShouldBeFalse();
        }

        [Test]
        public void ShouldBeFalse_IsTrue_ThrowAssertionException()
        {
            Assert.Throws<AssertionException>(() => true.ShouldBeFalse());
        }
    }
}
