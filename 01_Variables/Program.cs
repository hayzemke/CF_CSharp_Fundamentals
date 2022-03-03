// See https://aka.ms/new-console-template for more information

//firstName is CammelCased-> all words start w/ a capital letter except the initial word
//1       //2    //3   //4
string firstName  = "Scott";

//1 type
//2 variable name
//3 assignment operator
//4 value


Console.WriteLine(firstName);

Console.WriteLine("What is your favorite color?");
//declare a string called color and assigned it to the value returned from the
// Console.ReadLine() method.
string color= Console.ReadLine();

Console.WriteLine("You said your favorite color is "+ color);

//challenge:
Console.WriteLine("What is your name?");
firstName=Console.ReadLine();
Console.WriteLine($"Ok, so your name is {firstName}");
