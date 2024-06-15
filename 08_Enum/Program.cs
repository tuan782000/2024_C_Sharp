System.Console.WriteLine(Warning.CodeYellow);
System.Console.WriteLine((int)Warning.CodeYellow); // đưa ra số 

var status = Warning.CodeYellow;

if(status == Warning.CodeYellow) {
    System.Console.WriteLine("Code Yellow");
}

enum Warning {
    CodeRed,
    CodeBlue,
    CodeYellow
}