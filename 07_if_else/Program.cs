if(true) {
    System.Console.WriteLine("This code will always run");
}

if(false) {
    System.Console.WriteLine("This code will always run"); // đoạn này không chạy
}

System.Console.WriteLine("==================");

var aquariumStoreInventory = "puffer fish";

if(aquariumStoreInventory == "puffer fish") {
    System.Console.WriteLine($"I will buy {aquariumStoreInventory}");
} else if(aquariumStoreInventory == "clown fish") {
    System.Console.WriteLine($"I will buy {aquariumStoreInventory}");
} else {
    System.Console.WriteLine("I will not buy anything!");
}

System.Console.WriteLine("==============================================");

if(aquariumStoreInventory == "puffer fish" || aquariumStoreInventory == "clown fish") {
    System.Console.WriteLine($"I will buy {aquariumStoreInventory}");
}  else {
    System.Console.WriteLine("I will not buy anything!");
}

System.Console.WriteLine("======================");


var fishTankPrice = 1000;
if(fishTankPrice <= 1000) {
    System.Console.WriteLine("Buy tank");
} else {
    System.Console.WriteLine("Don't buy");
}

System.Console.WriteLine("======================");

var auquariumfish = "puffer fish";

if(auquariumfish is string) {
    System.Console.WriteLine($"{auquariumfish} is a string");
}