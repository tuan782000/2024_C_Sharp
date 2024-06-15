using _15_Constructor;

Console.OutputEncoding = System.Text.Encoding.UTF8;
RealEstate elmStreet = new("Elm Street");

Console.WriteLine("Địa chỉ ban đầu của Elm Street: " + elmStreet.Address);


elmStreet.Address = "Main Street";

/*
Trong lớp RealEstate, có một constructor có tham số nhận vào địa chỉ của bất động sản và một thuộc tính Address để lưu trữ và truy cập địa chỉ đó.

Trong phần Main của chương trình, đầu tiên chúng ta khởi tạo một đối tượng elmStreet của lớp RealEstate bằng cách sử dụng constructor có tham số với giá trị "Elm Street". Điều này tạo ra một đối tượng RealEstate mới với địa chỉ là "Elm Street".

Tiếp theo, chúng ta gán một giá trị mới cho thuộc tính Address của đối tượng elmStreet. Bằng cách gán giá trị "Main Street" cho thuộc tính này, chúng ta thay đổi địa chỉ của bất động sản từ "Elm Street" thành "Main Street".
*/

Console.WriteLine("Địa chỉ mới của Elm Street: " + elmStreet.Address);
