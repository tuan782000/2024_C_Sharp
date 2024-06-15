int? value = null;

string value2 = null!;

// System.Console.WriteLine(value2.Length); // c# sẽ phát cảnh báo

System.Console.WriteLine(value2?.Length); // việc của bạn là phải thêm ? - vì tránh lỗi tham chiếu đến null

// tức kiểm tra có null không trước khi .Length

if(value2 is not null) {
    System.Console.WriteLine(value2.Length); // nếu như không viết ? thì đoạn code trên phải viết như này
}

System.Console.WriteLine(value2 ?? "No value!"); // nếu như value2 là null thì No value! sẽ thay thế vào giá trị null cho value2

System.Console.WriteLine(value2 is not null ? "Has value" : "No value!"); // value2 is not null là điều kiện. Nếu true là Has value, false là là No value!