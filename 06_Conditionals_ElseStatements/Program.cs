//So when we make an if statement, what happens when conditions aren't met
//This is where we use the else keyword (default)

//example w/o the else statememnt
bool isRaining = true;

//check if the inverse if isRaining is true
if (isRaining)
{
    System.Console.WriteLine("i'll go cut the grass.");
}

//check if isRaining is true
if (isRaining)
{
    System.Console.WriteLine("I guess I can't cut the grass!");
}

//ex w/ else statement

if (!isRaining)
{
    System.Console.WriteLine("I will go cut the grass!");
}

else
{
    System.Console.WriteLine("i guess i cant go cut the grass");
}

//another example
bool isGoingOutside =true;

if (isGoingOutside)
{
    System.Console.WriteLine("make sure to dress for the weather");
}
else
{
    System.Console.WriteLine("sounds like a sweats kind of day");
}

//another example
if (isGoingOutside)
{
    System.Console.WriteLine("make sure to dress for the weather");
}

else if (isGoingOutside && isRaining)
{
    System.Console.WriteLine("make sure to dress for the weather if going outside when raining");
}
else if (isRaining)
{
    System.Console.WriteLine("sounds like a sweats kind of day");
}

if (isGoingOutside)
{
    if (isRaining)
    {
    System.Console.WriteLine("make sure to dress for the weather if going outside when raining");
    }
}

//Challenge
//If..Else If Statements
//We are going to ask the user how they are doing on a scale of 1-5, with 5 being the best.

System.Console.WriteLine("How are you doing? (1-5)");

//this changes the string value to an integer

int value = int.Parse(Console.ReadLine());
string value = (Console.ReadLine());

//We will run the nested if..else statements based on ther input with these responses:
if (value == "1")
{
    System.Console.WriteLine("dang, we hope your day gets better");
}

else if (value == "2")
{
    System.Console.WriteLine("Oh. Sorry to hear that.");
}

else if (value == "3")
{
    System.Console.WriteLine("Hope things improve!");
}

else if (value == "4")
{
    System.Console.WriteLine("Good stuff!");
}

else if (value == "5")
{
    System.Console.WriteLine("That's great to hear!");
}

else
{
    System.Console.WriteLine("invalid key entry");
}



//1. Dang. We hope your day gets better!
//2. Oh. Sorry to hear that.
//3. Hope things improve!
//4. Good stuff!
//5. That's great to hear!
