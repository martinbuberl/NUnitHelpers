# NUnitHelpers
NUnitHelpers is a library of useful helpers to add [behavior-driven development][bdd] to [NUnit][nunit].

## Get it on NuGet

[NuGet][nuget] is a Visual Studio extension that makes it easy to install and update third-party libraries 
and tools in Visual Studio.

To install [NUnitHelpers][package], run the following command in the [Package Manager Console][pmc]:

    PM> Install-Package NUnitHelpers

## Usage

###Should extension methods

The usage is pretty straight forward. Instead of the classic `Assert.IsNull(actual)` just use the extension method on the actual object `actual.ShouldBeNull()`.

    ShouldBeNull(this object actual)
    ShouldNotBeNull(this object actual)
    ShouldBeNullOrEmpty(this string actual)
    ShouldNotBeNullOrEmpty(this string actual)
    ShouldBeEmpty(this string actual)
    ShouldNotBeEmpty(this string actual)
    ShouldBeEqual(this object actual, object expected)
    ShouldNotBeEqual(this object actual, object expected)
    ShouldBeSame(this object actual, object expected)
    ShouldNotBeSame(this object actual, object expected)
    ShouldBeTrue(this bool actual)
    ShouldBeFalse(this bool actual)
    ShouldBe<TExpected>(this object actual)
    ShouldBeAssignableFrom<TExpected>(this object actual)
    ShouldBeLess(this decimal actual, decimal expected)
    ShouldBeLess(this double actual, double expected)
    ShouldBeLess(this float actual, float expected)
    ShouldBeLess(this int actual, int expected)
    ShouldBeLess(this long actual, long expected)
    ShouldBeLess(this uint actual, uint expected)
    ShouldBeLess(this ulong actual, ulong expected)
    ShouldBeLessOrEqual(this decimal actual, decimal expected)
    ShouldBeLessOrEqual(this double actual, double expected)
    ShouldBeLessOrEqual(this float actual, float expected)
    ShouldBeLessOrEqual(this int actual, int expected)
    ShouldBeLessOrEqual(this long actual, long expected)
    ShouldBeLessOrEqual(this uint actual, uint expected)
    ShouldBeLessOrEqual(this ulong actual, ulong expected)
    ShouldBeGreater(this decimal actual, decimal expected)
    ShouldBeGreater(this double actual, double expected)
    ShouldBeGreater(this float actual, float expected)
    ShouldBeGreater(this int actual, int expected)
    ShouldBeGreater(this long actual, long expected)
    ShouldBeGreater(this uint actual, uint expected)
    ShouldBeGreater(this ulong actual, ulong expected)
    ShouldBeGreaterOrEqual(this decimal actual, decimal expected)
    ShouldBeGreaterOrEqual(this double actual, double expected)
    ShouldBeGreaterOrEqual(this float actual, float expected)
    ShouldBeGreaterOrEqual(this int actual, int expected)
    ShouldBeGreaterOrEqual(this long actual, long expected)
    ShouldBeGreaterOrEqual(this uint actual, uint expected)
    ShouldBeGreaterOrEqual(this ulong actual, ulong expected)

## Give back

If you found this project useful you can [buy me a beer][donate].

## License
NUnitHelpers is released under the [MIT license][mit].

[bdd]:     http://en.wikipedia.org/wiki/Behavior_Driven_Development
[nunit]:   http://nunit.org
[nuget]:   http://nuget.org
[package]: http://nuget.org/packages/NUnitHelpers
[pmc]:     http://docs.nuget.org/docs/start-here/using-the-package-manager-console
[donate]:  https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=2AGHGEL2X4VSQ
[mit]:     https://github.com/martinbuberl/NUnitHelpers/blob/master/LICENSE