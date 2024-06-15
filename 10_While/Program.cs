// Pinger
using System.Net.NetworkInformation;

Ping p1 = new Ping(); // Tạo một đối tượng mới của lớp Ping và gán vào biến p1.
PingReply PR = p1.Send("8.8.8.8"); // Gửi một yêu cầu ping đến địa chỉ IP "8.8.8.8" bằng cách sử dụng đối tượng ping được tạo ở dòng trước, và kết quả trả về được gán vào biến PR.

// Bắt đầu một vòng lặp while, với điều kiện là kiểm tra xem trạng thái của phản hồi ping có phải là "Success" không.
while(PR.Status.ToString() == "Success") {
    System.Console.WriteLine(PR.Status.ToString() + "!"); // In ra trạng thái của phản hồi ping, cộng với dấu chấm than và dấu chấm than.
    PR = p1.Send("8.8.8.8"); // Gửi một yêu cầu ping mới đến địa chỉ IP "8.8.8.8" và gán kết quả trả về vào biến PR, để kiểm tra trạng thái tiếp theo.
    System.Console.WriteLine("Wating ten seconds for next request");
    Thread.Sleep(10000); // Tạm dừng thực thi của luồng hiện tại trong 10 giây, để chờ đợi cho yêu cầu ping tiếp theo được gửi.
}