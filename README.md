# Pharmacy Management System

A web-based pharmacy management system built using **ASP.NET Core MVC** with **Entity Framework Core**, designed to streamline operations such as managing medicines, categories, and orders in a modern, responsive interface.

## 🚀 Features

- ✅ Add, edit, and delete medicines  
- ✅ Manage medicine categories  
- ✅ View and track medicine availability  
- ✅ Responsive and user-friendly UI  
- ✅ Entity Framework Core with Code-First Migrations  
- ✅ Built with ASP.NET Core MVC (.NET 5)

## 🧠 Technologies Used

- ASP.NET Core MVC (.NET 5)  
- Entity Framework Core  
- SQL Server  
- Bootstrap 5 (for styling)  
- Git + GitHub for version control

## 📁 Project Structure

- `Models/` – Entity classes (Medicine, Category, etc.)  
- `Controllers/` – Handles business logic and routing  
- `Views/` – Razor view files for the UI  
- `Data/` – EF Core context and seeders  
- `Migrations/` – Database migration history  
- `wwwroot/` – Static assets (CSS, JS, images)

## ⚙️ Getting Started

1. **Clone the repo**  
   ```bash
   git clone https://github.com/NoorTantawi/Pharmacy.git
   cd Pharmacy
   ```

2. **Set your connection string** in `appsettings.json`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=.;Database=PharmacyDb;Trusted_Connection=True;"
   }
   ```

3. **Run database migrations**
   ```bash
   dotnet ef database update
   ```

4. **Run the application**
   ```bash
   dotnet run
   ```

5. Open `https://localhost:5001` in your browser.

## 📸 Screenshots

> You can add screenshots here showing the dashboard, medicine list, and add/edit forms.

## 🙋‍♂️ Author

**Noor-Aldeen Tayseer Tantawi**  
[LinkedIn](https://www.linkedin.com/in/nooraldeen-tantawi-3bb899237/)  
[GitHub](https://github.com/NoorTantawi)

---

Feel free to fork, contribute, or submit issues!
