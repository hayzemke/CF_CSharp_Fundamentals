//Conditionals
// handle making decisions within an application
//called conditionals bc they operate on specific conditions

//anytime we want an application to work a certain way base on any condition, we will use a conditional

//examples:
//if the user is logged in, redirect them to the log in page
//if its the user's birthday, happy birthday can be displayed to the user
//if the user does not have necessary role, then access can be denied

bool isRaining = true;
bool isGoingOutside = true;

//if statements:
//formula :
//given a boolean, if it equals to true, do the action given

//If statement syntax:
//If(true/false value)
//{
        //body of code, execute this vode if above value is true
//}

//basically:
//If(isRaining == true)   //both are the same
if (isRaining)
{
    System.Console.WriteLine("Its raining out!");
}

//multiple 'if' statements
if (isRaining && isGoingOutside)
{
    System.Console.WriteLine("Better bring an umbrella");
}


//not raining OR no not Going outside
if(!isRaining || isGoingOutside==false)
{
    System.Console.WriteLine("I do not need an umbrella.");
}

//Exclusively not raining OR going outside
if (isRaining ^ isGoingOutside)
{
    System.Console.WriteLine("I will only go outside if it is not raining.");
}

//Challenge
//write an if statement that uses a new boolean called 'hasUmbrella' that will display text
//to the Console if the user has an umbrella and is going outside while it's raining.
//Example of expected output:
// Good thing I have my umbrella so I can go outside while it's raining!

bool hasUmbrella = true;
if (hasUmbrella  && isGoingOutside && isRaining)
{
     System.Console.WriteLine("Good thing I have my umbrella so I can go outside while it's raining!");
}