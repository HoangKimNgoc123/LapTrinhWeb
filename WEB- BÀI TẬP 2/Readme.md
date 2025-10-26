```
 HỌ TÊN: HOÀNG KIM NGỌC
 MSSV  : K225480106053
 LỚP   : K58KTP
```
# 📝 BÀI TẬP MÔN PHÁT TRIỂN ỨNG DỤNG TRÊN NỀN WEB SỐ 2
**NGÀY GIAO: 19/10/2025** -
**DEADLINE:  26/10/2025**
## NỘI DUNG BÀI TẬP
### 🧩 ĐỀ BÀI
1. Cài đặt Apache Web Server.
2. Cài đặt NodeJS và Nodered. 
3. Tạo cơ sở dữ liệu SQL Server 2022. 
4. Cài đặt thư viện trên Nodered. 
5. Tạo API Back-end bằng Nodered. 
6. Tạo giao diện Front-end. 
7. Nhận xét bài làm của mình


### ✏️ YÊU CẦU 
1. Yêu cầu bắt buộc về thời gian: không quá deadline, quá: 0 điểm (ko có ngoại lệ)
2. Cài đặt được Apache và Nodejs và Nodered: 1đ
3. Cài đặt được các thư viện của Nodered: 1đ
4. Nhập dữ liệu demo vào SQL Server: 1đ
5. tạo được Back-end api trên Nodered, test qua url thành công: 1đ
6. tạo được Front-end HTML CSS JS, gọi được API, hiển thị kết quả: 1đ
7. trình bày độ hiểu về toàn bộ quá trình : 5đ

### 💡 GHI CHÚ
1. Yêu cầu trên cài đặt trên ổ D, nếu máy ko có ổ D có thể linh hoạt chuyển sang ổ khác, path khác.
2. Có thể thực hiện trực tiếp trên máy tính Windows, hoặc máy ảo
3. Vì cơ sở dữ liệu là tuỳ ý: sv cần mô tả rõ db chứa dữ liệu gì, nhập nhiều dữ liệu test có nghĩa, json trả về sẽ có dạng như nào cũng cần mô tả rõ.
4. Có thể xây dựng nhiều API cùng cơ chế, khác tính năng: như tìm kiếm, thêm, sửa, xoá dữ liệu trong DB.
5. Bài làm phải có dấu ấn cá nhân, nghiêm cấm mọi hình thức sao chép, gian lận (sẽ cấm thi nếu bị phát hiện gian lận).
6. Bài tập thực làm sẽ tốn nhiều thời gian, sv cần chứng minh quá trình làm: save file `readme.md` mỗi khoảng 15-30 phút làm : lịch sử sửa đổi sẽ thấy quá trình làm này!
7. Nhắc nhẹ: github không fake datetime được.
8. Sinh viên được sử dụng AI để tham khảo.

## NỘI DUNG BÀI LÀM 
1. Cài đặt Apache Web Server.
   - Vô hiệu hoá IIS: nếu IIS đang chạy thì mở CMD quyền Admin để chạy lệnh: iisreset /stop
     
      <img width="1098" height="638" alt="Ảnh chụp màn hình 2025-10-25 115957" src="https://github.com/user-attachments/assets/c2cacdae-e4e7-463d-935b-c80babf5fb5c" />
      
   -> **Mục đích**: Cần dừng hoạt động của IIS trên cổng 80 (HTTP) vì bài tập trước đó, khi đó thì Apache mới có thể chạy trên cổng này được.
   -  Download Apache Server và giải nén:
     + Link download: https://www.apachelounge.com/download/ (đây là link for Window)
       
       
      <img width="1887" height="962" alt="Ảnh chụp màn hình 2025-10-25 121327" src="https://github.com/user-attachments/assets/f027839c-2bdd-48fa-98e5-d47ee0f7ac4a" />

     + Sau khi bấm download thì sẽ nhận được file này:

       <img width="371" height="66" alt="Ảnh chụp màn hình 2025-10-25 121332" src="https://github.com/user-attachments/assets/11d61a5e-8cec-4a5d-8eb4-ae24f2ce4cf4" />

     + Giải nén file vào ổ D:
  
       <img width="1001" height="789" alt="Ảnh chụp màn hình 2025-10-25 130819" src="https://github.com/user-attachments/assets/7cf0979a-7863-496b-abdd-5b6b2c1690cd" />

  - Cấu hình file httpd.conf:

    <img width="934" height="876" alt="Ảnh chụp màn hình 2025-10-25 131713" src="https://github.com/user-attachments/assets/92b39cdb-1e7f-431f-8748-6f371608d2cc" />

    <img width="818" height="686" alt="Ảnh chụp màn hình 2025-10-25 134406" src="https://github.com/user-attachments/assets/2f4ceee2-c10e-4b27-8cbd-7aae1f88e46d" />

    <img width="820" height="359" alt="Ảnh chụp màn hình 2025-10-25 134339" src="https://github.com/user-attachments/assets/f49fa5c9-d077-4cc5-a434-6581ceff39af" />

    <img width="966" height="692" alt="Ảnh chụp màn hình 2025-10-25 132556" src="https://github.com/user-attachments/assets/55f29009-e588-425f-b6c3-5c6931cc9aff" />

    <img width="796" height="371" alt="Ảnh chụp màn hình 2025-10-25 134356" src="https://github.com/user-attachments/assets/8b65b6da-e116-4df5-8e2a-16d8f94e5991" />

     ->**Mục đích**: File httpd.conf là file cấu hình chính của Apache Web Server, có thể cấu hình lại port (mặc định là cổng 80), folder chứa các file web (htdocs), server name,...
     -> Trong ảnh thực hiện xóa bỏ # ở dòng "Include conf/extra/httpd-vhosts.conf" để có thể kích hoạt cấu hình Virtual Host, nghĩa là cho phép Apache đọc và áp dụng file httpd-vhosts.conf. Đây là cách để nhiều website có thể chạy cùng lúc trên Apache.
  -  Cấu hình file httpd-vhosts.conf:

       <img width="787" height="837" alt="Ảnh chụp màn hình 2025-10-25 134433" src="https://github.com/user-attachments/assets/3d750a34-4232-4cd4-ba0b-f06976701073" />
   
   ->**Mục đích**: Cấu hình website với domain, thư mục web, log,...

   - Trong folder Apache24, tạo folder hoangkimngoc chưa file index.html, đây là file web để chạy domain hoangkimngoc.com

   <img width="832" height="224" alt="Ảnh chụp màn hình 2025-10-25 134240" src="https://github.com/user-attachments/assets/9a8c5083-e591-4681-a243-809f7548e6dc" />

  - Cấu hình file host để fake ip 127.0.0.1 cho domain ảo vừa tạo:
 
    <img width="785" height="769" alt="Ảnh chụp màn hình 2025-10-25 131809" src="https://github.com/user-attachments/assets/d0128ff1-672a-4038-8edb-a3c8268e4456" />

   - Chạy CMD với quyền Admin trên path D:\Apache24\bin\httpd.exe:
     
     <img width="637" height="67" alt="Ảnh chụp màn hình 2025-10-25 132234" src="https://github.com/user-attachments/assets/9e79b74f-caa9-420c-9b34-5b5b9bb90667" />

   -> **Mục đích**: Đăng ký Apache thành một dịch vụ (Service) trong Windows.

   <img width="282" height="59" alt="Ảnh chụp màn hình 2025-10-25 132751" src="https://github.com/user-attachments/assets/03ab32f7-1256-4cfa-ac8b-5c95bea2b47b" />
   
   ->**Mục đích**: Lệnh -k start để khởi động Apache
   
2. Cài đặt Nodejs và Nodered
    - Cài đặt Nodejs trên : https://nodejs.org/en/download
      
      <img width="1882" height="1000" alt="image" src="https://github.com/user-attachments/assets/76bf4cf8-a839-4b19-a54b-35d976e1f7c0" />

    - Sau khi nhấn tải thì được file
    
    <img width="767" height="37" alt="image" src="https://github.com/user-attachments/assets/aefacb88-3d0b-4bea-a000-a0f41fff8c01" />

     - Chạy file exe và cấu hình vị trí lưu:

       <img width="614" height="485" alt="image" src="https://github.com/user-attachments/assets/736e05fc-99ba-4c2b-97d1-0dfae807f20f" />

     - Kiểm tra Nodejs đã được cài hay chưa bằng cách mở CMD và gõ lệnh node-v

       <img width="327" height="127" alt="Ảnh chụp màn hình 2025-10-25 135816" src="https://github.com/user-attachments/assets/9475afd1-47cf-42e6-838a-20097321b0c6" />

    - Cài Nodered:
       + chạy CMD, vào thư mục D:\nodejs

        <img width="751" height="108" alt="Ảnh chụp màn hình 2025-10-25 140149" src="https://github.com/user-attachments/assets/8c1089f3-cc01-4af3-88bb-dd50dbb4e82e" />

       <img width="715" height="166" alt="Ảnh chụp màn hình 2025-10-25 140212" src="https://github.com/user-attachments/assets/1c18cc8c-c3fc-4d4d-9682-f93953921235" />

     - Download file trên link: https://nssm.cc/release/nssm-2.24.zip
   
       <img width="356" height="67" alt="Ảnh chụp màn hình 2025-10-25 140251" src="https://github.com/user-attachments/assets/6294006d-8669-4ead-a71c-07a07963fae3" />

      - Giải nén và coppy file nssm.exe vào folder nodered:

        <img width="867" height="520" alt="Ảnh chụp màn hình 2025-10-25 141129" src="https://github.com/user-attachments/assets/3e5635b2-ad40-41e1-8587-f31579987caa" />

      - Tạo file "D:\nodejs\nodered\run-nodered.cmd"

         <img width="976" height="360" alt="image" src="https://github.com/user-attachments/assets/d1a2fb7e-34f5-4676-a425-a9b1af758fff" />

       - Cài đặt service `a1-nodered`:

   <img width="762" height="44" alt="Ảnh chụp màn hình 2025-10-25 141149" src="https://github.com/user-attachments/assets/88549c12-d1dd-4e6e-bfa9-54b8cb6a5a56" />

     -  Chạy service `a1-nodered` bằng lệnh: nssm.exe install a1-nodered "D:\nodejs\nodered\run-nodered.cmd"

3. Tạo cơ sở dữ liệu SQL Server 2022

     - Mở SQL và tạo Database:
       
   <img width="1919" height="1079" alt="Ảnh chụp màn hình 2025-10-25 223528" src="https://github.com/user-attachments/assets/4b873b6c-5bc3-43fe-aea3-f75a900ab046" />

   <img width="586" height="275" alt="Ảnh chụp màn hình 2025-10-25 223540" src="https://github.com/user-attachments/assets/1564bb2a-cd5a-4b4c-bc48-d21772d0ad6f" />

      - Tạo bảng và nhập các thuộc tính:
        
   <img width="669" height="328" alt="image" src="https://github.com/user-attachments/assets/f15e1e64-53c0-43f2-9e9d-7d96639efc71" />

     - Nhập dữ liệu demo:

       <img width="1394" height="599" alt="image" src="https://github.com/user-attachments/assets/dc613071-f86c-49f6-a544-6a02039a1375" />

4 . Cài đặt được các thư viện của Nodered

      - Chạy localhost:1880 để mở Nodered
        
   <img width="1907" height="1077" alt="Ảnh chụp màn hình 2025-10-25 142050" src="https://github.com/user-attachments/assets/5dd4ada8-7150-4506-9ae0-e36b4edca407" />

       - Cài đặt các thư viện cần thiết:

   <img width="884" height="844" alt="Ảnh chụp màn hình 2025-10-25 143315" src="https://github.com/user-attachments/assets/db18b075-7b16-4fb9-8af5-519573e4373a" />

   <img width="640" height="233" alt="Ảnh chụp màn hình 2025-10-25 143328" src="https://github.com/user-attachments/assets/6fc40583-d3d6-49ae-bce4-89508275879b" />

   <img width="889" height="847" alt="Ảnh chụp màn hình 2025-10-25 143423" src="https://github.com/user-attachments/assets/61f0a32d-201f-4520-a4e8-ad456763f7b9" />

   <img width="888" height="846" alt="Ảnh chụp màn hình 2025-10-25 143510" src="https://github.com/user-attachments/assets/d5223258-fa0a-4adc-b09a-38d13efd99c1" />

   <img width="887" height="856" alt="Ảnh chụp màn hình 2025-10-25 143523" src="https://github.com/user-attachments/assets/59cff88d-5b18-4942-b904-a3c120e639c0" />

   <img width="885" height="852" alt="Ảnh chụp màn hình 2025-10-25 143701" src="https://github.com/user-attachments/assets/e015f2aa-0492-47fc-8f24-586562a85133" />

     - Sửa file `D:\nodejs\nodered\work\settings.js`
  
   <img width="1062" height="899" alt="Ảnh chụp màn hình 2025-10-25 144407" src="https://github.com/user-attachments/assets/6d4339c5-cc19-4da6-bc41-861e4e132e37" />

   -> **Mục đích**: cấu hình tài khoản admin (username, password) để đăng nhập Nodered

 5. Tạo API Back-end bằng Nodered.

    - Tạo các node cần thiết: http in, function, MSSQL, http response, debug

      <img width="1054" height="252" alt="image" src="https://github.com/user-attachments/assets/4751721e-db21-4c62-8a41-46e18f52b149" />

       + http in: Nhận request từ client (đầu vào API)
       + function: Xử lý, tạo logic hoặc truy vấn
       + MSSQL: Kết nối và lấy dữ liệu từ SQL Server
       + http response: Trả kết quả về client
       + debug: In ra log để kiểm tra dữ liệu

     - Cấu hình chi tiết các node như sau:

       <img width="641" height="853" alt="image" src="https://github.com/user-attachments/assets/ab72d5a8-ce02-49c9-a54e-bb824d2df501" />

       <img width="816" height="862" alt="image" src="https://github.com/user-attachments/assets/5d122895-23be-4e57-8ef7-194ffb82d365" />

       <img width="646" height="867" alt="image" src="https://github.com/user-attachments/assets/78e160f5-cebb-4861-a9e5-a3bc1aaae67e" />

       <img width="631" height="850" alt="image" src="https://github.com/user-attachments/assets/517c405d-4c92-4450-b53e-d2d9ef82f5a2" />

       <img width="692" height="847" alt="image" src="https://github.com/user-attachments/assets/6b676316-f820-443d-933b-c70e89551058" />

       <img width="650" height="859" alt="image" src="https://github.com/user-attachments/assets/43d3384e-d58e-4704-8708-4ad7d5c2fe0d" />

       - Sau khi cấu hình nhấn Done -> Deploy
       - Chạy localhost:1880/timkiem sẽ trả về dữ liệu dạng json
         
        <img width="1915" height="330" alt="Ảnh chụp màn hình 2025-10-26 093550" src="https://github.com/user-attachments/assets/3484ba3b-feb4-4351-9113-af5c05d20e30" />

  6. Tạo giao diện Front-end.

        - Trong folder hoangkimngoc chưa file index.html đã tạo ban đầu, tạo thêm các file CSS và JS

           <img width="660" height="190" alt="image" src="https://github.com/user-attachments/assets/7b61616b-e649-4988-8dc8-e48a276b5ece" />

        - Viết giao diện bằng HTML và CSS trong file index.html và hoangkimngoc.css

          <img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/bdf52e7c-826b-4748-bd1a-63cacfd92433" />

          <img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/ec07bc63-0089-4812-b8bc-baec48b9db13" />

         - Lập trình JS  trong file hoangkimngoc.js

        <img width="1919" height="1075" alt="image" src="https://github.com/user-attachments/assets/471d1bab-fd76-4483-8e68-748ee74fb9cb" />

          - Chạy file index.html trong folder  \Apache24\hoangkimngoc

        <img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/ae90aa4b-f66e-422e-a1e5-84e3898c0074" />

          - Tính năng tìm kiếm:

       <img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/e09e915d-bf61-40d5-8772-517eb5163913" />

        -> Kết hợp backend nodered + frontend html css + csdl SQL: kết quả là khi người dùng gửi GET bằng cách nhập nội dung tìm kiếm trên frontend thì backend truy vấn database tìm nội dung tương ứng rồi trả về kết quả cho client.

7. Nhận xét:

   - **Trong quá trình cài đặt phần mềm:**
     + Khi cài đặt 1 web server thì cần biết port nào server đó sẽ chạy, chẳng hạn như IIS thường chạy port 80, thì khi muốn cài thêm web server khác thì cần tắt hoạt động của server trên cổng 80 đẻ cho server khác chạy.
     + Ngoài cài đặt thủ công, trực tiếp thì có thể dùng phần mềm trung gian như XAMPP hoặc cài trên máy ảo.
     + Khi cấu hình các file cấu hình chính của web server thì cần mở quyền Admin cho ứng dụng viết cấu hình.
     + Khi cài đặt hay khởi động nodered thì cần mở quyền Admin cho CMD.
     + Khi cấu hình các node trên nodered thì cần tìm hiểu thật kỹ các thuộc tính của từng node, cần hiểu cách node đó hoạt động như nào.
     + Khi cấu hình node MSSQL thì cần connect tới SQL Server, cần điền chính xác các thông tin như servername, port, username, password, database name. Ngoài ra cần tìm hiểu và xác định đúng Query Mode.
     + Nên test connect của từng node trước bằng cách thêm node Debug. Trong quá trình test connect thì cần mở Debug message, đọc các message sau khi deploy node để xem kết quả deploy đúng hay chưa.
     + Sau mỗi lần sửa cấu hình node cần nhấn nút Update và Deploy lại 1 lần

   - **Dựng cơ sở dữ liệu**:
     + Cơ sở dữ liệu sử dụng trong bài toán tìm kiếm ở mức cơ bản, chỉ có các thuộc tính cần thiết của 1 sản phẩm (id, name, brand, countInStock, description..).
     + Dữ liệu demo nhập vào khoảng 20 items, các dữ liệu này đủ để phục vụ cho quá trình test tính năng tìm kiếm
   - **Cách dùng Nodered để tạo Backend**
     + Về cơ bản, Nodered dễ sử dụng, linh hoạt
     + Cần hiểu rõ các node để connect đúng
     + Các thuộc tính trong các node thay thế cho các dòng lệnh dài dòng khi code chay.
     + Khi mới bắt đầu cần test connect từng node, sử dụng Inject (timestamp) thay cho http in để test cho dễ thực hiện
     + Debug quan trọng, nên đọc kỹ debug để tìm ra lỗi khi connect.
  - **Cách frontend tương tác với backend**:
     + Khi client gửi phương thức POST/GET thì bên backend là API Nodered sẽ nhận và xử lý yêu cầu: truy vấn database (SQL Server). Sau đó trả về kết quả cho client.
     + Kết quả backend trả về dạng json, frontend sẽ nhận json này bằng js thông qua hàm fetch(), và sau đó cập lên giao diện.
     + Connect DB với Backend Nodered thông qua nhập các thuộc tính server name, port, username, ....
     
     

