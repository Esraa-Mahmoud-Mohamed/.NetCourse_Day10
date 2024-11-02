# .NET Course - Day 10

## Project Overview
This repository contains tasks and solutions for **Day 9** of the .NET course. The goal of this course is to build foundational skills in C# and .NET, focusing on object-oriented programming, project structuring, and utilizing various .NET libraries and frameworks.

## Project Structure
The repository includes three tasks (`Task1.sln`and `Task2.sln`). Each solution focuses on specific programming concepts and implementations covered during Day 9 of the course:

### Task 1: Point3D Class
- **Description**: This task involves creating a `Point3D` class to represent a point in 3D space with integer coordinates `x`, `y`, and `z`. The class includes:
- **Properties**: Getter and setter methods for each coordinate (`X`, `Y`, `Z`).
- **Constructors**: A default constructor initializes coordinates to `(0, 0, 0)`, and a parameterized constructor allows setting specific values.
- **ToString Method**: Overrides the default `ToString` to display the point as `Point Coordinates: (x, y, z)`.
- **IComparable Interface**: Allows comparison of points based on the x coordinate, and the y coordinate if the x coordinates are equal.
- **ICloneable Interface**: Provides deep copy functionality to clone Point3D objects.
- **Main Program**: Demonstrates sorting, cloning, and displaying points.

**Code Example**:
```csharp
Point3D p1 = new Point3D(10, 20, 30);
Console.WriteLine(p1.ToString());  // Output: Point Coordinates: (10,20,30)

Point3D p2 = (Point3D)p1.Clone();
Console.WriteLine(p2.ToString());  // Output: Point Coordinates: (10,20,30)

Point3D[] points = {
    new Point3D(10, 200, 30),
    new Point3D(10, 70, 100),
    new Point3D(45, 10, 30),
    new Point3D(9, 60, 30),
};

Array.Sort(points);
foreach (var point in points) {
    Console.WriteLine(point.ToString());
}
```

### Task 2: Employee Management
- **Description**: This task involves creating an Employee management system that handles employee data, including their ID, name, position, salary, hire date, and gender. The implementation includes:

- **Employee Class**: Represents an employee with properties for ID, name, security position, salary, hire date, and gender.
- **Enum Types**: Defines Security for job positions and Gender for employee gender representation.
- **HireDate Class**: Represents the hire date of an employee with day, month, and year attributes.
- **Sorting Employees**: The program can sort employees based on their properties.
- **Interactive Employee Input (Commented-Out Code)**
Description: The program includes commented-out code for interactive employee data entry, allowing users to input employee details such as ID, name, position, salary, hire date, and gender through the console. The input validation ensures that the entered values are appropriate.
**Code Example**:
```csharp
Employee[] employees = {
    new Employee(1, "Ahmed", Security.DBA, 8000, new HireDate(10, 12, 1999), Gender.Male),
    new Employee(2, "Sara", Security.Guest, 2000, new HireDate(22, 8, 1996), Gender.Female),
    new Employee(3, "Aly", Security.Secretary, 6000, new HireDate(30, 7, 1998), Gender.Male),
};

Array.Sort(employees);
foreach (var employee in employees) {
    Console.WriteLine(employee.ToString());
}

for (int i = 0; i < employees.Length; i++) {
    // Code for user input with validation...
    employees[i] = new Employee(id, name, position, salary, hireDate, gender);
}

```
