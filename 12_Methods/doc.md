Methods

CRUD

1.Store - cửa hàng lưu trữ dữ liệu
2.Act on data - hoạt động trên dữ liệu

```c#
var calculatePricePerSquareFoot = property.price / property.SquareFootage;

// nhược điểm chỉ chạy được 1 lần
```

đổi lại thành hàm thì khi nào cần thì gọi nó sẽ bắt đầu tính lại.

```c#
var pricePerSquareFoot = calculatePricePerSquareFoot(); // đưa vào Heap ( cho các xử lý phức tạp )
```

```c#
public class RealEstate {
    public string Address {get; set;}
    public int Price {get; set;}
    public int SquareFootage {get; set;}

    public void CalculatePricePerSquareFootage (){
        Console.WriteLine(Price/SquareFootage);
    }
}
```

```c#

// void thì không có return
public void CalculatePriceSqFt() {
    Console.WriteLine(Price * SquareFootage);
}

CalculatePriceSqFt(); // cái này đưa vào Stack (đơn giản)
CalculatePriceSqFt();
CalculatePriceSqFt();

// nếu cần kết quả trả về.
public int CalculatePriceSqFt() {
    return Price * SquareFootage;
}
```
