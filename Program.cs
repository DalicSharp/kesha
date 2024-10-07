System.Console.Write("Enter your name: ");
string name = Console.ReadLine();
string greeting = $"Hello, {name}";
System.Console.WriteLine(greeting);

System.Console.Write("Enter your age: ");
string priceAsString = Console.ReadLine();
System.Console.WriteLine("Converting... ");
int age = Convert.ToInt32(priceAsString);
System.Console.WriteLine($"Successfully converted! {age}");
int keschaAge = 3;
int ageDifference = age - keschaAge;
System.Console.WriteLine($"The difference between your and Kescha's age is {ageDifference}"); 
