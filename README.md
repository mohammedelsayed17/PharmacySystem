# Pharmacy Management System – ASP.NET Core MVC

  A simple yet powerful web-based Pharmacy Management System built with ASP.NET Core MVC. The system provides secure user registration and login with role-based authorization, allowing administrators to manage medicines and users, while customers can browse, search, and manage their shopping cart.

# Features:

User registration with email, name, and password.

Login/logout functionality with cookie-based authentication.

Role-based access control:

Admin: Full access to medicine management and user promotion.

User: Can browse and add medicines to cart.

##  Medicine Management (Admin only)
Add, edit, delete medicines.

Search medicines by name.

## Shopping Cart
Add medicines to cart.

View cart with quantity and total price.

Remove items from cart.

##  Admin Dashboard
View all users.

Promote/demote users to/from admin role.

## Cookie Demo
Basic example of setting, reading, and deleting cookies.

# Basic example of setting, reading, and deleting cookies.
  ASP.NET Core MVC
  
  Entity Framework Core (Code First)
  
  Identity for authentication & role management
  
  LINQ & EF eager loading
  
  SQL Server (via EF DbContext)
  
  Bootstrap for UI (if applicable)

#  Project Structure Highlights:
  Controllers: Logic for Account, Admin, Medicine, Cart, Cookie.
  
  Models: Entity classes and view models.
  
  Views: Razor pages for user interaction.
  
  Services: Abstraction over data access (e.g., IMedicineRepository).
# How to Run:
Clone the repo

Update connection string in appsettings.json

Run migrations or use existing DB

Launch with dotnet run or via VS Code

Register a new user, and promote via /Admin










