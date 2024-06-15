using _11_Class;
// CRUD

Rat wolfRat = new Rat(); // Đưa vào Stack xử lý
Rat fancyRat = new Rat(); //

// Đưa vào Heap xử lý
wolfRat.Name = "Wolf Rat";
wolfRat.Number = 1000;
wolfRat.IsRadioactive = false;

fancyRat.Name = "Fancy Rat";
fancyRat.Number = 500;
fancyRat.IsRadioactive = false;

System.Console.WriteLine("-------------");


// Read
System.Console.WriteLine(wolfRat.Name);
System.Console.WriteLine(fancyRat.Name);

System.Console.WriteLine("-------------");

// Update
wolfRat.Name = "WOLF RAT";
fancyRat.Name = "FANCY RAT";

System.Console.WriteLine(wolfRat.Name);
System.Console.WriteLine(fancyRat.Name);

System.Console.WriteLine("-------------");

// Delete
wolfRat.Name = "";
fancyRat.Name = "";
System.Console.WriteLine(wolfRat.Name);
System.Console.WriteLine(fancyRat.Name);

