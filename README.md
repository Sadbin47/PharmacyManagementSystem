<div align="center">

# 🏥 Pharmacy Management System

<img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#"/>
<img src="https://img.shields.io/badge/.NET_Framework-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET Framework"/>
<img src="https://img.shields.io/badge/Microsoft_SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white" alt="SQL Server"/>
<img src="https://img.shields.io/badge/Windows_Forms-0078D4?style=for-the-badge&logo=windows&logoColor=white" alt="Windows Forms"/>

*A comprehensive desktop solution for modern pharmacy operations* 🚀

[Features](#-features) • [Installation](#-installation) • [Database](#-database) • [Contributing](#-contributing)

</div>

---

## 🌟 Overview

The **Pharmacy Management System** is a robust desktop application designed to streamline pharmacy operations. Built with C# Windows Forms and SQL Server, it provides secure inventory management, sales processing, and role-based user access.

### 🎯 Key Benefits
- ✅ Streamlined medicine inventory management
- ✅ Secure role-based authentication (Manager/Salesman)
- ✅ Real-time sales processing and billing
- ✅ Comprehensive reporting and analytics
- ✅ 2NF normalized database design

---

## ✨ Features

<table>
<tr>
<td width="50%">

### 🔐 Security & Users
- **Role-based Access Control**
- **Secure Login System**
- **User Registration & Management**
- **Manager and Salesman roles**

### 💊 Medicine Management
- **Complete CRUD Operations**
- **Batch Number Tracking**
- **Expiry Date Monitoring**
- **Category-based Organization**
- **Advanced Search & Filtering**

</td>
<td width="50%">

### 💰 Sales & Billing
- **Point of Sale Interface**
- **Multiple Payment Methods**
- **Real-time Inventory Updates**
- **Receipt Generation**
- **Transaction History**

### 📊 Reporting
- **Sales Performance Reports**
- **Inventory Status**
- **Low Stock Alerts**
- **Employee Performance**
- **Dashboard Analytics**

</td>
</tr>
</table>

---

## 📋 Requirements Compliance

<div align="center">

### ✅ **100% Requirements Fulfilled**

</div>

| Requirement | Status | Implementation |
|-------------|--------|----------------|
| At least 2 types of User | ✅ | Manager & Salesman roles |
| Database Connection Class | ✅ | Centralized connection management |
| Normalized DB (2NF) | ✅ | Proper table relationships |
| Desktop based App | ✅ | Windows Forms application |
| Use of Properties | ✅ | OOP principles throughout |
| Form Validation | ✅ | Input validation on all forms |
| Search Option | ✅ | Global search functionality |
| OOP Principles | ✅ | Classes, inheritance, encapsulation |
| Database CRUD | ✅ | Complete Create, Read, Update, Delete |
| Exception Handling | ✅ | Comprehensive error management |

---

## 🚀 Installation

### Prerequisites
- Windows 10/11
- .NET Framework 4.7.2+
- SQL Server 2016+ or SQL Server Express
- 4GB RAM (recommended)

### Setup Steps

1. **Clone Repository**
   ```bash
   git clone https://github.com/Sadbin47/pharmacy-management-system.git
   cd pharmacy-management-system
   ```

2. **Database Setup**
   ```sql
   CREATE DATABASE PharmacyManagementDB;
   -- Execute provided SQL scripts
   ```

3. **Configure Connection**
   ```xml
   <!-- Update App.config -->
   <connectionStrings>
     <add name="PharmacyDB" 
          connectionString="Data Source=YOUR_SERVER;Initial Catalog=PharmacyManagementDB;Integrated Security=True" />
   </connectionStrings>
   ```

4. **Build & Run**
   ```bash
   # Open in Visual Studio
   # Build Solution (Ctrl+Shift+B)
   # Run (F5)
   ```

### Default Login
| Role | Username | Password |
|------|----------|----------|
| Manager | `admin` | `admin123` |
| Salesman | `sales01` | `sales123` |

---

## 📊 Database

### Core Tables
```sql
Users (UserId, RoleId, UserName, Password)
Role (RoleId, Role)
Medicine (MedicineId, Name, Category, UnitPrice, UnitCost, BatchNumber, Manufacturer, ExpiryDate, UnitAvailable)
Sales (SaleId, SaleDate, SalesmanID, CustomerName, TotalAmount, PaymentMethod)
SalesDetails (SaleDetailID, SaleID, MedicineID, Quantity, UnitPrice, Subtotal)
```

### Key SQL Operations

<details>
<summary>📝 <strong>Authentication Queries</strong></summary>

```sql
-- User Login
SELECT s.UserId, s.Password, r.Role 
FROM Users s 
INNER JOIN Role r ON s.RoleId = r.RoleID 
WHERE s.UserId = @UserId AND s.Password = @Password
```
</details>

<details>
<summary>💊 <strong>Medicine Management</strong></summary>

```sql
-- Get All Medicines
SELECT * FROM Medicine

-- Add Medicine
INSERT INTO Medicine (MedicineId, Name, Category, UnitPrice, UnitCost, BatchNumber, Manufacturer, ExpiryDate, UnitAvailable) 
VALUES (@MedicineId, @Name, @Category, @UnitPrice, @UnitCost, @BatchNumber, @Manufacturer, @ExpiryDate, @UnitAvailable)

-- Update Medicine
UPDATE Medicine SET Name = @Name, Category = @Category, UnitPrice = @UnitPrice 
WHERE MedicineId = @MedicineId

-- Search Medicines
SELECT * FROM Medicine WHERE Name LIKE @SearchTerm + '%' OR Category LIKE @SearchTerm + '%'
```
</details>

<details>
<summary>🛒 <strong>Sales Processing</strong></summary>

```sql
-- Create Sale
INSERT INTO Sales (SaleId, SaleDate, SalesmanID, CustomerName, TotalAmount, PaymentMethod) 
VALUES (@SaleId, @SaleDate, @SalesmanID, @CustomerName, @TotalAmount, @PaymentMethod)

-- Add Sale Details
INSERT INTO SalesDetails (SaleDetailID, SaleID, MedicineID, Quantity, UnitPrice, Subtotal) 
VALUES (@DetailId, @SaleId, @MedicineId, @Quantity, @UnitPrice, @Subtotal)

-- Update Inventory
UPDATE Medicine SET UnitAvailable = UnitAvailable - @Quantity WHERE MedicineId = @MedicineId
```
</details>

---

## 👥 User Roles

### 👔 Manager Access
- ✅ Complete system access
- ✅ User management (create, update, delete)
- ✅ Full medicine CRUD operations
- ✅ Sales management and oversight
- ✅ All reports and analytics
- ✅ System configuration

### 🛍️ Salesman Access
- ✅ Sales processing and billing
- ✅ Medicine viewing and search
- ✅ Basic sales reports

---

## 🔧 Technical Stack

| Component | Technology | Purpose |
|-----------|------------|---------|
| **Frontend** | Windows Forms | Desktop UI |
| **Backend** | C# .NET Framework | Application Logic |
| **Database** | SQL Server | Data Storage |
| **Architecture** | Layered | Code Organization |
| **Security** | Role-based Access | User Management |

---

## 🔮 Future Enhancements

- 🌐 **Web Application** - ASP.NET Core migration
- 📱 **Mobile App** - Cross-platform mobile support
- ☁️ **Cloud Integration** - Azure/AWS deployment
- 🤖 **AI Analytics** - Predictive inventory management
- 🔗 **API Integration** - Third-party service connections

---

## 🤝 Contributing

1. **Fork** the repository
2. **Create** feature branch (`git checkout -b feature/amazing-feature`)
3. **Commit** changes (`git commit -m 'Add amazing feature'`)
4. **Push** to branch (`git push origin feature/amazing-feature`)
5. **Open** Pull Request

### Coding Standards
- Follow C# naming conventions
- Add comprehensive comments
- Include unit tests for new features
- Update documentation

---

<div align="center">

## 📞 Contact

<a href="https://github.com/Sadbin47">
  <img src="https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white" alt="GitHub"/>
</a>

---

### 📄 License

This project is Owned by @Sadbin47

---

<p align="center">
  <strong>Made with ❤️ by <a href="https://github.com/Sadbin47">Sadbin47</a></strong><br>
  <sub>🏥 Revolutionizing pharmacy management, one line of code at a time</sub>
</p>

**🌟 If this project helped you, please consider giving it a star! 🌟**

</div>
