
//Background story
Console.WriteLine("I dropped my Thing Namer 3000 and broke it./n");

//first question for the user
Console.WriteLine("What kind of thing are we talking about?");

// Asking the user to describe the object
string a = Console.ReadLine();

/* Ofeting informations to the user in order
 * to have him describe the object*/
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");

// Asking the user to describe the "thing"
string b = Console.ReadLine();

// String c variable
string c = "Doom"; // Modified to fix the "of of" bug.

/* The number. */
string d = "3000";

// The program is now writing the full description
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");