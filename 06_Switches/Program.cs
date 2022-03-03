//has 3 parts
//'switch' keyword- glorified if statement
// value that is being evaluated

//'case' keyword, indicate a new block of code to be executed if that value matches the given case

//'break' keyword- indicates the end of case

//'default' keyword- which will run if all else fails

//example:
//string name = Console.ReadLine();

//we are going to 'switch' on the value 'name'
//switch (name)
//{
  //  case "Pete":
    //case "pete":
    //code that runs if name == pete
    //System.Console.WriteLine("hi pete!");
    //break;

    //default:
    //code that runs if all else fails
    //System.Console.WriteLine("invalid option");
    //break;
//}

//real example:
System.Console.WriteLine("how are you feeling today (1-5)");
string feelingRating = Console.ReadLine();

switch(feelingRating)
{
    case "5":
    System.Console.WriteLine("thats great to hear!");
    break;

    case "4":
    System.Console.WriteLine("good stuff");
    break;

    case "3":
    System.Console.WriteLine("hope things improve!");
    break;

    case "2":
    System.Console.WriteLine("oh. sorry to hear that.");
    break;

    case "1":
    System.Console.WriteLine("dang. hope your day gets better!");
    break;

    default:
    System.Console.WriteLine("sorry we don't understand. please try again later.");
    break;
}

//Challenge 
//Creating a switch statement
//want to output discriptions for a few of your friends

System.Console.WriteLine("what is your friend's name?");
string ans = Console.ReadLine();

switch (ans)
{
    case "John":
    case "john":
    System.Console.WriteLine("husband");
    break;

    case "Jess":
    case "jess":
    System.Console.WriteLine("blonde");
    break;

    case "Jessica":
    case "jessica":
    System.Console.WriteLine("brunette");
    break;

    default:
    System.Console.WriteLine("invalid response. please try again later!");
    break;

}

//Prompt the user's input to enter a friends name
//Take in a user's input from the Console
//If the input is one of the listed friends write a fact about that person to the Console

//Extra Challenge:
// what can you do with cases like "Paul" and "paul" as these are different values


