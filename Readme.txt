 # Employee Management System
 # Employee Management System
 
 A simple web application for managing employee records using ASP.NET Core MVC and MySQL.
 
 ## Features
 
 - View all employees
 - Add new employees
 - Edit employee information
 - View employee details
 - Delete employees
 
 ## Project Structure
 
 - **Models/Employee.cs**: Defines the Employee class with properties:
   - Id (Primary Key)
   - Name
   - Position
   - Salary
 
 - **Models/AppDbContext.cs**: Database context for Entity Framework Core
 - **Controllers/EmployeesController.cs**: Handles all employee-related operations (CRUD)
 
 - **Views/Employees/**: Contains all the views:
   - Index.cshtml (List all employees)
   - Create.cshtml (Add new employee)
   - Edit.cshtml (Edit employee)
   - Details.cshtml (View employee details)
   - Delete.cshtml (Delete confirmation)
 ## Database Setup
 
The project uses MySQL database. The database structure was created using these SQL commands:


 
 ## Connection String
 
 The database connection is configured in `appsettings.json`:
 ```json
 "ConnectionStrings": {
     "DefaultConnection": "server=localhost;database=employees;user=root;password=12345678"
 }

 
 ## Technologies Used
 
 - ASP.NET Core MVC - Entity Framework Core
 - MySQL
 - Bootstrap (for styling)
 
 ## How It Works
 
 1. The application connects to MySQL database using Entity Framework Core
 2. Users can perform CRUD operations through the web interface:
    - Create: Add new employees
    - Read: View employee list and details
    - Update: Edit employee information
    - Delete: Remove employees from database
3. All data is stored persistently in the MySQL database