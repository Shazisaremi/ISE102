## C# Regular Expressions

### Code:
```csharp
using System.Text.RegularExpressions;

string alpha = @"[a-zA-Z]"; // Alphabetic characters Regex
string digit = @"\d";      // Digital Characters Regex
string specc = @"\W";     // Special Characters Regex

string password = "Hello World";

bool has_alpha = Regex.IsMatch(password, alpha);
bool has_digit = Regex.IsMatch(password, digit);
bool has_specc = Regex.IsMatch(password, specc);

Console.WriteLine(has_alpha);
Console.WriteLine(has_digit);
Console.WriteLine(has_specc);
```

### Links : 
A good site to train regex coding in many languages:

https://regex101.com/

cheat sheet:

https://www.mikesdotnetting.com/article/46/c-regular-expressions-cheat-sheet