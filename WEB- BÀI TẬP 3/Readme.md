### Họ và tên: Hoàng Kim Ngọc 
### MSSV: K2254801053 
### Lớp: K58KTP
# BÀI TẬP 3 học phần Phát triển ứng dụng trên nền web
#### Ngày giao   : 2025-10-24 13:50
#### Hạn nộp     : 2025-11-05 00:00
Yêu cầu: LẬP TRÌNH ỨNG DỤNG WEB trên nền linux
1. Cài đặt môi trường linux: SV chọn 1 trong các phương án
 - enable wsl: cài đặt docker desktop
 - enable wsl: cài đặt ubuntu
 - sử dụng Hyper-V: cài đặt ubuntu
 - sử dụng VMware : cài đặt ubuntu
 - sử dụng Virtual Box: cài đặt ubuntu
2. Cài đặt Docker (nếu dùng docker desktop trên windows thì nó có ngay)
3. Sử dụng 1 file docker-compose.yml để cài đặt các docker container sau: 
   mariadb (3306), phpmyadmin (8080), nodered/node-red (1880), influxdb (8086), grafana/grafana (3000), nginx (80,443)
4. Lập trình web frontend+backend:
   Web thương mại điện tử
 - Tạo web dạng Single Page Application (SPA), chỉ gồm 1 file index.html, toàn bộ giao diện do javascript sinh động.
 - Có tính năng login, lưu phiên đăng nhập vào cookie và session
   Thông tin login lưu trong cơ sở dữ liệu của mariadb, được dev quản trị bằng phpmyadmin, yêu cầu sử dụng mã hoá khi gửi login.
   Chỉ cần login 1 lần, bao giờ logout thì mới phải login lại.
 - Có tính năng liệt kê các sản phẩm bán chạy ra trang chủ
 - Có tính năng liệt kê các nhóm sản phẩm
 - Có tính năng liệt kê sản phẩm theo nhóm
 - Có tính năng tìm kiếm sản phẩm
 - Có tính năng chọn sản phẩm (đưa sản phẩm vào giỏ hàng, thay đổi số lượng sản phẩm trong giỏ, cập nhật tổng tiền)
 - Có tính năng đặt hàng, nhập thông tin giao hàng => được 1 đơn hàng.
 - Có tính năng dành cho admin: Thống kê xem có bao nhiêu đơn hàng, call để xác nhận và cập nhật thông tin đơn hàng. chuyển cho bộ phận đóng gói, gửi bưu điện, cập nhật mã COD, tình trạng giao hàng, huỷ hàng,...
 - Có tính năng dành cho admin: biểu đồ thống kê số lượng mặt hàng bán được trong từng ngày. (sử dụng grafana)
 - backend: sử dụng nodered xử lý request gửi lên từ javascript, phản hồi về json.
## BÀI LÀM
1. Cài đặt môi trường linux:
   - enable wsl: cài đặt ubuntu
     Mở PowerShell với quyền Administrator: chạy lệnh wsl --install

   <img width="1127" height="293" alt="Ảnh chụp màn hình 2025-11-04 165413" src="https://github.com/user-attachments/assets/16f0b4f3-9d97-4ae3-be37-eeff98485e11" />

   - Cài Password:

   <img width="1475" height="682" alt="Ảnh chụp màn hình 2025-11-04 173426" src="https://github.com/user-attachments/assets/4e913924-a36b-4720-8851-55b60b7a9e3c" />

   - Tạo folder làm việc và di chuyển tới folder đó:

    <img width="246" height="47" alt="Ảnh chụp màn hình 2025-11-04 174142" src="https://github.com/user-attachments/assets/5f87a283-1962-4b67-86e8-34e6bcceb445" />

2. Tạo file docker-compose.yml

    <img width="456" height="27" alt="Ảnh chụp màn hình 2025-11-04 174307" src="https://github.com/user-attachments/assets/9f30ca9c-0258-4a07-8056-49865e4fc31e" />

    <img width="1460" height="754" alt="Ảnh chụp màn hình 2025-11-04 174253" src="https://github.com/user-attachments/assets/16a7e000-4215-4809-8cc7-10db08ecaa3b" />

    - Sau khi tạo xong thì nhập docker compose up -d

      ![Uploading Ảnh chụp màn hình 2025-11-04 174522.png…]()

    
    
    
