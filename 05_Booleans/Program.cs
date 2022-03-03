//Booleans

// can hold true or false values

bool isCool = false;
isCool = true;

//Booleant logical operators
//operators that pefaorm logical operations and assessments
//these use keywords AND, OR, NOT, etc.

//NOT
//C# has logical negation operator or more commonly know as the bang operator 
// "!iscool" evaluates to the opporiste of whatever value isCool is holding

//And
//C# uses ampersands (&) to indicate AND statements 
//single & - evaluates both conditions always
//double & - only evaluates the right side if required

//OR
//C# uses pipes (|) to indicate OR statements
// similar to AND, one | check both, two || evaluates left ->right

//XOR
//C# uses the caret character (^) indicated exclusive OR statements
// --Boolean Logical Operators
//Negation operator
bool isTrue = !false; //true
bool isFalse = !true; //false

//And Operator
bool trueAndExample = true && true; // true -> both of these HAVE to be true!
bool falseAndExample = true && false; // false

//Or operator
bool trueOrExample = true || false; //only one of these have to pass!
bool falseOrExample = false || false; //

//XOR operator
bool trueExclusiveOR = true ^ false; //true
bool falseExclusiveOR2 = false ^ false; //false

System.Console.WriteLine($"NOT False = {isTrue}") ; 
System.Console.WriteLine($"False AND True = {falseAndExample}");
System.Console.WriteLine($"True OR True = {trueOrExample}");
System.Console.WriteLine($"True XOR True = {trueExclusiveOR}");
System.Console.WriteLine($"False XOR False = {falseExclusiveOR2}");


//comparison operators
//Equal
//to decalare the values are equal, you must use TWO equal signs (==)

//not equal
//C# we use (!=) to indicate the values given are not equal

//greater than 
//C# we use (>) indicates greater than 
//evaluates to true is the left side if indeed greater than right

//greater than or equal
//C# use the (>=) operator
//uses angle bracket but uses equal sign to end or indicate that it can include this value

//less than
//C# uses (<) indicates less than

//less than or equal 
//C# uses (<=) 

//examples
//examples

bool isGreaterThan = 10 > 10;
bool isGreaterThanOrEqualTo = 10 >= 10;
System.Console.WriteLine($"10 > 10 is {isGreaterThan}, and 10 >= 10 is {isGreaterThanOrEqualTo}");


bool isLessThan = 5 < 5;
bool isLessThanOrEqualTo = 5 <= 5;

System.Console.WriteLine($"5 < 5 is {isLessThan}, while 5 <= 5 is {isLessThanOrEqualTo}");




bool equality = 17 == 9;
bool inequality = 17 !=9;
System.Console.WriteLine($"17 == 9 and 17 != 9 are {equality} and {inequality}, respectively.");