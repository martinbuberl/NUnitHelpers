# NUnitHelpers
NUnitHelpers is a library of useful helpers to add [behavior-driven development][bdd] to [NUnit][nunit].

**This project is not maintained anymore. I'd strongly advise using NUnit's fluent syntax.**

## Get it on NuGet

[NuGet][nuget] is a Visual Studio extension that makes it easy to install and update third-party libraries 
and tools in Visual Studio.

To install [NUnitHelpers][package], run the following command in the [Package Manager Console][pmc]:

    PM> Install-Package NUnitHelpers

## Usage

###Extension methods

The usage is pretty straight forward. Instead of the classic `Assert.IsNull(actual)` just use the extension method on the actual object `actual.ShouldBeNull()` to create a BDD-style test.

The implemented extensions are:

    ShouldBeNull()
    ShouldNotBeNull()
    ShouldBeNullOrEmpty()
    ShouldNotBeNullOrEmpty()
    ShouldBeEmpty()
    ShouldNotBeEmpty()
    ShouldBeEqual(expected)
    ShouldNotBeEqual(expected)
    ShouldBeSame(expected)
    ShouldNotBeSame(expected)
    ShouldBeTrue()
    ShouldBeFalse()
    ShouldBe<TExpected>()
    ShouldBeAssignableFrom<TExpected>()
    ShouldBeLess(expected)
    ShouldBeLessOrEqual(expected)
    ShouldBeGreater(expected)
    ShouldBeGreaterOrEqual(expected)

## Give back

If you found this project useful you can follow me on Twitter ([@martinbuberl][twitter]) or [buy me a beer][donate].

## License
NUnitHelpers is released under the [MIT license][mit].

[bdd]:     http://en.wikipedia.org/wiki/Behavior_Driven_Development
[nunit]:   http://nunit.org
[nuget]:   http://nuget.org
[package]: http://nuget.org/packages/NUnitHelpers
[pmc]:     http://docs.nuget.org/docs/start-here/using-the-package-manager-console
[twitter]:  https://twitter.com/martinbuberl
[donate]:  https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=2AGHGEL2X4VSQ
[mit]:     https://github.com/martinbuberl/NUnitHelpers/blob/master/LICENSE