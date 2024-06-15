# Strings

strings are words - strings là từ

Developer Level

```c#
string name = "tuna";
```

Compiler sẽ chuyển nó thành thứ mà nó có thể hiểu

chuyển đổi chuỗi thành mảng

```c#
char name = new char{'t', 'u', 'n', 'a'};
```

strings are immutable

immutable: bất biến

Trong mọi ngôn ngữ lập trình đều chia ra 2 stack và heap

stack - ngăn xếp dành cho các kiểu dữ liệu đơn giản

heap - rất phức tạp

chuỗi sẽ được lưu bên heap và đây là nơi khái niệm bất biến phát huy tác dụng

CRUD

Create

```c#
string petFish = "puffer fish";

```

Read

```c#
Console.writeLine(petFish)
```

Update

```c#
string newPetFish = petFish.Replace("porcupine", "blue dot");
System.Console.WriteLine(newPetFish);
```

Delete

```c#
newPetFish.Remove(0,7);
```
