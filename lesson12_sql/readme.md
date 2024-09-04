# SQL Server
- char(10) bắt buộc bắng 10
- varchar(10) có thể <= 10

# Truy Vấn
- CRUD basic
- 1 số hàm
 + newid() --> tự gen ra 1 id ngẫu nhiên
 + getDate() --> ngày hiện tại
 + CAST(expression AS data_type) --> ép kiểu 
    - expression: Đây là giá trị hoặc cột mà bạn muốn chuyển đổi kiểu dữ liệu.
    - data_type: Kiểu dữ liệu mà bạn muốn chuyển đổi giá trị hoặc cột sang. Ví dụ: INT, VARCHAR, DATE, DATETIME, v.v.

>>example

    SELECT CAST('123' AS INT) AS ConvertedValue; --> 123 (dataType==int)


- lấy ra dữ liệu từ nhiều bảng, join giữa các khoá chính, khoá phụ

>> systax

        SELECT column_list
        FROM table1
        INNER JOIN table2
        ON table1.column_name = table2.column_name;


+ SELECT column_list: Chỉ định các cột bạn muốn truy vấn từ các bảng. Bạn có thể chọn các cột từ bất kỳ bảng nào trong JOIN. Để chọn tất cả các cột, bạn có thể sử dụng * (ví dụ: SELECT *).

+ FROM table1: Đây là bảng đầu tiên trong câu truy vấn. Đây được coi là bảng chính mà chúng ta sẽ kết hợp với bảng khác.

+ INNER JOIN table2: Kết hợp bảng thứ hai (table2) với bảng đầu tiên (table1). INNER JOIN sẽ chỉ trả về các hàng khi có một sự khớp giữa hai bảng dựa trên điều kiện được xác định.

+ ON table1.column_name = table2.column_name: Điều kiện kết hợp. Nó chỉ định cột từ mỗi bảng mà sẽ được so sánh để xác định các hàng nào nên được kết hợp với nhau. Cột này thường là khóa chính của bảng này và khóa ngoại của bảng kia.

>> example

    SELECT p.CategoryId, c.CategoryId
    FROM Products AS p
    INNER JOIN Categories AS c 
    ON p.CategoryId = c.CategoryId;

- join bảng Products và Categories dựa vào CategoryId, sau đó lấy ra CateoryId của 2 bảng,  --> bằng nhau

