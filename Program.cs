// See https://aka.ms/new-console-template for more information

//File to store commonly used information
//string fname = "Brandon";
//string lname = "Welch";
//System.Console.WriteLine("Hello " + fname + " " + lname + "!");


using System;

class Program
{
    static void Main(string[] args)
    {
       string Yes = "Yes";
string PrintToScreen = "1";
string EscapeClause = "2";
string DotNetCommands = "3";
string GitCommands = "4";
string Variables = "5";
string Conditionals = "6";
string Loops = "7";
string Arrays = "8";
string Methods = "9";
string Classes = "10";

Console.WriteLine("\nHello, I am your Fundamentals HelpBot! Do you need help? [Yes | No]"); // \n in front to create a blank line between the prompt and the program
string? needHelp = Console.ReadLine(); //? gets rid of potential null warning

if (needHelp == Yes)
        {
            WelcomeMethod();

            string? topic = Console.ReadLine();

            if (topic == PrintToScreen) //turn this into a switch/case?
            {
                PrintToScreenMethod();
            }

            else if (topic == EscapeClause)
            {
                EscapeClauseMethod();
            }

            else if (topic == DotNetCommands)
            {
                DotNetCommandsMethod();
            }

            else if (topic == GitCommands)
            {
                GitCommandsMethod();
            }

            else if (topic == Variables)
            {
                VariablesMethod();
            }

            else if (topic == Conditionals)
            {
                ConditionalsMethod();
            }

            else if (topic == Loops)
            {
                LoopsMethod();
            }


            else if (topic == Arrays)
            {
                ArraysMethod();
            }

            else if (topic == Methods)
            {
                MethodsMethod();
            }

            else if (topic == Classes)
            {
                ClassesMethod();
            }

            else
            {
                Console.WriteLine("\nSorry, I am unable to assist!\n\n");
            }

        }
        else
    {
        //Need Help = No
        Console.WriteLine("\nOk, have a great day!\n\n");
    }

    }

    private static void ClassesMethod()
    {
        Console.WriteLine("\nClasses");
        Console.WriteLine("\t Random Classes Info");
    }

    private static void MethodsMethod()
    {
        Console.WriteLine("\nMethods");
        Console.WriteLine("\t Random Methods Info");
    }

    private static void ArraysMethod()
    {
        Console.WriteLine("\nArrays");
        Console.WriteLine("\t Random Arrays Info");
    }

    private static void LoopsMethod()
    {
        Console.WriteLine("\nLoops");
        Console.WriteLine("\t Random Loops Info");
    }

    private static void ConditionalsMethod()
    {
        Console.WriteLine("\nConditionals");
        Console.WriteLine("\t Random Conditionals Info");
    }

    private static void VariablesMethod()
    {
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
                    Console.WriteLine("\t\t\t int num = 1 + 2");
                    Console.WriteLine("\t\t\t int num = 1 - 2");
                    Console.WriteLine("\t\t\t int num = 1 * 2");
                    Console.WriteLine("\t\t\t int num = 1 / 2");
                    Console.WriteLine("\t\t\t int num = 1 % 2");
                Console.WriteLine("\t\t Augmented (Compound) Assignment Operators");
                    Console.WriteLine("\t\t\t int num3 * 3 -> won't execute");
                    Console.WriteLine("\t\t\t int num3 = num3 * 3 -> Preferred Method, Right Side calculates and assigns new value back to num3");
                    Console.WriteLine("\t\t\t int result = num3 * 3 -> Alternate Method but involves an additional variable to assign the new value");
                    Console.WriteLine("\t\t\t int num3 += 5 -> same as int num3 = num3 + 5");
                    Console.WriteLine("\t\t\t int num3 -= 5");
                    Console.WriteLine("\t\t\t int num3 *= 5");
                    Console.WriteLine("\t\t\t int num3 /= 5");
                    Console.WriteLine("\t\t\t int num3 %= 5");
                Console.WriteLine("\t\t Increment / Decrement Operators");
                    Console.WriteLine("\t\t\t num3++ -> Adds EXACTLY 1 -> shorthand for num3 += 1 -> shorthand for num3 = num3 + 1");
                    Console.WriteLine("\t\t\t ++num3 -> Adds EXACTLY 1");
                    Console.WriteLine("\t\t\t num3-- -> Subtracts EXATLY 1");
                    Console.WriteLine("\t\t\t --num3 -> Subtracts EXATLY 1");
                        Console.WriteLine("\t\t\t\t num3++ // Post-Increment (Will increment AFTER the variable is used)");
                        Console.WriteLine("\t\t\t\t ++num3 // Pre-Increment (Will increment BEFORE the variable is used)");
                Console.WriteLine("\t\t Booleans");
                    Console.WriteLine("\t\t\t Value type that stores either 'True' OR 'False'");
                        Console.WriteLine("\t\t\t\t bool isSunny = true;");
                            Console.WriteLine("\t\t\t\t\t Console.WriteLine(isSunny); -> True;");
                        Console.WriteLine("\t\t\t\t bool isRainy = false;");
                        Console.WriteLine("\t\t\t\t\t Console.WriteLine(isRainy); -> False;");
                    Console.WriteLine("\t\t\t ! -> null/Negation Operator -> change boolean into its 'opposite' value");
                        Console.WriteLine("\t\t\t\t bool Console.WriteLine(!isSunny); -> False;");
                    Console.WriteLine("\t\t\t A toggle -> switch boolean value to the over boolean value True>False or False>True");
                        Console.WriteLine("\t\t\t\t isSunny = !isSunny; -> Changed True -> False");
                Console.WriteLine("\t\t Relational Operators");
                    Console.WriteLine("\t\t\t == Equal -> checks if the 2 values equal each other");
                    Console.WriteLine("\t\t\t =! Not Equal");
                    Console.WriteLine("\t\t\t < Greater Than");
                    Console.WriteLine("\t\t\t > Less Than");
                    Console.WriteLine("\t\t\t <= Greater Than OR Equal To");
                    Console.WriteLine("\t\t\t >= Less Than OR Equal To");
    }

    private static void GitCommandsMethod()
    {
        Console.WriteLine("\nCommon GIT Commands");
            Console.WriteLine("\t Git -v | -version -> provides version");
            Console.WriteLine("\t Git -help | -h -> help");
            Console.WriteLine("\t Git config -> configure git");
                Console.WriteLine("\t\t Git config --list -> see a list of current config settings");
                Console.WriteLine("\t\t Git config --global -> changes config for entire machine, not just current directory");
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
    }

    private static void DotNetCommandsMethod()
    {
        Console.WriteLine("\nCommon .NET Commands");
            Console.WriteLine("\t dotnet --version -> confirms what version of dotnet you are using, helpful for 'proving' you have the .NET SDK installed");
            Console.WriteLine("\t dotnet new xxx -> scaffolds a new project (xxx is just a placeholder)");
                Console.WriteLine("\t\t Examples");
                    Console.WriteLine("\t\t\t dotnet new console -> create new console app project");
                    Console.WriteLine("\t\t\t dotnet new console -n HelloWorld -> create new console app project with name 'HelloWorld'");
                    Console.WriteLine("\t\t\t dotnet new gitignore -> create new .NET specific gitignore file");
            Console.WriteLine("\t dotnet run -> clean, restore, build, and run the project");
            Console.WriteLine("\t dotnet add package <package name> -> adds packaged dependency to your project (.csproj file)");
    }

    private static void EscapeClauseMethod()
    {
        Console.WriteLine("\nEscape Clauses");
            Console.WriteLine("\t Backslash n represents a new line break as seen by the blank line below this \n"); // \n is an escape character -> represents new line
            Console.WriteLine("\t Backslash t represents a tab \t <- as seen to the left of the arrow"); // \t is an escape character -> represents tab
            Console.WriteLine("\t \"Backslash Quotation Mark\" represents Double Quotes when placed before and after the intended text to be inside quotations"); // \" is an escape character -> represents quotation mark
                Console.WriteLine("\t\t \"Backslash Quotation Mark, if not placed before and after will only display the single quotation at the beginning"); // \" is an escape character -> represents quotation mark
            Console.WriteLine("\t Double Backlashes represent adding a single backslash\\"); // \\ is an escape character -> represents adding a backslash 
    }

    private static void PrintToScreenMethod()
    {
        Console.WriteLine("\nPrint to screen");
            Console.WriteLine("\t Console.WriteLine(\"some text\") prints to screen and generates a line break");
            Console.Write("\t Console.Write(\"some text\") prints to screen but does not generate a line break");
                Console.WriteLine("AS you can tell since this text is stacked right on the last word from the prior .Write \"break\"");
            Console.Write("\t Thread.Sleep(xx); will create a pause in milliseconds (xx) before next command runs");
    }

    private static void WelcomeMethod()
    {
        Console.WriteLine("\nWhat can I help you with?\n");
            Console.WriteLine("\t 1) Print to screen");
            Console.WriteLine("\t 2) Escape clauses");
            Console.WriteLine("\t 3) Common dotnet commands");
            Console.WriteLine("\t 4) Common GIT commands");
            Console.WriteLine("\t 5) Common variables");
            Console.WriteLine("\t 6) Conditionals --PENDING--");
            Console.WriteLine("\t 7) Loops --PENDING--");
            Console.WriteLine("\t 8) Arrays --PENDING--");
            Console.WriteLine("\t 9) Methods --PENDING--");
            Console.WriteLine("\t10) Classes --PENDING--");
            Console.WriteLine("\t11)  --PENDING--");
            Console.WriteLine("\t12)  --PENDING--");
            Console.WriteLine("\t13)  --PENDING--");
            Console.WriteLine("\t14)  --PENDING--");
            Console.WriteLine("\t15)  --PENDING--");
    }
}





// string Yes = "Yes";
// string PrintToScreen = "1";
// string EscapeClause = "2";
// string DotNetCommands = "3";
// string GitCommands = "4";
// string Variables = "5";
// string Conditionals = "6";
// string Loops = "7";
// string Arrays = "8";
// string Methods = "9";
// string Classes = "10";

// Console.WriteLine("\nHello, I am your Fundamentals HelpBot! Do you need help? [Yes | No]"); // \n in front to create a blank line between the prompt and the program
// string needHelp = Console.ReadLine();

// if (needHelp == Yes)
// {

//     Console.WriteLine("\nWhat can I help you with?\n");
//         Console.WriteLine("\t 1) Print to screen");
//         Console.WriteLine("\t 2) Escape clauses");
//         Console.WriteLine("\t 3) Common dotnet commands");
//         Console.WriteLine("\t 4) Common GIT commands");
//         Console.WriteLine("\t 5) Common variables");
//         Console.WriteLine("\t 6) Conditionals --PENDING--");
//         Console.WriteLine("\t 7) Loops --PENDING--");
//         Console.WriteLine("\t 8) Arrays --PENDING--");
//         Console.WriteLine("\t 9) Methods --PENDING--");
//         Console.WriteLine("\t10) Classes --PENDING--");
//         Console.WriteLine("\t11)  --PENDING--");
//         Console.WriteLine("\t12)  --PENDING--");
//         Console.WriteLine("\t13)  --PENDING--");
//         Console.WriteLine("\t14)  --PENDING--");
//         Console.WriteLine("\t15)  --PENDING--");

// string topic = Console.ReadLine();

//     if (topic == PrintToScreen) //turn this into a switch/case?
//         {
//             //make this whole thing a Method? 
//             Console.WriteLine("\nPrint to screen");
//             Console.WriteLine("\t Console.WriteLine(\"some text\") prints to screen and generates a line break");
//             Console.Write("\t Console.Write(\"some text\") prints to screen but does not generate a line break");
//             Console.WriteLine("AS you can tell since this text is stacked right on the last word from the prior .Write \"break\"");
//         }

//     else if (topic == EscapeClause)
//         {
//             Console.WriteLine("\nEscape Clauses");
//             Console.WriteLine("\t Backslash n represents a new line break as seen by the blank line below this \n"); // \n is an escape character -> represents new line
//             Console.WriteLine("\t Backslash t represents a tab \t <- as seen to the left of the arrow"); // \t is an escape character -> represents tab
//             Console.WriteLine("\t \"Backslash Quotation Mark\" represents Double Quotes when placed before and after the intended text to be inside quotations"); // \" is an escape character -> represents quotation mark
//             Console.WriteLine("\t\t \"Backslash Quotation Mark, if not placed before and after will only display the single quotation at the beginning"); // \" is an escape character -> represents quotation mark
//             Console.WriteLine("\t Double Backlashes represent adding a single backslash\\"); // \\ is an escape character -> represents adding a backslash 
//         }
    
//     else if (topic == DotNetCommands)
//         {
//             Console.WriteLine("\nCommon .NET Commands");
//             Console.WriteLine("\t dotnet --version -> confirms what version of dotnet you are using, helpful for 'proving' you have the .NET SDK installed");
//             Console.WriteLine("\t dotnet new xxx -> scaffolds a new project (xxx is just a placeholder)");
//             Console.WriteLine("\t\t Examples");
//             Console.WriteLine("\t\t\t dotnet new console -> create new console app project");
//             Console.WriteLine("\t\t\t dotnet new console -n HelloWorld -> create new console app project with name 'HelloWorld'");
//             Console.WriteLine("\t\t\t dotnet new gitignore -> create new .NET specific gitignore file");
//             Console.WriteLine("\t dotnet run -> clean, restore, build, and run the project");
//             Console.WriteLine("\t dotnet add package <package name> -> adds packaged dependency to your project (.csproj file)");
//         }

//     else if (topic == GitCommands)
//         {
//             Console.WriteLine("\nCommon GIT Commands");
//             Console.WriteLine("\t Git -v | -version -> provides version");
//             Console.WriteLine("\t Git -help | -h -> help");
//             Console.WriteLine("\t Git config -> configure git");
//             Console.WriteLine("\t\t\t Git config --list -> see a list of current config settings");
//             Console.WriteLine("\t\t\t Git config --global -> changes config for entire machine, not just current directory");
//             Console.WriteLine("\t Git clone <url> -> Clones a repo");
//             Console.WriteLine("\t Git status -> Provides current status of .git file in current directory");
//             Console.WriteLine("\t\t Shows untracked files if things have not been staged");
//             Console.WriteLine("\t Git add xxx -> To Stage files");
//             Console.WriteLine("\t\t Git add <filename.ext> -> Stages specific file");
//             Console.WriteLine("\t\t Git add . -> Stages all files in the current directory");
//             Console.WriteLine("\t\t Git add .. -> Stages all files in the Parent directory");
//             Console.WriteLine("\t Git status -> Provides current status of .git file in current directory");
//             Console.WriteLine("\t\t Shows untracked files if things have not been committed");
//             Console.WriteLine("\t Git commit -m \"random message\" ->  Commits files LOCALLY");
//             Console.WriteLine("\t Git status -> Provides current status of .git file in current directory");
//             Console.WriteLine("\t\t Shows if Local branch is AHEAD and if anything is left to commit");
//             Console.WriteLine("\t Git push ->  Commits files to CENTRAL REPO from LOCAL");
//             Console.WriteLine("\t Git status -> Provides current status of .git file in current directory");
//             Console.WriteLine("\t\t Shows how many objects were written and to which REPO it was commited");
//             Console.WriteLine("\t Git fetch ->  Checks CENTRAL REPO to Local for changes");
//             Console.WriteLine("\t Git status -> Provides current status of .git file in current directory");
//             Console.WriteLine("\t\t Shows if Local branch is BEHIND and if anything is left to commit");
//             Console.WriteLine("\t Git pull ->  Commits files to LOCAL from CENTRAL REPO");
//             Console.WriteLine("\t Git status -> Provides current status of .git file in current directory");
//         }

//     else if (topic == Variables)
//         {
//             Console.WriteLine("\nCommon Variables");
//             Console.WriteLine("\t Variables should be camelCasing");
//             Console.WriteLine("\t Syntax: variableName = value (Ex. numberOfBooks = 10 | num | etc.)");
//             Console.WriteLine("\t Variable Declaration: DataType variableName = value (Ex. int numberOfBooks = 10 | num | etc.)");
//             Console.WriteLine("\t Common Variables");
//             Console.WriteLine("\t\t Numerical Value Types");
//             Console.WriteLine("\t\t\t sbyte -> whole number");
//             Console.WriteLine("\t\t\t byte -> whole number");
//             Console.WriteLine("\t\t\t short -> whole number");
//             Console.WriteLine("\t\t\t ushort -> whole number");
//             Console.WriteLine("\t\t\t int -> whole number***");
//             Console.WriteLine("\t\t\t uint -> whole number");
//             Console.WriteLine("\t\t\t long -> whole number***");
//             Console.WriteLine("\t\t\t ulong -> whole number");
//             Console.WriteLine("\t\t\t float -> decimal number");
//             Console.WriteLine("\t\t\t double -> decimal number***");
//             Console.WriteLine("\t\t\t decimal -> decimal number");
//             Console.WriteLine("\t\t Non-Numerical Value Types");
//             Console.WriteLine("\t\t\t char -> character");
//             Console.WriteLine("\t\t\t bool -> Boolean expression which results in either True OR False");
//             Console.WriteLine("\t\t\t enum -> enumerator");
//             Console.WriteLine("\t\t\t struct -> ");
//             Console.WriteLine("\t Common Variables Operations");
//             Console.WriteLine("\t\t Basic Operators");
//             Console.WriteLine("\t\t\t int num = 1 + 2");
//             Console.WriteLine("\t\t\t int num = 1 - 2");
//             Console.WriteLine("\t\t\t int num = 1 * 2");
//             Console.WriteLine("\t\t\t int num = 1 / 2");
//             Console.WriteLine("\t\t\t int num = 1 % 2");
//             Console.WriteLine("\t\t Augmented (Compound) Assignment Operators");
//             Console.WriteLine("\t\t\t int num3 * 3 -> won't execute");
//             Console.WriteLine("\t\t\t int num3 = num3 * 3 -> Preferred Method, Right Side calculates and assigns new value back to num3");
//             Console.WriteLine("\t\t\t int result = num3 * 3 -> Alternate Method but involves an additional variable to assign the new value");
//             Console.WriteLine("\t\t\t int num3 += 5 -> same as int num3 = num3 + 5");
//             Console.WriteLine("\t\t\t int num3 -= 5");
//             Console.WriteLine("\t\t\t int num3 *= 5");
//             Console.WriteLine("\t\t\t int num3 /= 5");
//             Console.WriteLine("\t\t\t int num3 %= 5");
//             Console.WriteLine("\t\t Increment / Decrement Operators");
//             Console.WriteLine("\t\t\t num3++ -> Adds EXACTLY 1 -> shorthand for num3 += 1 -> shorthand for num3 = num3 + 1");
//             Console.WriteLine("\t\t\t ++num3 -> Adds EXACTLY 1");
//             Console.WriteLine("\t\t\t num3-- -> Subtracts EXATLY 1");
//             Console.WriteLine("\t\t\t --num3 -> Subtracts EXATLY 1");
//             Console.WriteLine("\t\t\t\t num3++ // Post-Increment (Will increment AFTER the variable is used)");
//             Console.WriteLine("\t\t\t\t ++num3 // Pre-Increment (Will increment BEFORE the variable is used)");
//             Console.WriteLine("\t\t Booleans");
//             Console.WriteLine("\t\t\t Value type that stores either 'True' OR 'False'");
//             Console.WriteLine("\t\t\t\t bool isSunny = true;");
//             Console.WriteLine("\t\t\t\t\t Console.WriteLine(isSunny); -> True;");
//             Console.WriteLine("\t\t\t\t bool isRainy = false;");
//             Console.WriteLine("\t\t\t\t\t Console.WriteLine(isRainy); -> False;");
//             Console.WriteLine("\t\t\t ! -> null/Negation Operator -> change boolean into its 'opposite' value");
//             Console.WriteLine("\t\t\t\t bool Console.WriteLine(!isSunny); -> False;");
//             Console.WriteLine("\t\t\t A toggle -> switch boolean value to the over boolean value True>False or False>True");
//             Console.WriteLine("\t\t\t\t isSunny = !isSunny; -> Changed True -> False");
//             Console.WriteLine("\t\t Relational Operators");
//             Console.WriteLine("\t\t\t == Equal -> checks if the 2 values equal each other");
//             Console.WriteLine("\t\t\t =! Not Equal");
//             Console.WriteLine("\t\t\t < Greater Than");
//             Console.WriteLine("\t\t\t > Less Than");
//             Console.WriteLine("\t\t\t <= Greater Than OR Equal To");
//             Console.WriteLine("\t\t\t >= Less Than OR Equal To");
//         }

//     else if (topic == Conditionals)
//         {
//             Console.WriteLine("\nConditionals");
//             Console.WriteLine("\t Random Conditionals Info");
//         }

//     else if (topic == Loops)
//         {
//             Console.WriteLine("\nLoops");
//             Console.WriteLine("\t Random Loops Info");
//         }


//     else if (topic == Arrays)
//         {
//             Console.WriteLine("\nArrays");
//             Console.WriteLine("\t Random Arrays Info");
//         }

//     else if (topic == Methods)
//         {
//             Console.WriteLine("\nMethods");
//             Console.WriteLine("\t Random Methods Info"); 
//         }

//     else if (topic == Classes)
//         {
//             Console.WriteLine("\nClasses");
//             Console.WriteLine("\t Random Classes Info");
//         }

//     else
//         {
//             Console.WriteLine("\nSorry, I am unable to assist!\n\n");
//         }


/*
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
    Console.WriteLine("\t\t\t int num = 1 + 2");
    Console.WriteLine("\t\t\t int num = 1 - 2");
    Console.WriteLine("\t\t\t int num = 1 * 2");
    Console.WriteLine("\t\t\t int num = 1 / 2");
    Console.WriteLine("\t\t\t int num = 1 % 2");
    Console.WriteLine("\t\t Augmented (Compound) Assignment Operators");
    Console.WriteLine("\t\t\t int num3 * 3 -> won't execute");
    Console.WriteLine("\t\t\t int num3 = num3 * 3 -> Preferred Method, Right Side calculates and assigns new value back to num3");
    Console.WriteLine("\t\t\t int result = num3 * 3 -> Alternate Method but involves an additional variable to assign the new value");
    Console.WriteLine("\t\t\t int num3 += 5 -> same as int num3 = num3 + 5");
    Console.WriteLine("\t\t\t int num3 -= 5");
    Console.WriteLine("\t\t\t int num3 *= 5");
    Console.WriteLine("\t\t\t int num3 /= 5");
    Console.WriteLine("\t\t\t int num3 %= 5");
    Console.WriteLine("\t\t Increment / Decrement Operators");
    Console.WriteLine("\t\t\t num3++ -> Adds EXACTLY 1 -> shorthand for num3 += 1 -> shorthand for num3 = num3 + 1");
    Console.WriteLine("\t\t\t ++num3 -> Adds EXACTLY 1");
    Console.WriteLine("\t\t\t num3-- -> Subtracts EXATLY 1");
    Console.WriteLine("\t\t\t --num3 -> Subtracts EXATLY 1");
    Console.WriteLine("\t\t\t\t num3++ // Post-Increment (Will increment AFTER the variable is used)");
    Console.WriteLine("\t\t\t\t ++num3 // Pre-Increment (Will increment BEFORE the variable is used)");
    Console.WriteLine("\t\t Booleans");
    Console.WriteLine("\t\t\t Value type that stores either 'True' OR 'False'");
    Console.WriteLine("\t\t\t\t bool isSunny = true;");
    Console.WriteLine("\t\t\t\t\t Console.WriteLine(isSunny); -> True;");
    Console.WriteLine("\t\t\t\t bool isRainy = false;");
    Console.WriteLine("\t\t\t\t\t Console.WriteLine(isRainy); -> False;");
    Console.WriteLine("\t\t\t ! -> null/Negation Operator -> change boolean into its 'opposite' value");
    Console.WriteLine("\t\t\t\t bool Console.WriteLine(!isSunny); -> False;");
    Console.WriteLine("\t\t\t A toggle -> switch boolean value to the over boolean value True>False or False>True");
    Console.WriteLine("\t\t\t\t isSunny = !isSunny; -> Changed True -> False");
    Console.WriteLine("\t\t Relational Operators");
    Console.WriteLine("\t\t\t == Equal -> checks if the 2 values equal each other");
    Console.WriteLine("\t\t\t =! Not Equal");
    Console.WriteLine("\t\t\t < Greater Than");
    Console.WriteLine("\t\t\t > Less Than");
    Console.WriteLine("\t\t\t <= Greater Than OR Equal To");
    Console.WriteLine("\t\t\t >= Less Than OR Equal To");
*/

// }
//     else
//     {
//         Console.WriteLine("\nOk, have a great day!\n\n");
//     }
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
