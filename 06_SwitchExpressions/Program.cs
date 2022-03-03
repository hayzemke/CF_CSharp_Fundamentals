//syntax
//value being evaluated, often a variable
//switch keyword
//body that contains 'cases', called "expression arms" - denoted by {}
//comma separated by 'expression arms' are made up of 3 parts
    //1. expected value, called "pattern"
    //2. a fat arrow, denoted as => 
    //3. actual expression or value to be returned
//discard pattern, denoted with an "_" which is default

//switch expressions
System.Console.WriteLine("Please enter a username:");
string userName = Console.ReadLine();
string greeting = userName switch
{
    "pete" => "hello pete",  //value that returns if that variable userName has value of pete
    _ => "who are you" //return value for every other posttible value
};

System.Console.WriteLine(greeting);


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

System.Console.WriteLine("how were you feeling yesterday? (1-5)");
string ratingInput = Console.ReadLine();

//we want to 'transform' ratingInput to an int

int yesterdayRating = int.Parse(ratingInput);

string response = yesterdayRating switch
{
    1=>"dang. we hope today is a better day",
    2=>"oh, sorry to hear that",
    3=>"hopefully things will get better this week",
    4=>"good stuff",
    5=>"great to hear!",
    _ => "thats off the charts"
};
System.Console.WriteLine(response);


//Challenge 
//We have 2 questions in our code:
//"How are you feeling today?
//"How were you feeling yesterday?

//we got 2 variables
//feelingRating
//yesterdayRating

//The challenge is to compare these two values and display how much better or worse 
//they are feeling today than yesterday.

//you don't have to use switch expressions for this challenge.
//use whatever works for you.

//Tools you should think about using:
//Converting strings to numbers
//Comparison Operators
//Conditionals