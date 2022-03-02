//C# TYPES
//bool -> true or false
bool isLoggedIn = true;
System.Console.WriteLine(isLoggedIn);

//integers or int -> these are whole numbers
int age =42;
System.Console.WriteLine(age);

//decimal -> very precise
// need m suffix to show that it is a decimal
decimal accountBalance =9000.01m; //9_000_01m
System.Console.WriteLine(accountBalance);

int i = 0; //32 bit integer value **
short sh = 32767; //16 bit interger value 
Int16 anotherShortExample = 32000;
byte by = 255; //a group of binary digits (usually eight) operated as a unit 
string s = "hey!"; //collection of characters(this is a reference type, defaults to null) **
char c = 'i'; //represents a single character **
string s2 = @"a\tree"; //use the @ to specify a directory
bool b = false; //true or false value
long L = 7;  //is a LARGE integer, x2 more LARGE, 
            // -9_223_372_036_854_775_808 to 9_223_372_036_854_775_807
            //

decimal d = 99.999999m; // 'm' 128 bit percision with a range of 28-29 decimal places (MONEY)
double  db = 7.80000d; // 'd' has 15-16 digit precision with a 64 bit size
float f = 10.8f; // 'f' is sored in 32 bit, half size of a double
int? ni = null; // '?' after data type allows the vslye to be null, null means ni can have value or be nothing

//dealing with decimals
//we can type as many decimal plces taht we want for a given type
//but thing shcnage during compile time (dotnet run....)
Console.WriteLine(1.2578907289045789789789789787897f);
Console.WriteLine(1.2578907289045789789789789787897d);
Console.WriteLine(1.2578907289045789789789789787897m);

//use our pastryTypes;
PastryType mypastry = PastryType.croissant;
PastryType anotherOne = PastryType.cake;

//All number types in C# are structs (value types)
//They are Emutable -> you cannot change its intitial value 
// the value of 4 is always 4. 
// they can be grabbed very quickly b/c they live on the stack

// a common struct is DateTime
DateTime Today = DateTime.Today;

// we can also make our own 'DateTime'
// using 'new' keyword -> allocating space in memory for this Date. 
DateTime birthDay = new DateTime(1996,03,20);







