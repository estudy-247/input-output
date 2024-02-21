/****************************************************************
*************************** INPUT *******************************
****************************************************************/


//****** Getting a String Input​ ******

Console.WriteLine("Enter your name:");

//Type your name and press enter
string nameInput = Console.ReadLine();

Console.WriteLine("Hello, " + nameInput + "!"); // Prints the user's name



//****** Getting Numeric Input​ ******

Console.WriteLine("Enter your age:");

//Type your age and press enter
string ageInput = Console.ReadLine();
int age = Convert.ToInt32(ageInput); // Convert the string to an integer

Console.WriteLine("Your age is: " + age);


/****************************************************************
*************************** Output ******************************
****************************************************************/

//This method prints text followed by a newline character (moves to the next line).
Console.WriteLine("Hello World!");

//Similar to WriteLine() but without inserting a new line at the end of the output.
Console.Write("Hello Estudy247! ");
Console.Write("I would like to print the text on the same line.");
