using System;
using System.Diagnostics;

namespace NUnit.Framework.Helpers
{
    /// <remarks>
    /// Decorating tests with the ExpectedException attribute is considered to be a TDD anti-pattern called
    /// "The Secret Catcher". See <see href="http://blog.james-carr.org/2006/11/03/tdd-anti-patterns/" />.
    /// </remarks>
    /// <see href="http://geekswithblogs.net/sdorman/archive/2009/01/17/unit-testing-and-expected-exceptions.aspx" />
    [DebuggerStepThrough]
    [DebuggerNonUserCode]
    public static class Should
    {
        public static void Throw<TException>(Action blockToExecute) where TException : Exception
        {
            try
            {
                blockToExecute();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.GetType() == typeof(TException), "Expected exception of type " + typeof(TException) + " but type of " + ex.GetType() + " was thrown instead.");

                return;
            }

            Assert.Fail("Expected exception of type " + typeof(TException) + " but no exception was thrown.");
        }

        public static void Throw<TException>(string expectedMessage, Action blockToExecute) where TException : Exception
        {
            try
            {
                blockToExecute();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.GetType() == typeof(TException), "Expected exception of type " + typeof(TException) + " but type of " + ex.GetType() + " was thrown instead.");
                Assert.AreEqual(expectedMessage, ex.Message, "Expected exception with a message of '" + expectedMessage + "' but exception with message of '" + ex.Message + "' was thrown instead.");

                return;
            }

            Assert.Fail("Expected exception of type " + typeof(TException) + " but no exception was thrown.");
        }
    }
}
