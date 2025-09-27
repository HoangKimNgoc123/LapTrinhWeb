## SINH VIÊN : HOÀNG KIM NGỌC - MSSV: K225480106053 - K58KTP
## BÀI TẬP VỀ NHÀ 01  

### Yêu cầu:  
Tạo **Solution** gồm các **Project** sau:  
  - DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis).
  - Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE
  - Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE
  - Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.
### Bài làm
#### Thuật toán Caesar Cipher
1. Giới thiệu  
- **Mã hóa Caesar (Caesar Cipher)** là một thuật toán mã hóa cổ điển.  
- Ý tưởng: dịch mỗi ký tự trong văn bản gốc sang một ký tự khác, cách nó một số bước `Shift` trong bảng chữ cái.  
Ví dụ:  
- Plaintext: `HELLO`  
- Shift = `3`  
- Ciphertext: `KHOOR`  

2. Công thức  
- Với ký tự có chỉ số `x` (A=0, B=1, ..., Z=25), dịch `k` bước:  
- Mã hóa:  
C = (x + k) mod 26
- Giải mã:  
P = (x - k + 26) mod 26
##### Tạo DLL: CaesarLib (Class Library .NET 2.0)
1. Tạo project
    - File → New → Project → chọn Class Library (.NET Framework)

      <img width="1910" height="1033" alt="Không có tiêu đề" src="https://github.com/user-attachments/assets/768854ad-e0eb-4a57-84b8-4f87e465a690" />

      <img width="1919" height="1033" alt="Không có tiêu đề" src="https://github.com/user-attachments/assets/6c38ca22-9d79-4bda-bfb4-aebc52113a59" />

    - Project name: CaesarLib → Target Framework: .NET Framework 2.0 → Create.

      <img width="833" height="606" alt="Ảnh chụp màn hình 2025-09-28 010345" src="https://github.com/user-attachments/assets/300e2ccf-b302-4599-b817-995001f9a9bd" />

2. Thêm file CaesarCipher.cs
    - Thêm file mới CaesarCipher.cs

      <img width="1917" height="1078" alt="Ảnh chụp màn hình 2025-09-28 010640" src="https://github.com/user-attachments/assets/f6b8c93b-e1ac-4ebf-b318-a759e52a3bae" />
3. Build
    - Build → Build CaesarLib. Kết quả: CaesarLib.dll

      <img width="1919" height="1033" alt="Không có tiêu đề" src="https://github.com/user-attachments/assets/2ca981c2-263c-4066-9462-f3fbc0905317" />
      <img width="1919" height="1033" alt="Không có tiêu đề" src="https://github.com/user-attachments/assets/dcb81d4b-9ceb-499f-a7d4-39f7828d0a79" />

##### Tạo Console App: CaesarConsole (Console .NET 2.0)
1. Tạo project
    - Solution Explorer → Right-click Solution → Add → New Project → Console App (.NET Framework)

      <img width="905" height="950" alt="Ảnh chụp màn hình 2025-09-28 011916" src="https://github.com/user-attachments/assets/095728ed-0762-467a-839d-6cf11af58d7e" />

      <img width="457" height="108" alt="Ảnh chụp màn hình 2025-09-28 012105" src="https://github.com/user-attachments/assets/8bdb551b-1c50-4a82-8a09-40bdf937ba7a" />

    - Project name: CaesarConsole → Target .NET Framework 2.0.

      <img width="866" height="537" alt="Ảnh chụp màn hình 2025-09-28 012233" src="https://github.com/user-attachments/assets/3fd8155b-8260-4a14-8423-d61b9eff53c3" />

2. Tham chiếu DLL

  - Trong CaesarConsole → References → Add Reference... → Projects → chọn CaesarLib → OK.

  <img width="430" height="324" alt="Ảnh chụp màn hình 2025-09-28 012311" src="https://github.com/user-attachments/assets/c1fa604e-5ff4-4bc7-940a-31e679883d32" />

  <img width="977" height="668" alt="Ảnh chụp màn hình 2025-09-28 012348" src="https://github.com/user-attachments/assets/3e8e79bf-3b77-4b58-ac26-8ead5fcc9718" />

3. Code Program.cs:

   <img width="1448" height="624" alt="Ảnh chụp màn hình 2025-09-28 012435" src="https://github.com/user-attachments/assets/51b14978-1e35-4360-8e81-d6ba04e2fdda" />

4. Build & Run

    - Build solution → Run CaesarConsole.
  
      <img width="1472" height="763" alt="image" src="https://github.com/user-attachments/assets/446a0565-891e-40c2-b54e-24b85c9e5780" />

      <img width="1472" height="759" alt="Ảnh chụp màn hình 2025-09-28 012728" src="https://github.com/user-attachments/assets/85254f0e-c0b3-4cf6-96e8-c8f901da4eaf" />
##### Tạo Windows Forms: CaesarWin (WinForms .NET 2.0)
1. Tạo project
    - Add → New Project → Windows Forms App (.NET Framework)
    
       <img width="705" height="114" alt="Ảnh chụp màn hình 2025-09-28 013315" src="https://github.com/user-attachments/assets/e12c18cd-6a01-4411-b9fd-f259cb113b21" />
       
    - Project name: CaesarWin → Target .NET 2.0.

      <img width="848" height="579" alt="Ảnh chụp màn hình 2025-09-28 013429" src="https://github.com/user-attachments/assets/66cf7264-ae81-4324-ada2-b892bbb3e2cc" />

2. Add Reference → CaesarLib (Project)
3. Thiết kế Form (Form1)

     <img width="1919" height="1079" alt="Ảnh chụp màn hình 2025-09-28 013705" src="https://github.com/user-attachments/assets/a71e8f98-4154-4deb-a71f-17c788a2a0ac" />

4. Code phía Form (Form1.cs)
5. Build & Run
      - Run CaesarWin, nhập text, chọn shift, bấm “Mã hoá”

          <img width="736" height="491" alt="Ảnh chụp màn hình 2025-09-28 014017" src="https://github.com/user-attachments/assets/38fd3ec9-14c0-48cd-88a3-e73ad19f07d2" />

          <img width="760" height="489" alt="Ảnh chụp màn hình 2025-09-28 014134" src="https://github.com/user-attachments/assets/6bd9759e-1430-4335-8155-54f782ba3836" />
##### Tạo Web App: CaesarWeb (ASP.NET Web Application .NET 2.0)
1. Tạo project web
    - Add → New Project → ASP.NET Web Application (.NET Framework)
  
      <img width="1170" height="91" alt="Ảnh chụp màn hình 2025-09-28 014236" src="https://github.com/user-attachments/assets/bbeb4fdc-c206-4788-b6cd-6db60b19877c" />

    - Project name: CaesarWeb → Target .NET Framework 2.0 

      <img width="853" height="547" alt="Ảnh chụp màn hình 2025-09-28 014401" src="https://github.com/user-attachments/assets/1fd0f29b-0fc5-47e9-af99-c5f50d81a1f4" />

2. Add Reference → chọn CaesarLib project.
3. Thêm api.aspx
      - Add → New Item → Web Form → name api.aspx.

      <img width="1172" height="820" alt="image" src="https://github.com/user-attachments/assets/f247d233-a495-4310-94b9-ba69bba4ca6b" />

      - Mở api.aspx và chỉ giữ directive dòng 1 (xóa phần design):
      
      <img width="1463" height="631" alt="Ảnh chụp màn hình 2025-09-28 014505" src="https://github.com/user-attachments/assets/f19491bd-9121-4a7e-80c9-e6541fce42e0" />

4. Viết api.aspx.cs

       <img width="1172" height="820" alt="image" src="https://github.com/user-attachments/assets/f8af9a42-9ab3-4cf0-a812-9be7119155c2" />
  
5. Thêm file client index.html

      <img width="1475" height="652" alt="Ảnh chụp màn hình 2025-09-28 014633" src="https://github.com/user-attachments/assets/1ef6d006-cc98-40c2-b7bf-27bd36f2a777" />

6. Build & test trong Visual Studio

    - Build solution.
    - Trong CaesarWeb project, chuột phải index.html → Set As Start Page.

     <img width="317" height="33" alt="image" src="https://github.com/user-attachments/assets/a63831e3-6e00-436d-bd03-4fc083d6b72c" />

7. Deploy lên IIS và tạo domain ảo

    <img width="1411" height="716" alt="Ảnh chụp màn hình 2025-09-28 014842" src="https://github.com/user-attachments/assets/2b679d10-f08f-43f2-8a06-2a61ca30e861" />

  - Sửa file hosts (Admin)
  - Mở Notepad as Administrator → Open C:\Windows\System32\drivers\etc\hosts

    <img width="1773" height="916" alt="Ảnh chụp màn hình 2025-09-28 015027" src="https://github.com/user-attachments/assets/ff173e22-befb-460f-81e4-64bb8448d648" />

8. Kết quả

    <img width="1914" height="1021" alt="Ảnh chụp màn hình 2025-09-28 015205" src="https://github.com/user-attachments/assets/0c4c0f8b-8932-4aae-8bb3-9fdccddefc9e" />


    <img width="1909" height="986" alt="Ảnh chụp màn hình 2025-09-28 015251" src="https://github.com/user-attachments/assets/7d9500a6-1726-4207-8e8f-ffd1f35875bd" />
