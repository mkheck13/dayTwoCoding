// we are going to do some C# testing in here


// lets start with a say hello 

// Console.WriteLine("What is your name good sir or maddam?");

// string namePlz = Console.ReadLine();

// Console.WriteLine("Well, hello there " + namePlz + " it's nice to meet you.");

// ok got the say hello working how I want for now
// time to do a add two numbers

// int num1 = 5;
// int num2 = 6;   

// int sum = num1 + num2;
// Console.WriteLine(num1 + " added to " + num2 + " equals " + sum);

// ok so we have it adding two numbers that are already choosen
// we now need to make it able to take in user input and return the sum

// clear the console each time so it doesn't get cluttered
Console.Clear();

// ask the user to enter a first number
Console.WriteLine("number 1");
string? num1 = Console.ReadLine();

// ask the user to enter a second number
Console.WriteLine("number 2");
string? num2 = Console.ReadLine();

// we could add some conformation to show the input numbers but I have that in the writeline that returns the sum of the numbers

// process to convert the numbers from strings to integer
// and add the numbers together to get the sum
int num1Con = Convert.ToInt32(num1);
int num2Con = Convert.ToInt32(num2);
int sum = num1Con + num2Con;

// have to console display the input numbers with the sum of them
Console.WriteLine("so " + num1Con + " plus " + num2Con + " equals " +  sum);

// this works but I need to have validation. if they enter the wrong format it returns a message stating so

