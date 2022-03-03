using System.Collections.Generic;

//heres what not to do
object[] stuff = new object[5];
stuff[0] = "haley";
stuff[1] = 1;
stuff[2] = 44.75f;
stuff[3] = "Bill bob";

// WE NEED TYPE SAFETY!!!!!
//array -> THESE ARE ALWAYS FIXED VALUES, ALL COLLECTIONS START FROM ZERO
//nothing but a collection of 'char'
string stringExample = "hello world";

//array of type string
string[] stringArray = 
{
    "hello",
    "world",
    "why",
    "is it",
    "always",
    stringExample, 
    "?"
};


string thirdItem = stringArray[3]; // is it - is the output
System.Console.WriteLine(thirdItem);

//change the value of the first item in stringArray
stringArray[0]= "hey there";
System.Console.WriteLine(stringArray[0]);


// --Lists<T>
// can only be used with: systems.collections.generic (using statements)
List<string> listOfStrings = new List<string>();
List<int> listOfIntergers = new List<int>();
listOfStrings.Add("first string of our list");
listOfIntergers.Add(46210);

System.Console.WriteLine(listOfIntergers[0]);

//--Queues
//this is a line
//whoever is first in line is FIRST to be serviced

Queue<string> firstInFirstOut = new Queue<string>();

//this is to add to the queue 
firstInFirstOut.Enqueue("i'm first");
firstInFirstOut.Enqueue("i'm second");

//what we can do is 'see how is next in line'
string seeWhoIsNext = firstInFirstOut.Peek();
System.Console.WriteLine(seeWhoIsNext);

//removing an item:
//we cannot remove any item we want, 
//we can only remove who is first
string removedItem = firstInFirstOut.Dequeue();
System.Console.WriteLine($"removed : {removedItem}");

string whoIsNextInLine = firstInFirstOut.Peek();
System.Console.WriteLine(whoIsNextInLine);


// --Dictionaries <Tkey, Tvalue>
Dictionary<int,string> keyAndValue = new Dictionary<int, string>();

//ad to the dictionary
keyAndValue.Add(7,"agent");

string valueSeven = keyAndValue[7];
System.Console.WriteLine(valueSeven); //Agent

// --Other collections

SortedList<int,string> sortedKeyAndValue = new SortedList<int, string>();
HashSet<int> uniqueList = new HashSet<int>();
Stack<string> lastInFirstOut = new Stack<string>();

//-----------------------------------------------------------------------------------------------------


//How to deal with random numbers
//give me number between 5 and 7
//5 is includsive and 7 is exclusive 
Random rng = new Random();

int randomNumber = rng.Next(5,7);
System.Console.WriteLine(randomNumber);
