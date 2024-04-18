﻿// See https://aka.ms/new-console-template for more information

//File to store commonly used information


Console.WriteLine("\nI hope this helps!\n\n"); // \n in front to create a blank line between the prompt and the program


Console.WriteLine("Print to screen");
Console.WriteLine("\t Console.WriteLine(\"some text\") prints to screen and generates a line break");
Console.Write("\t Console.Write(\"some text\") prints to screen but does not generate a line break");
Console.WriteLine("AS you can tell since this text is stacked right on the last word from the prior .Write \"break\"");

Console.WriteLine("\nEscape Clauses");
Console.WriteLine("\t Backslash n represents a new line break as seen by the blank line below this \n"); // \n is an escape character -> represents new line
Console.WriteLine("\t Backslash t represents a tab \t <- as seen to the left of the arrow"); // \t is an escape character -> represents tab
Console.WriteLine("\t \"Backslash Quotation Mark\" represents Double Quotes when placed before and after the intended text to be inside quotations"); // \" is an escape character -> represents quotation mark
Console.WriteLine("\t\t \"Backslash Quotation Mark, if not placed before and after will only display the single quotation at the beginning"); // \" is an escape character -> represents quotation mark
Console.WriteLine("\t Double Backlashes represent adding a single backslash\\"); // \\ is an escape character -> represents adding a backslash

Console.WriteLine("\nCommon .NET Commands");
Console.WriteLine("\t dotnet --version -> confirms what version of dotnet you are using, helpful for 'proving' you have the .NET SDK installed");
Console.WriteLine("\t dotnet new xxx -> scaffolds a new project (xxx is just a placeholder)");
Console.WriteLine("\t\t Examples");
Console.WriteLine("\t\t\t dotnet new console -> create new console app project");
Console.WriteLine("\t\t\t dotnet new console -n HelloWorld -> create new console app project with name 'HelloWorld'");
Console.WriteLine("\t\t\t dotnet new gitignore -> create new .NET specific gitignore file");
Console.WriteLine("\t dotnet run -> clean, restore, build, and run the project");
Console.WriteLine("\t dotnet add package <package name> -> adds packaged dependency to your project (.csproj file)");

Console.WriteLine("\nCommon GIT Commands");
Console.WriteLine("\t Git -v | -version -> provides version");
Console.WriteLine("\t Git -help | -h -> help");
Console.WriteLine("\t Git config -> configure git");
Console.WriteLine("\t\t\t Git config --list -> see a list of current config settings");
Console.WriteLine("\t\t\t Git config --global -> changes config for entire machine, not just current directory");
Console.WriteLine("\t Git clone <url> -> Clones a repo");
Console.WriteLine("\t Git status -> Provides current status of .git file in current directory");
Console.WriteLine("\t\t Shows untracked files if things have not been staged");
Console.WriteLine("\t Git add xxx -> To Stage files");
Console.WriteLine("\t\t Git add <filename.ext> -> Stages specific file");
Console.WriteLine("\t\t Git add . -> Stages all files in the current directory");
Console.WriteLine("\t\t Git add .. -> Stages all files in the Parent directory");
Console.WriteLine("\t Git status -> Provides current status of .git file in current directory");
Console.WriteLine("\t\t Shows untracked files if things have not been committed");
Console.WriteLine("\t Git commit -m \"random message\" ->  Commits files LOCALLY");
Console.WriteLine("\t Git status -> Provides current status of .git file in current directory");
Console.WriteLine("\t\t Shows if Local branch is AHEAD and if anything is left to commit");
Console.WriteLine("\t Git push ->  Commits files to CENTRAL REPO from LOCAL");
Console.WriteLine("\t Git status -> Provides current status of .git file in current directory");
Console.WriteLine("\t\t Shows how many objects were written and to which REPO it was commited");
Console.WriteLine("\t Git fetch ->  Checks CENTRAL REPO to Local for changes");
Console.WriteLine("\t Git status -> Provides current status of .git file in current directory");
Console.WriteLine("\t\t Shows if Local branch is BEHIND and if anything is left to commit");
Console.WriteLine("\t Git pull ->  Commits files to LOCAL from CENTRAL REPO");
Console.WriteLine("\t Git status -> Provides current status of .git file in current directory");

Console.WriteLine("\nCommon Variables");
Console.WriteLine("\t Variables should be camelCasing");
Console.WriteLine("\t Syntax: variableName = value (Ex. numberOfBooks = 10 | num | etc.)");
Console.WriteLine("\t Variable Declaration: DataType variableName = value (Ex. int numberOfBooks = 10 | num | etc.)");
Console.WriteLine("\t Common Variables");
Console.WriteLine("\t\t Numerical Value Types");
Console.WriteLine("\t\t\t sbyte -> whole number");
Console.WriteLine("\t\t\t byte -> whole number");
Console.WriteLine("\t\t\t short -> whole number");
Console.WriteLine("\t\t\t ushort -> whole number");
Console.WriteLine("\t\t\t int -> whole number***");
Console.WriteLine("\t\t\t uint -> whole number");
Console.WriteLine("\t\t\t long -> whole number***");
Console.WriteLine("\t\t\t ulong -> whole number");
Console.WriteLine("\t\t\t float -> decimal number");
Console.WriteLine("\t\t\t double -> decimal number***");
Console.WriteLine("\t\t\t decimal -> decimal number");
Console.WriteLine("\t\t Non-Numerical Value Types");
Console.WriteLine("\t\t\t char -> character");
Console.WriteLine("\t\t\t bool -> Boolean expression which results in either True OR False");
Console.WriteLine("\t\t\t enum -> enumerator");
Console.WriteLine("\t\t\t struct -> ");
Console.WriteLine("\t Common Variables Operations");
Console.WriteLine("\t\t Basic Operators");
Console.WriteLine("\t\t\t int num = 1 + 2;");
Console.WriteLine("\t\t\t int num = 1 - 2;");
Console.WriteLine("\t\t\t int num = 1 * 2;");
Console.WriteLine("\t\t\t int num = 1 / 2;");
Console.WriteLine("\t\t\t int num = 1 % 2;");
Console.WriteLine("\t\t Augmented (Compound) Assignment Operators");
Console.WriteLine("\t\t\t int num3 * 3; -> won't execute");
Console.WriteLine("\t\t\t int num3 = num3 * 3; -> Preferred Method, Right Side calculates and assigns new value back to num3");
Console.WriteLine("\t\t\t int result = num3 * 3; -> Alternate Method but involves an additional variable to assign the new value");




/*
future use

Console.WriteLine("What can I help you with? \n");

Console.WriteLine("Print to screen");           //Variable for input
Console.WriteLine("\nEscape Clauses");          //Variable for input
Console.WriteLine("\nCommon .NET Commands");    //Variable for input
Console.WriteLine("\nCommon GIT Commands");    //Variable for input



If 

Print to Screen
Return Lines

Escape Clause
Return Lines

Common .NET Commands
Return Lines

Common GIT Commands
Return Lines

Else
Return "I am unable to assist with <user input> at this time. Please select from the available options or refer to an online search engine."
*/ 