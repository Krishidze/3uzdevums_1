// See https://aka.ms/new-console-template for more information
using _3uzdevums_1;
using _3uzdevums_2;
using _3uzdevums_3;
using _3uzdevums_4;

//// Pirmais uzdevums

//Phone phone = new Phone();
//Console.WriteLine("Please enter company that your phone ");
//phone.Make = Console.ReadLine();
//Console.WriteLine("Please enter your phone model");
//phone.Model = Console.ReadLine();
//Console.WriteLine("Please enter your phone height cm");
//string HeightString = Console.ReadLine();
//phone.Height = double.Parse(HeightString);
//Console.WriteLine("Please enter your phone width cm");
//string WidthString = Console.ReadLine();
//phone.Width = double.Parse (WidthString);
//Console.WriteLine("Please enter your phone lenght cm");
//string LenghtString = Console.ReadLine();
//phone.Lenght = double.Parse (LenghtString);
//Console.WriteLine($"Your phone was made by {phone.Make} and the model is {phone.Model}, the size of your phone is {phone.Height}CM high, {phone.Width}CM wide and {phone.Lenght}CM long");

//// Otrais uzdevums

//Car Car = new Car();
//Console.WriteLine("Please enter the make of your Car");
//Car.Make = Console.ReadLine();
//Console.WriteLine("Please enter the first two LETTERS of your numberplate");
//Car.PlateLetters = Console.ReadLine();
//Console.WriteLine("Please enter NUMBERS of your numberplate");
//string PlateNumberString = Console.ReadLine();
//Car.PlateNumber = int.Parse(PlateNumberString);
//Console.WriteLine("Please enter the maximum speed of your car");
//Car.MaxSpeed = Console.ReadLine();
//Car.MessageCar();

//// Trešais uzdevums

//Item Item = new Item();

//Item.lenght = 24.5;
//Item.width = 100;
//Item.height = 200;
//Console.WriteLine("Enter item weight");
//string ItemWeightString = Console.ReadLine();
//Item.weight = double.Parse (ItemWeightString);
//Item.MessageItem();

// Ceturtais uzdevums

Person Person = new Person();
Console.WriteLine("Enter your name");
Person.Name = Console.ReadLine();
Console.WriteLine("enter your surname");
Person.Surname = Console.ReadLine();
Console.WriteLine("Enter your birthdate");
string BirthDateString = Console.ReadLine();
Person.BirthDate = DateTime.Parse(BirthDateString);
Console.WriteLine("Enter your hobby");
Console.ReadLine();
Console.WriteLine("enter your gender");
Console.ReadLine();
Person.Greeting();
// datums izvadās nepareizi, kāpēc nezinu