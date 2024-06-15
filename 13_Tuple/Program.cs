var values = ("a", 5, "c");

System.Console.WriteLine(values.Item1);
System.Console.WriteLine(values.Item2);
System.Console.WriteLine(values.Item3);

// mặc định là Itemn và n này thay đổi theo tăng dần

// có thể tự custom

var valuesWithName = (First: "t", Second: 2, Third: "p");
System.Console.WriteLine(valuesWithName.First);
System.Console.WriteLine(valuesWithName.Second);
System.Console.WriteLine(valuesWithName.Third);

// Thay vì dùng var cho máy tự gán, mình sẽ tự gán luôn
(int a, string b, bool c) ReturnTheseValues() {
    return (9, "u", true);
}

var tupleReturnValue = ReturnTheseValues();

System.Console.WriteLine(tupleReturnValue.a);