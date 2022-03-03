//Strings

//just a collection of characters stored and used throughout an application in different ways
//almost any text, single character, or number can be a string

//in C# we can initialize string by using double quotes wrapped around the value

// 3 ways:

//concatenation 
//ex: 
string first = "the cars we sell are ";
string second = "BMW, Lexus, Mercedes";

string concatenationResult = first + " " + second;
//basically taking the variable and (+) them one to another
//we also added the " " as well

System.Console.WriteLine(concatenationResult);

// composite formating
//using {} inside of the string itself with a number inside of the braces
//ex:
string firstName = "Haley";
string lastName = "Zemkewicz";

//now we need to use string.Format method
string compositeResult = string.Format("Her name is {0} {1}", firstName, lastName);
System.Console.WriteLine(compositeResult);

//string interpolation
//allows you to simply put a variable directly into string
//ex:
string interpolationResult = $"Her name is still {firstName} {lastName}";
System.Console.WriteLine(interpolationResult);


//challenge
//practice these three ways of joining strings (3) more examples of each

