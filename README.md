# smart-customer-analytics-crm

A full-stack Customer Relationship Management (CRM) web application built using ASP.NET Core Razor Pages, MySQL, and ADO.NET.
This project goes beyond basic CRUD by integrating search, analytics dashboard, and modular architecture, making it suitable for real-world business use.

🚀 Features
✅ Customer Management (Create, Read, Update, Delete)
🔍 Search & Filter Customers
📊 Analytics Dashboard (Total Customers Insights)
🛡️ Form Validation & Error Handling
⚡ Optimized Database Queries using ADO.NET
🎯 Clean and Modular Code Structure

🛠️ Tech Stack
Frontend: Razor Pages (ASP.NET Core), HTML, CSS, Bootstrap
Backend: ASP.NET Core (.NET 6/7/8/10)
Database: MySQL
Data Access: ADO.NET
Tools: Visual Studio Code, NuGet Package Manager

📂 Project Structure
CRMProject/
│
├── Pages/
│   ├── Customers/
│   │   ├── Index.cshtml
│   │   ├── Create.cshtml
│   │   ├── Edit.cshtml
│   │   ├── Delete.cshtml
│   │   ├── Dashboard.cshtml
│
├── Models/
│   └── Customer.cs
│
├── Services/
│   └── CustomerService.cs
│
├── wwwroot/
├── Program.cs
├── appsettings.json
⚙️ Installation & Setup

1️⃣ Prerequisites
Install .NET SDK
Install MySQL Server
Install Visual Studio Code

(Setup steps inspired from ASP.NET Core practice guide)

2️⃣ Clone Repository
git clone https://github.com/your-username/smart-crm.git
cd smart-crm

3️⃣ Install Required Packages
  - dotnet add package MySql.Data
  - dotnet add package MySqlConnector

4️⃣ Database Setup
  - Run the following SQL queries:

CREATE DATABASE smartcrm;
USE smartcrm;
CREATE TABLE customers (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100),
    email VARCHAR(150),
    phone VARCHAR(20),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

5️⃣ Configure Database Connection
Update connection string inside CustomerService.cs:
"Server=localhost;Database=smartcrm;Uid=root;Pwd=yourpassword;"
6️⃣ Run the Application
dotnet run

Open browser:
http://localhost:5019

📊 Key Functional Modules
🔹 Customer Management
  - Add new customers
  - Edit existing records
  - Delete customers
  - View customer list
🔹 Search Functionality
  - Search customers by name
  - Real-time filtering
🔹 Dashboard
  - Displays total customers
  - Provides quick business insights

🔮 Future Enhancements
  🔐 User Authentication (JWT / Identity)
  📊 Advanced Analytics (Charts & Graphs)
  🌐 Cloud Deployment (Azure / AWS)
  📁 Export Data (CSV / Excel)
  🤝 Contributing

Contributions are welcome!
Feel free to fork this repository and submit a pull request.

📧 Contact
If you have any questions or suggestions, feel free to reach out.

⭐ Show Your Support
If you like this project, give it a ⭐ on GitHub!

