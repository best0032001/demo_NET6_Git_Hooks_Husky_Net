

using System.Text.RegularExpressions;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("format-linter");


 foreach (String filename in Args)
 {
   Console.WriteLine(filename);
       var msg = File.ReadAllLines(filename);
    Console.WriteLine("linenumber");
    Console.WriteLine(msg.Length);
    for(int j=0;j<msg.Length;j++)
    {
        Console.WriteLine(msg[j]);

    }   
 }

return 0;
