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
        public void ShouldBeEmpty_IsNotEmpty_ShouldThrowAssertionException()
        {
            Assert.Throws<AssertionException>(() => "foo".ShouldBeEmpty());
        }

        [Test]
        public void ShouldBeEmpty_IsEmpty_ShouldPass()
        {
            String.Empty.ShouldBeEmpty();
            "".ShouldBeEmpty();
        }

        [Test]
        public void ShouldNotBeEmpty_IsNotEmpty_ShouldPass()
        {
            "foo".ShouldNotBeEmpty();
        }

        [Test]
        public void ShouldNotBeEmpty_IsEmpty_ShouldThrowAssertionException()
        {
            Assert.Throws<AssertionException>(() => String.Empty.ShouldNotBeEmpty());
            Assert.Throws<AssertionException>(() => "".ShouldNotBeEmpty());
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
        public void ShouldBeFalse_IsTrue_ShouldThrowAssertionException()
        {
            Assert.Throws<AssertionException>(() => true.ShouldBeFalse());
        }

        [Test]
        public void ShouldBeT_IsT_ShouldPass()
        {
            "foo".ShouldBe<string>();
        }

        [Test]
        public void ShouldBeT_IsNotT_ShouldThrowAssertionException()
        {
            Assert.Throws<AssertionException>(() => "foo".ShouldBe<int>());
        }

        [Test]
        public void ShouldBeAssignableFrom_IsAssignableFrom_ShouldPass()
        {
            Beer beer = new Beer();

            beer.ShouldBeAssignableFrom<Drink>();
            beer.ShouldBeAssignableFrom<IDrink>();

            "foo".ShouldBeAssignableFrom<object>();
        }

        [Test]
        public void ShouldBeAssignableFrom_IsNotAssignableFrom_ShouldThrowAssertionException()
        {
            Beer beer = new Beer();

            Assert.Throws<AssertionException>(beer.ShouldBeAssignableFrom<string>);
        }

        [Test]
        public void ShouldBeLess_IsLess_ShouldPass()
        {
            ((decimal)10).ShouldBeLess(20);
            ((double)10).ShouldBeLess(20);
            ((float)10).ShouldBeLess(20);
            ((int)10).ShouldBeLess(20);
            ((long)10).ShouldBeLess(20);
            ((uint)10).ShouldBeLess(20);
            ((ulong)10).ShouldBeLess(20);
        }

        [Test]
        public void ShouldBeLess_IsEqual_ShouldThrowAssertionException()
        {
            Should.Throw<AssertionException>(() => ((decimal)10).ShouldBeLess(10));
            Should.Throw<AssertionException>(() => ((double)10).ShouldBeLess(10));
            Should.Throw<AssertionException>(() => ((float)10).ShouldBeLess(10));
            Should.Throw<AssertionException>(() => ((int)10).ShouldBeLess(10));
            Should.Throw<AssertionException>(() => ((long)10).ShouldBeLess(10));
            Should.Throw<AssertionException>(() => ((uint)10).ShouldBeLess(10));
            Should.Throw<AssertionException>(() => ((ulong)10).ShouldBeLess(10));
        }

        [Test]
        public void ShouldBeLess_IsGreater_ShouldThrowAssertionException()
        {
            Should.Throw<AssertionException>(() => ((decimal)10).ShouldBeLess(5));
            Should.Throw<AssertionException>(() => ((double)10).ShouldBeLess(5));
            Should.Throw<AssertionException>(() => ((float)10).ShouldBeLess(5));
            Should.Throw<AssertionException>(() => ((int)10).ShouldBeLess(5));
            Should.Throw<AssertionException>(() => ((long)10).ShouldBeLess(5));
            Should.Throw<AssertionException>(() => ((uint)10).ShouldBeLess(5));
            Should.Throw<AssertionException>(() => ((ulong)10).ShouldBeLess(5));
        }

        [Test]
        public void ShouldBeLessOrEqual_IsLess_ShouldPass()
        {
            ((decimal)10).ShouldBeLessOrEqual(20);
            ((double)10).ShouldBeLessOrEqual(20);
            ((float)10).ShouldBeLessOrEqual(20);
            ((int)10).ShouldBeLessOrEqual(20);
            ((long)10).ShouldBeLessOrEqual(20);
            ((uint)10).ShouldBeLessOrEqual(20);
            ((ulong)10).ShouldBeLessOrEqual(20);
        }

        [Test]
        public void ShouldBeLessOrEqual_IsEqual_ShouldPass()
        {
            ((decimal)10).ShouldBeLessOrEqual(10);
            ((double)10).ShouldBeLessOrEqual(10);
            ((float)10).ShouldBeLessOrEqual(10);
            ((int)10).ShouldBeLessOrEqual(10);
            ((long)10).ShouldBeLessOrEqual(10);
            ((uint)10).ShouldBeLessOrEqual(10);
            ((ulong)10).ShouldBeLessOrEqual(10);
        }

        [Test]
        public void ShouldBeLessOrEqual_IsGreater_ShouldThrowAssertionException()
        {
            Should.Throw<AssertionException>(() => ((decimal)10).ShouldBeLessOrEqual(5));
            Should.Throw<AssertionException>(() => ((double)10).ShouldBeLessOrEqual(5));
            Should.Throw<AssertionException>(() => ((float)10).ShouldBeLessOrEqual(5));
            Should.Throw<AssertionException>(() => ((int)10).ShouldBeLessOrEqual(5));
            Should.Throw<AssertionException>(() => ((long)10).ShouldBeLessOrEqual(5));
            Should.Throw<AssertionException>(() => ((uint)10).ShouldBeLessOrEqual(5));
            Should.Throw<AssertionException>(() => ((ulong)10).ShouldBeLessOrEqual(5));
        }

        [Test]
        public void ShouldBeGreater_IsGreater_ShouldPass()
        {
            ((decimal)30).ShouldBeGreater(20);
            ((double)30).ShouldBeGreater(20);
            ((float)30).ShouldBeGreater(20);
            ((int)30).ShouldBeGreater(20);
            ((long)30).ShouldBeGreater(20);
            ((uint)30).ShouldBeGreater(20);
            ((ulong)30).ShouldBeGreater(20);
        }

        [Test]
        public void ShouldBeGreater_IsEqual_ShouldThrowAssertionException()
        {
            Should.Throw<AssertionException>(() => ((decimal)10).ShouldBeGreater(10));
            Should.Throw<AssertionException>(() => ((double)10).ShouldBeGreater(10));
            Should.Throw<AssertionException>(() => ((float)10).ShouldBeGreater(10));
            Should.Throw<AssertionException>(() => ((int)10).ShouldBeGreater(10));
            Should.Throw<AssertionException>(() => ((long)10).ShouldBeGreater(10));
            Should.Throw<AssertionException>(() => ((uint)10).ShouldBeGreater(10));
            Should.Throw<AssertionException>(() => ((ulong)10).ShouldBeGreater(10));
        }

        [Test]
        public void ShouldBeGreater_IsLess_ShouldThrowAssertionException()
        {
            Should.Throw<AssertionException>(() => ((decimal)10).ShouldBeGreater(20));
            Should.Throw<AssertionException>(() => ((double)10).ShouldBeGreater(20));
            Should.Throw<AssertionException>(() => ((float)10).ShouldBeGreater(20));
            Should.Throw<AssertionException>(() => ((int)10).ShouldBeGreater(20));
            Should.Throw<AssertionException>(() => ((long)10).ShouldBeGreater(20));
            Should.Throw<AssertionException>(() => ((uint)10).ShouldBeGreater(20));
            Should.Throw<AssertionException>(() => ((ulong)10).ShouldBeGreater(20));
        }

        [Test]
        public void ShouldBeGreaterOrEqual_IsGreater_ShouldPass()
        {
            ((decimal)30).ShouldBeGreaterOrEqual(20);
            ((double)30).ShouldBeGreaterOrEqual(20);
            ((float)30).ShouldBeGreaterOrEqual(20);
            ((int)30).ShouldBeGreaterOrEqual(20);
            ((long)30).ShouldBeGreaterOrEqual(20);
            ((uint)30).ShouldBeGreaterOrEqual(20);
            ((ulong)30).ShouldBeGreaterOrEqual(20);
        }

        [Test]
        public void ShouldBeGreaterOrEqual_IsEqual_ShouldPass()
        {
            ((decimal)30).ShouldBeGreaterOrEqual(30);
            ((double)30).ShouldBeGreaterOrEqual(30);
            ((float)30).ShouldBeGreaterOrEqual(30);
            ((int)30).ShouldBeGreaterOrEqual(30);
            ((long)30).ShouldBeGreaterOrEqual(30);
            ((uint)30).ShouldBeGreaterOrEqual(30);
            ((ulong)30).ShouldBeGreaterOrEqual(30);
        }

        [Test]
        public void ShouldBeGreaterOrEqual_IsLess_ShouldThrowAssertionException()
        {
            Should.Throw<AssertionException>(() => ((decimal)10).ShouldBeGreaterOrEqual(20));
            Should.Throw<AssertionException>(() => ((double)10).ShouldBeGreaterOrEqual(20));
            Should.Throw<AssertionException>(() => ((float)10).ShouldBeGreaterOrEqual(20));
            Should.Throw<AssertionException>(() => ((int)10).ShouldBeGreaterOrEqual(20));
            Should.Throw<AssertionException>(() => ((long)10).ShouldBeGreaterOrEqual(20));
            Should.Throw<AssertionException>(() => ((uint)10).ShouldBeGreaterOrEqual(20));
            Should.Throw<AssertionException>(() => ((ulong)10).ShouldBeGreaterOrEqual(20));
        }
    }

    #region Helpers

    internal class Drink : IDrink
    {
    }

    internal class Beer : Drink
    {
    }

    internal interface IDrink
    {
    }

    #endregion
}
