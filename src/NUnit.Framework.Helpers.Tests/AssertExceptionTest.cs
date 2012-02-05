using System;

namespace NUnit.Framework.Helpers.Tests
{
    [TestFixture]
    public class AssertExceptionTest
    {
        [Test]
        public void ShouldThrowException_ThrowsException_ShouldPass()
        {
            Should.Throw<Exception>(ThrowsException);
            Should.Throw<Exception>("foo", ThrowsException);
        }

        [Test]
        public void ShouldThrowException_ThrowsNoException_ShouldFail()
        {
            Assert.Throws<AssertionException>(() => Should.Throw<Exception>(ThrowsNoException));
            Assert.Throws<AssertionException>(() => Should.Throw<Exception>("foo", ThrowsNoException));
        }

        #region Helpers

        public void ThrowsException()
        {
            throw new Exception("foo");
        }

        public void ThrowsNoException()
        {
        }

        #endregion
    }
}
