
int x = 12 * 30;
Console.WriteLine(x);


int myNum = 5;               // Integer (whole number)
double myDoubleNum = 5.99D;  // Floating point number
char myLetter = 'D';         // Character
bool myBool = true;          // Boolean
string myText = "Hello";     // String


int myNewNum;
myNewNum = 15;
Console.WriteLine(myNewNum);


int myInt = 9;
double myDouble = myInt;       // Automatic casting: int to double
Console.WriteLine(myInt);      // Outputs 9
Console.WriteLine(myDouble);   // Outputs 9


double myDouble2 = 9.78;
int myInt2 = (int)myDouble2;    // Manual casting: double to int
Console.WriteLine(myDouble2);   // Outputs 9.78
Console.WriteLine(myInt2);      // Outputs 9


int myInt3 = 10;
double myDouble3 = 5.25;
bool myBool3 = true;

Console.WriteLine(Convert.ToString(myInt3));    // convert int to string
Console.WriteLine(Convert.ToDouble(myInt3));    // convert int to double
Console.WriteLine(Convert.ToInt32(myDouble3));  // convert double to int
Console.WriteLine(Convert.ToString(myBool3));   // convert bool to string

Console.WriteLine("Radius:");
string radius = Console.ReadLine();
int radiusInt = Convert.ToInt32(radius);
Console.WriteLine("Height:");
string height = Console.ReadLine();
int heightInt = Convert.ToInt32(height);
Console.WriteLine(radiusInt * radiusInt * 3.14 * heightInt);


Console.WriteLine("Fahrenheit :");
string F = Console.ReadLine();
int Fint = Convert.ToInt32(F);
Console.WriteLine("Celsius :");
Console.WriteLine((Fint - 32) * (5 / 9));
