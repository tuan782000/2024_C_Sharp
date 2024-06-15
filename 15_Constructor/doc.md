```c#
Student student = new()
```

Mặc dù thuộc tính là private

```c#
        private string _address;
        public RealEstate(string address) {
            _address = address;
        }
        public string Address {
            get => _address;
            set => _address = value;
        }
```

Nhưng đã tạo ra prop khác có tên Address để nó dạng public, từ đó Program thông qua đó có thể tác động gián tiếp tới \_address thông qua Address

Address và "\_address" chung 1 file cho nên việc thay đổi không thành vấn đề
