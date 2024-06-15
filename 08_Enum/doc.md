An enumeration type (or enum type) is a value type defined by a set of named constants of the underlying integral numberic type

Dạng liệt kê (hoặc kiểu enum) là một loại giá trị được định nghĩa bởi một tập hợp các hằng số có tên của kiểu số nguyên cơ bản.

Enum được đưa vào stack. Vì nó đơn giản

ENUM are Constants

if(status == "code-red") về mặt ý nghĩa không sai, nhưng code sẽ rất xấu

if(status == warning.CodeRed) tối ưu bằng cách sử dụng Enum

```c#
enum warning {
    CodeRed, // 0
    CodeBlue, // 1
    CodeGreen, // 2
}
```
