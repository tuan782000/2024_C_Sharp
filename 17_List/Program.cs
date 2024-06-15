// CRUD

// Create
// List<int>numNums = new List<int>{1,2,3,4,5}; // cú pháp cũ

//danh sách các chữ số
List<int>numNums = [1,2,3,4,5]; // cú pháp mới

List<string> strString = ["a","v","m","b"];

// Read

// đọc 1 danh sách dùng foreach
foreach(var number in numNums) {
    System.Console.WriteLine(number);
}
System.Console.WriteLine("===================");

// Update lại mảng
// this is the fastest
numNums.Add(6); // thêm vào cuối mảng - số được truyền vào

numNums.Insert(0,0); // vị trí index, số sẽ được thêm vào

foreach(var number in numNums) {
    System.Console.WriteLine(number);
}
System.Console.WriteLine("===================");

// Delete

var newNum = numNums.Where((i) => i != 2);

foreach(var num in newNum) {
    System.Console.WriteLine(num);
};

// Ngoài ra còn có Remove(), RemoveAt()

// Remove(truyen_so_muon_xoa)
// RemoveAt(truyen_index_muon_xoa)