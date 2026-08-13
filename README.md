# C# Windows Forms GUI Application ( Candy Store POS System ) 

## 📌 Project Overview

This project is a **C# Windows Forms GUI Application** developed using **Visual Studio** and **.NET Framework**.

The application provides a graphical user interface to manage and perform different system functions through Windows Forms.

## 🛠️ Technologies Used

* **C#**
* **.NET Framework**
* **Windows Forms**
* **Visual Studio**
* **SQL Server**
* **Crystal Reports**
* **Guna UI2**
* **ADO.NET**

## ✨ Features

* User-friendly Windows Forms GUI
* Multiple forms for different functions
* Database connectivity
* Data entry and management
* DataGridView-based data display
* Report generation
* Crystal Reports integration
* Print functionality
* Form navigation
* SQL Server database support

## 📂 Project Structure

```
Candy Store-GUI/
│
├── Candy Store GUI.sln
│
└── Candy Store GUI/
    ├── Program.cs
    ├── App.config
    ├── function.cs
    ├── Form1.cs
    ├── Form1.Designer.cs
    ├── Form1.resx
    ├── Form2.cs
    ├── Form2.Designer.cs
    ├── Form2.resx
    ├── ...
    ├── CrystalReport1.rpt
    ├── DGVPrinter.cs
    ├── PrintReports.cs
    ├── reportview.cs
    ├── Properties/
    └── packages.config
```

## ⚙️ Requirements

Before running the project, make sure you have:

* Visual Studio
* .NET Framework compatible with the project
* SQL Server
* SQL Server Management Studio (SSMS)
* Crystal Reports for Visual Studio
* Required NuGet packages

## 🚀 How to Run

### 1. Clone the Repository

```
git clone YOUR_GITHUB_REPOSITORY_URL
```

### 2. Open the Project

Open:

```
Candy Store.sln
```

using **Visual Studio**.

### 3. Restore NuGet Packages

Restore the required NuGet packages through Visual Studio.

### 4. Configure the Database

Create the required database in SQL Server and update the database connection string in:

```
App.config
```

### 5. Build the Project

In Visual Studio:

```
Build → Build Solution
```

### 6. Run the Application

Press:

```
F5
```

or click **Start** in Visual Studio.

## 🗄️ Database

The application uses **Microsoft SQL Server** for storing and managing application data.

Make sure the SQL Server connection details in `App.config` match your local database configuration.

## 📊 Reports

The project includes **Crystal Reports** for generating and displaying reports.

Report files are included in the project as:

```text
CrystalReport1.rpt
```

## 🖨️ Printing

The application also includes printing functionality using:

```text
DGVPrinter.cs
```

This allows data displayed in DataGridView controls to be prepared for printing.

## 🔐 Configuration

Database connection settings should be configured according to the local SQL Server environment.

> **Note:** Do not upload real database passwords, API keys, or other sensitive credentials to GitHub.

## 👨‍💻 Developer

**Seshan Rodrigo**

- LinkedIn: https://www.linkedin.com/in/your-profile
- GitHub: https://github.com/yourusername

## 📄 License

This project was developed for **educational and academic purposes**.
