các kiểu dữ liệu bool, int,... Value Type (Stack).

null Complex type (Heap).

```c#
string myString = null; // c# sẽ cảnh báo
```

```c#
int? myValue = null; //
string? myString = null; //
```

dấu ? cung cấp khả năng cho thuộc tính nó có thể null

là cho phép nó được null

```c#
string value2 = null!; // cho phép gán null, chương trình sẽ không cảnh báo
```

cho phép gán null và chương trình sẽ không cảnh báo

int? myValue = null;: Đây là kiểu dữ liệu số nguyên nullable, myValue có thể chứa giá trị số nguyên hoặc null.
string value2 = null!;: Đây là cách để chỉ định cho compiler biết rằng biến value2 có thể chứa giá trị null mà không cần cảnh báo từ compiler.

Trong C#, toán tử ?? được sử dụng để cung cấp một giá trị mặc định cho biến nullable nếu nó có giá trị null.

```c#
int? nullableInt = null;
int nonNullableInt = nullableInt ?? 10;
```

Trong ví dụ này, nếu nullableInt có giá trị null, nonNullableInt sẽ được gán giá trị mặc định là 10. Nhưng nếu nullableInt có giá trị không phải null, nonNullableInt sẽ được gán giá trị của nullableInt.

Toán tử ?? thường được sử dụng khi bạn muốn xác định một giá trị mặc định cho các biến nullable mà bạn không muốn chúng có giá trị null.
