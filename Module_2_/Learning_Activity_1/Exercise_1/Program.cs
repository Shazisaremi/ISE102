double body_weight; // Define The body weight as a double type
double body_height; // Define the Body height as a double type
double bmi; // BMI 
Console.WriteLine("enter the body weight in Kg!"); // Ask user to enter weight in KG
body_weight = double.Parse(Console.ReadLine()); // Read the client input and parse it as double
Console.WriteLine("enter the body height in cm!");
body_height = double.Parse(Console.ReadLine());
bmi = body_weight / (body_height * body_height); // Calculate the BMI based on formula
Console.WriteLine("Your BMI value is:" + bmi);   // Show the Result
Console.WriteLine("Press any key to close program!");
Console.ReadKey();