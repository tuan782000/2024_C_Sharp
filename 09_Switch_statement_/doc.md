The switch rabbit hole goes deep...

Swich giống như đi sâu vào trong hố đen...

Pattern matching

"Bool matching"

```c#
var preHistoricFish = "Cockerellites";

if(preHistoricFish == "Cockerellites") {
    // run code
} else if(preHistoricFish == "Heliobatis") {
    // run code
} else {
    // run code
}
```

Statements (pre c# 7 era)

```c#
var preHistoricFish = "Cockerellites"

switch (Cockerellites) {
    case "Heliobatis":
        // run code
        break;
    case "Cockerellites":
        // run code
        break;
    default:
        // run code
        break;
}
```

Switch Expressions

```c#
var preHistoricFish = "Cockerellites";

var result = preHistoricFish switch
{
    "Heliobatis" => // run code.
    "Cockerellites" => // run code.
    _=> // run code.
};

Console.WriteLine(result);
```
