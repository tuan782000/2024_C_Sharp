var preHistoricFish = "Cockerellites";

// cách 1:
switch (Cockerellites) {
    case "Heliobatis":
        System.Console.WriteLine("Heliobatis");
        break;
    case "Cockerellites":
        System.Console.WriteLine("Cockerellites");
        break;
    default:
        System.Console.WriteLine("Nothing matches!!!");
        break;
}
// cách 2:
var result = preHistoricFish switch
{
    "Heliobatis" => "Heliobatis"
    "Cockerellites" => "Cockerellites"
    _=> "Nothing matches!!!"
};

Console.WriteLine("This is a" + result);