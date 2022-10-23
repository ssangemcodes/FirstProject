// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your name please.");

string nameMessage = "Enter your name please."; //Give me a small space on memory to store a string variable
Console.WriteLine(nameMessage);

string name = Console.ReadLine(); // Hey user I am taking ur input here, so I am waiting

Console.WriteLine("Welcome to programming " + name); //appending welcome message to the name of the user and showing on the screen

string welcomeMessage = "Welcome to programming "; //declare and assign welcome message
string appendedOutput = welcomeMessage + name; //concatename welcome message and users name
Console.WriteLine(appendedOutput); //displaying on the screen