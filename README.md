# Restaurant Management System

A Windows Forms application for managing a restaurant's operations, including customer management, order processing, employee management, and delivery vehicle tracking.

## Features

- **User Authentication**
  - Login system for employees
  - Registration for new customers
  - Password recovery functionality

- **Order Management**
  - Create and track orders
  - Manage order details and quantities
  - Track delivery addresses and costs

- **Customer Management**
  - Store customer information
  - Track customer orders
  - Manage customer contact details

- **Employee Management**
  - Employee profiles and information
  - Salary tracking
  - Employee-vehicle assignments

- **Product Management**
  - Product catalog
  - Price management
  - Product inventory tracking

- **Delivery System**
  - Vehicle tracking
  - Delivery status monitoring
  - Employee-vehicle assignments

## Database Structure

The system uses SQL Server with the following main tables:

- `customers`: Stores customer information
- `employees`: Manages employee data
- `vehicles`: Tracks delivery vehicles
- `orders`: Records order information
- `products`: Maintains product catalog
- `orders_content`: Links orders with products

## Technical Details

- Built using C# Windows Forms
- SQL Server database backend
- ADO.NET for database operations
- LocalDB for development environment

## Setup Instructions

1. Ensure you have SQL Server LocalDB installed
2. Run the `DBproj_query.sql` script to create and populate the database
3. Open the solution in Visual Studio
4. Update the connection string in the application if needed
5. Build and run the application

## Database Connection

The application uses the following connection string:
```
Data Source=(localdb)\local;Initial Catalog=rest_DBS;Integrated Security=True
```

## Project Structure

- `Login.cs`: Handles user authentication
- `register.cs`: Manages new user registration
- `order.cs`: Handles order processing
- `verification.cs`: Manages user verification
- `tabels.cs`: Contains database table definitions

## Dependencies

- .NET Framework
- SQL Server LocalDB
- Windows Forms

## Security Features

- Password protection
- User authentication
- Secure database connections
- Input validation

## Contributing

1. Fork the repository
2. Create a feature branch
3. Commit your changes
4. Push to the branch
5. Create a Pull Request

## License

This project is proprietary and confidential.

## Support

For support, please contact the development team. 
