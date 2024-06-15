Person person1 = new("Teddy", "Smith", new string[1]{"555-1234"});
Person person2 = new("Teddy", "Smith", new string[1]{"555-1234"});

//Shallow Immutability
person1.LastName = "smith";
person2.PhoneNumbers[0] = "222-2222"; 

// Equality
// Value - 1.Check the type 2. Check the contents
// Referential - 2. By memory (hex code)
System.Console.WriteLine(person1 == person2);

// Non-destructive (copy)
Person person3 = person2 with {LastName = "Brewski"};
System.Console.WriteLine(person3.ToString());


public record Person(string FirstName, string LastName, string[] PhoneNumbers);