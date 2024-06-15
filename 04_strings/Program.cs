using System.Text;

// Create read update delete
// CRUD
// Create
string petFish = "puffer fish";

// Concatenation: Nối
petFish = "porcupine " + petFish;

// Template literal
System.Console.WriteLine($"I am buying {petFish}.");

System.Console.WriteLine(petFish);

// Read
// Console.writeLine

// Update
// petFish[0] = "P";

string newPetFish = petFish.Replace("porcupine", "blue dot");
System.Console.WriteLine(newPetFish);

// Delete
// String Builder
StringBuilder newCrustacean = new StringBuilder();
newCrustacean.Append("fiddler crav");
System.Console.WriteLine(newCrustacean);
newCrustacean.Remove(0,8);
System.Console.WriteLine(newCrustacean);