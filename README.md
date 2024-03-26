# Vehicle Rental Management System - VRMS

Vehicle Rental Management System is a console-based application designed to manage a fleet of vehicles available for rental. Users can add vehicles to the fleet, remove vehicles, and rent them out to customers.

## Objective

The system's objective is to efficiently manage the rental process of vehicles while ensuring proper organization and tracking of the rental agency's inventory.

## Features

- **Vehicle Classes**: Three types of vehicles are supported: Cars, Trucks, and Motorcycles, each with specific properties and functionalities.
- **Rental Agency**: Manages the fleet of vehicles, tracks total revenue earned, and provides methods to add, remove, and rent vehicles.
- **Encapsulation**: Class properties and methods are appropriately encapsulated to maintain data integrity and hide internal implementation details.
- **Abstraction**: Abstraction is utilized through method overriding to display specific details unique to each vehicle type while maintaining a consistent method signature.

## How to Use

1. **Clone the Repository:**
    ```bash
    git clone https://github.com/EdisCode/PROG8051-Assign3.git
    ```

2. **Navigate to the Project Directory:**
    ```bash
    cd vehicle-rental-management
    ```

3. **Compile and Run the Application:**
    ```bash
    dotnet run
    ```

4. **Follow On-screen Instructions:**
    - Use the application to manage the rental agency's fleet by adding, removing, and renting vehicles.
    - Enjoy exploring the functionalities of the Vehicle Rental Management System.

## Implementation Details

The system is implemented in C# and consists of the following classes:

- `Vehicle`: Represents a generic vehicle available for rental.
- `Car`: Inherits from the Vehicle class and represents a car with additional properties.
- `Truck`: Inherits from the Vehicle class and represents a truck with additional properties.
- `Motorcycle`: Inherits from the Vehicle class and represents a motorcycle with additional properties.
- `RentalAgency`: Manages the rental agency's fleet of vehicles, tracks total revenue, and provides methods for fleet management.

## Additional Notes

Feel free to explore and modify the codebase to adapt the Vehicle Rental Management System to your specific requirements or preferences.

Happy renting! 🚗💨
