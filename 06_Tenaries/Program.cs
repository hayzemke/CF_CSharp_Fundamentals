//Ternary expressions
//conditional operator
//composed of three parts

//syntax looks like

//     1                    2                   3
//boolean expression ? expression if true : expression if false

//3 parts
//1. boolean expression to be evaluated
//2. separate boolean and true result
//3. separate true and false results

//ex:
System.Console.WriteLine("enter your age: ");
string response = Console.ReadLine();
int age = int.Parse(response);

//output:
string output = (age >=18)? "you can vote!" : "you're too young to vote!";
// can or cannot use paresthesias

Console.WriteLine(output);



