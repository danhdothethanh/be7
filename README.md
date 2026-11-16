# MaSV_MyStore - Customer Site (ASP.NET MVC5 + Entity Framework)

Dự án website bán hàng phần Customer theo đề bài BE Development (Customer Site).

## Tính năng đã triển khai

### Tài khoản (Account)
- **Đăng ký** (`/Account/Register`): Form đăng ký với validation, tạo User + Customer
- **Đăng nhập** (`/Account/Login`): Forms Authentication + Session, Remember Me
- **Đăng xuất** (`/Account/Logout`)
- **Thông tin tài khoản** (`/Account/ProfileInfo`): Xem & cập nhật thông tin, đổi mật khẩu

### Trang chủ & Sản phẩm (Home)
- Trang Home với tìm kiếm, sản phẩm nổi bật, danh sách + phân trang
- Danh sách sản phẩm theo danh mục
- Chi tiết sản phẩm + sản phẩm tương tự

### Giỏ hàng (Cart)
- Thêm / xóa / cập nhật số lượng / xóa toàn bộ
- Session-based CartService

### Đơn hàng (Order)
- Checkout (địa chỉ, phương thức giao/thanh toán)
- Xác nhận đơn hàng thành công
- Lịch sử mua hàng (lọc theo trạng thái, tìm kiếm)

### Layout
- `_CustomerLayout.cshtml` tái sử dụng
- Menu danh mục (Partial `_CategoriesPV`)
- Menu cá nhân (đăng nhập/đăng ký hoặc profile/logout + giỏ hàng)

## Cấu trúc chính

```
MaSV_MyStore/
├── Controllers/
│   ├── AccountController.cs
│   ├── HomeController.cs
│   ├── CartController.cs
│   └── OrderController.cs
├── Models/
│   ├── User.cs, Customer.cs, Product.cs, Category.cs, Order.cs, OrderDetail.cs
│   ├── MyStoreEntities.cs (DbContext)
│   └── ViewModel/
│       ├── RegisterVM.cs, LoginVM.cs
│       ├── HomeProductVM.cs, ProductDetailVM.cs
│       ├── CartItem.cs, Cart.cs, CartService.cs
│       └── CheckoutVM.cs
├── Views/
│   ├── Shared/_CustomerLayout.cshtml, _CategoriesPV.cshtml
│   ├── Account/...
│   ├── Home/...
│   ├── Cart/...
│   └── Order/...
├── Web.config (Forms Authentication timeout=3600)
└── packages.config
```

## Hướng dẫn chạy

1. Mở `MaSV_MyStore.sln` bằng Visual Studio 2017/2019/2022
2. Restore NuGet packages (EntityFramework, PagedList, ASP.NET MVC 5)
3. Tạo database LocalDB hoặc SQL Server, cập nhật connection string trong `Web.config`
4. Có thể dùng Code First (DbContext sẽ tạo DB) hoặc import schema từ EDMX
5. Chạy project (F5)

## Lưu ý theo đề

- Sử dụng Forms Authentication như yêu cầu Web.config
- Register tạo cả User và Customer
- Login dùng `FormsAuthentication.SetAuthCookie`
- ViewModel + Data Annotation validation
- Layout Customer riêng, Partial View cho Category & Personal Menu

## Mở rộng (tùy chọn)

- Hash password (BCrypt / ASP.NET Identity)
- PayPal integration (đã có appSettings)
- Giỏ hàng nâng cao (group by Category)
- Admin Area

---
Theo đề: ThS. Bùi Thị Thanh Tú - Xây dựng website bán hàng bằng ASP.NET MVC5 Entity Framework
