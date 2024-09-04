# SQL Server
- char(10) bắt buộc bắng 10
- varchar(10) có thể <= 10

# Truy Vấn
-- lấy ra dữ liệu từ nhiều bảng, join giữa các khoá chính, khoá phụ

>> systax

        SELECT column_list
        FROM table1
        INNER JOIN table2
        ON table1.column_name = table2.column_name;


+ SELECT column_list: Chỉ định các cột bạn muốn truy vấn từ các bảng. Bạn có thể chọn các cột từ bất kỳ bảng nào trong JOIN. Để chọn tất cả các cột, bạn có thể sử dụng * (ví dụ: SELECT *).

+ FROM table1: Đây là bảng đầu tiên trong câu truy vấn. Đây được coi là bảng chính mà chúng ta sẽ kết hợp với bảng khác.

+ INNER JOIN table2: Kết hợp bảng thứ hai (table2) với bảng đầu tiên (table1). INNER JOIN sẽ chỉ trả về các hàng khi có một sự khớp giữa hai bảng dựa trên điều kiện được xác định.

+ ON table1.column_name = table2.column_name: Điều kiện kết hợp. Nó chỉ định cột từ mỗi bảng mà sẽ được so sánh để xác định các hàng nào nên được kết hợp với nhau. Cột này thường là khóa chính của bảng này và khóa ngoại của bảng kia.