
// Array CRUD

// Create
// kieu_du_lieu[] te_bien = []
string[] favoriteRats = ["fancy rat", "brown rat", "radioactive rat", "wolf rat"];

// Read
//System.Console.WriteLine(favoriteRats); // viết như này sẽ không in ra được cụ thể: System String[]

// for(int i = 0; i < favoriteRats.Length; i++) {
//     System.Console.WriteLine(favoriteRats[i]);
// }

// C# ở phiên bản mới, bạn có thể cân nhắc sử dụng vòng lặp foreach để viết ngắn gọn hơn:

foreach (var rat in favoriteRats) {
    System.Console.WriteLine(rat);
}

// Update

// đã update cái mảng, sau đó in ra
favoriteRats[0] = "Fancy Rat";

foreach (var rat in favoriteRats) {
    System.Console.WriteLine(rat);
}

// Ngoài ra c# cung cấp linq
// LINQ: "update array linq"

// From - where - OrderBy - Having - GroupBy - Select
System.Console.WriteLine("===============================================");
// tạo ra 1 mảng mới - dự trên mảng cũ kèm điều kiệm
var newFavoriteRats = favoriteRats.Where((e) => e.StartsWith("b"));
// có mảng mới newFavoriteRats
foreach(var rat in newFavoriteRats) {
    System.Console.WriteLine(rat);
}

// Delete


// int[] numbers = { 1, 2, 3, 4, 5 };
// int indexToRemove = 2;

// // Xác định kích thước của mảng mới
// int newSize = numbers.Length - 1;
// int[] newArray = new int[newSize];

// // Sao chép các phần tử từ mảng gốc đến mảng mới, loại bỏ phần tử cần xóa
// for (int i = 0, j = 0; i < numbers.Length; i++) {
//     if (i != indexToRemove) {
//         newArray[j++] = numbers[i];
//     }
// }

// numbers = newArray;

// for (int i = 0; i < numbers.Length; i++) {
//     System.Console.WriteLine(numbers[i]); // đã loại được thằng 3
// }

// cách khác Sử dụng lớp List<T> để thực hiện việc xóa phần tử một cách dễ dàng:

List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
int indexToRemove = 2;

numbers.RemoveAt(indexToRemove);

// Ưu điểm chính của List<T> so với mảng cố định (array) là khả năng linh hoạt trong việc thay đổi kích thước của danh sách và các phương thức tiện ích như Add(), Remove(), Clear() và Contains(), giúp quản lý dữ liệu một cách hiệu quả hơn. 

// phương thức cơ bản của lớp List<T>:

// Add(T item): Thêm một phần tử vào cuối danh sách.
// Remove(T item): Xóa một phần tử cụ thể từ danh sách.
// Clear(): Xóa tất cả các phần tử từ danh sách.
// Contains(T item): Kiểm tra xem danh sách có chứa một phần tử cụ thể hay không.