# CNET

# LEARNING C# .NET ASP CORE IN T3H

# 1. Git, Github , Visual studio

# 2. Function in C#

# 3. Condition (IF - ELSE)

# 4. Swith Case & Use Enum 

# 5. LOOP
>> for (star; end ; step){ code..}
- cách hoạt động: lặp từ start tới xát end, theo từng step
- dùng khi biết trước được số lần cần lặp, và khi nào cần dừng
- 
>> cú pháp
  for(<bieu_thuc_1>; <bieu_thuc_2>; <bieu_thuc_3>){
      --code--
  }

  - <bieu_thuc_1>: biến khởi tạo giá trị ban đầu
  - <bieu_thuc_2>: điều kiện để tiếp tục lặp
  - <bieu_thuc_3>: tăng giá trị của biến khởi tạo giá trị ban đầu

  VD: for(var i = 1; i < 5; i++){
      --code--
  }

>> while(điều kiện lặp){ code lặp}
 >> cú pháp
  while(<dieu_kien>){
      --code--
  }

  >> cách hoạt động
  - nếu điều kiện đúng thì sẽ thực hiện các dòng code trong dấu {}

>> do while

>> cú pháp
  do{
      --code--
  }while(<dieu_kien>)

  >> cách hoạt động
  - lần đầu tiên sẽ thực hiện các dòng code trong dấu {} mà không cần xét điều kiện
    từ lần thứ hai trở đi nếu điều kiện đúng sẽ thực hiện các dòng code trong dấu {}
- giông while nhưng cho vào rồi mới kiểm tra điều kiện, while thì kt rồi mới cho vào

>>Câu lệnh Break và Continue 
  >> break
  - nếu break ở trong vòng lặp thì vòng lặp gần nhất đang chứa nó sẽ bị dừng không tiếp tục lặp nữa
  - thoả mãn dk --> dừng vòng lặp luôn

  >> continue
  - tất cả các dòng code bên dưới continue sẽ được bỏ qua
  - nếu continue ở trong vòng lặp thì sẽ bỏ qua các dòng code bên dưới và tiếp tục vòng lặp mới
  - thoả mãn điều kiện --> bước qua 


# 6. ARRAY & LIST
>> ARRAY: 
- mảng chứa tập hợp các giá trị có cùng kiểu dữ liệu
>> cú pháp:
- cách 1: datatype[] nameArray = { value1, value2,...}
 - --> chứa giá trị khởi tạo ban đầu
- cách2 : datatype[] nameArray = new datatype[length] 
 - --> mảng rỗng, biết độ dài
    - datatype: kiểu dữ liệu
    - nameArray: tên mảng
    - value..: các element của mảng
    - length: độ dài mảng
>> VD:  int[] numbers = new int[length]
--> khác với js, c# Có kích thước cố định sau khi tạo,
>> LIST:
- danh sách: giống array nhưng có thể thay đổi độ dài
-  List<T> Kích thước có thể thay đổi, 
- nhưng kiểu dữ liệu của phần tử không thể thay đổi.
>> syntax
- List<int> numbers = new List<int>(); // Khởi tạo danh sách rỗng
 // Khởi tạo danh sách với các phần tử
- List<string> fruits = new List<string> { "Apple", "Banana" }; 
- cách hoạt động các hàm có phần giống string và array

