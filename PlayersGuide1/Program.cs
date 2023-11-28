// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.Title = "Questionnaire?"; //Sets the title of the console window.
string fName, lName;
Console.WriteLine("Enter your First Name...");
fName=Console.ReadLine();
Console.WriteLine("Enter your Last Name...");
lName = Console.ReadLine();
Console.WriteLine("Hi " + fName + " " + lName);

string favoriteColor;
Console.WriteLine("Enter your Favorite Color...");
favoriteColor =Console.ReadLine();
Console.WriteLine("Your Favorite Color is " + favoriteColor);


//int score = "0"; Doesnt compile, can't toss a string into an int slot.

//int score =0;

Console.WriteLine("Press any key to continue....");
Console.ReadKey(true);
//Console.Beep(440, 1000); Does just that.

//Console.BackgroundColor changes the background color of the text
//Console.ForegroundColor changes the color of the text

Console.Clear(); //Clears all text in console

Console.WriteLine("C:\\Users\\RB\\Desktop\\MyFile.txt"); // Posts C:\Users\RB\Desktop\Myfile.txt to console. \ would normally start an escape sequence, but the second \ allows it to post as a literal.
Console.WriteLine(@"C:\Users\RB\Desktop\MyFile.txt"); //Same as above without the extra \'s

int myFavoriteNumber = 0;
Console.WriteLine($"My favorite number is {myFavoriteNumber}."); //Basic string interpolation


Console.WriteLine($"#1: {fName,-20} - 1");
Console.WriteLine($"#2: {lName,-20} - 2");
//The code reserves 20 characters for the name line, if the numerical value is positive, the white space will appear before the text, if negative, after the text.

Console.WriteLine($"{Math.PI:0.000}"); //to format something in console, place a : and then the format string, in this example = "0.000"


float currentHealth = 4;
float maxHealth = 9;
Console.WriteLine($"{currentHealth / maxHealth:0.0%}"); // Displays "44.4%"
//using "P" for format equates to 0.00% and "P1" 0/0%, where "F" = 0.00 string and "F5"=0.00000
