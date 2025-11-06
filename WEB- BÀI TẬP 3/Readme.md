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

    <img width="1473" height="762" alt="image" src="https://github.com/user-attachments/assets/04beb8ae-0070-4d2a-8693-692430667e42" />
 
    <img width="576" height="228" alt="Ảnh chụp màn hình 2025-11-04 174340" src="https://github.com/user-attachments/assets/487d7ff2-5dcb-44fa-9033-a74225ac938e" />

    <img width="1466" height="293" alt="Ảnh chụp màn hình 2025-11-04 174522" src="https://github.com/user-attachments/assets/305e2aa9-1aa7-4a14-a06b-3709d357cfdc" />

     - Tạo file default.conf trong nginx:

   <img width="1449" height="670" alt="image" src="https://github.com/user-attachments/assets/c13421cd-dc6d-4279-b1c4-f106f7d1c273" />

      - Tạo file grafana.ini trong grafana:

     <img width="1449" height="670" alt="image" src="https://github.com/user-attachments/assets/08560626-23eb-4546-aa5d-64775dce0826" />

      - Sau khi tạo xong thì nhập docker compose up -d

      <img width="522" height="199" alt="Ảnh chụp màn hình 2025-11-04 203948" src="https://github.com/user-attachments/assets/d2df4c5a-c1f3-4a8e-9373-9e47344a481a" />

       - Nhập Docker ps để xem các cổng chạy đối với từng images:

     <img width="1436" height="337" alt="Ảnh chụp màn hình 2025-11-04 204102" src="https://github.com/user-attachments/assets/c657c3d9-72bb-4e80-8b85-dfcb3d0d9699" />

     <img width="1899" height="968" alt="Ảnh chụp màn hình 2025-11-06 225643" src="https://github.com/user-attachments/assets/fdf26e8c-694d-487f-8b42-30eac4e8ddf5" />

    <img width="1911" height="976" alt="Ảnh chụp màn hình 2025-11-06 225758" src="https://github.com/user-attachments/assets/327b262d-22fd-4510-aaf4-d823aebc0154" />






