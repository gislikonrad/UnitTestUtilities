# UnitTestUtilities

##### Some simple utilities for unit testing in .Net

## Features

* Temporarily change the culture of a thread during a unit test
  * Useful for testing different formatting for different cultures
* Assert an action throws an exception
  * Gone are the times of the ExpectedException attribute

## Examples

### Culture

##### Change to English (UK)
 ```c#
 using(Culture.SwitchTo("en-GB"))
 {
	// do your testing
 }
 ```

##### Change only the CurrentUICulture to English (Canada)
 ```c#
 using(Culture.SwitchTo("en-CA", CulturePlacement.ThreadUiCulture))
 {
	// do your testing
 }
 ```

##### Change only the CurrentCulture to English (US)
 ```c#
 using(Culture.SwitchTo("en-US", CulturePlacement.ThreadCulture))
 {
	// do your testing
 }
 ```
 
### AssertAction

##### Assert a method throws an exception
 ```c#
 var argument = string.Empty;
 AssertAction.Throws<ArgumentException>(() => SomeMethodThatDoesntLikeStringEmpty(argument));
 ```
 
##### Assert a method throws an exception and passes a predicate
 ```c#
 var argument = string.Empty;
 AssertAction.Throws<ArgumentException>(
	() => SomeMethodThatDoesntLikeStringEmpty(argument), 
	e => e.Message == "We don't like empty strings, nulls are fine.");
 ```
 
### AssertAnonymous
 
##### Assert that an anonymous object has certain properties with certain values
 ```c#
 var anonymous = SomeMethodThatReturnsAnObject();
 AssertAnonymous.ContainsAll(new { Id = 0, Name = "First" }, anonymous);
 ```