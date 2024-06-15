// Counter
for(int i = 0; i <= 10; i++) {
    System.Console.WriteLine(i);
}

System.Console.WriteLine("================use for======================");
// 
string[] favoriteHairMetalBands = ["Van Halen", "Dokken", "Great White"];

for(int j = 0; j < favoriteHairMetalBands.Length; j++) {
    System.Console.WriteLine(favoriteHairMetalBands[j]);
}

System.Console.WriteLine("=================use ForEach=====================");

foreach(var band in favoriteHairMetalBands) {
    System.Console.WriteLine(band);
}

System.Console.WriteLine("=================use Linq=====================");
// cách 1
favoriteHairMetalBands.ToList().ForEach((x) => {
    System.Console.WriteLine("Foreach - linq: " + x);
});

// cách 2:
System.Console.WriteLine("=================use Linq=====================");
Array.ForEach(favoriteHairMetalBands, e => System.Console.WriteLine("Array.ForEach: " + e));