namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee[] employees =
            {
                new Employee(1,"Ahmed",Security.DBA,8000,new HireDate(10,12,1999),Gender.Male),
                new Employee(2,"Sara",Security.Guest,2000,new HireDate(22,8,1996),Gender.Female),
                new Employee(3,"Aly",Security.secretary,6000,new HireDate(30,7,1998),Gender.Male),
            };
            Console.WriteLine(employees[0].ToString());
            Console.WriteLine(employees[1].ToString());
            Console.WriteLine(employees[2].ToString());

            //Employee[] employees = new Employee[3];

            //for (int i = 0; i < employees.Length; i++)
            //{
            //    int id;
            //    while (true)
            //    {
            //        Console.Write("Enter ID: ");
            //        if (int.TryParse(Console.ReadLine(), out id)) break;
            //        Console.WriteLine("Invalid input. Please enter a valid integer for ID.");
            //    }

            //    Console.Write("Enter Name: ");
            //    string name = Console.ReadLine();

            //    Security position;
            //    while (true)
            //    {
            //        Console.Write("Enter Position (0 for DBA, 1 for Guest, 2 for Secretary): ");
            //        if (int.TryParse(Console.ReadLine(), out int positionInput) &&
            //            Enum.IsDefined(typeof(Security), positionInput))
            //        {
            //            position = (Security)positionInput;
            //            break;
            //        }
            //        Console.WriteLine("Invalid input. Please enter 0, 1, or 2 for Position.");
            //    }

            //    decimal salary;
            //    while (true)
            //    {
            //        Console.Write("Enter Salary: ");
            //        if (decimal.TryParse(Console.ReadLine(), out salary)) break;
            //        Console.WriteLine("Invalid input. Please enter a valid decimal number for Salary.");
            //    }

            //    int day, month, year;
            //    while (true)
            //    {
            //        Console.Write("Enter Hire Date (Day): ");
            //        if (int.TryParse(Console.ReadLine(), out day) && day >= 1 && day <= 31) break;
            //        Console.WriteLine("Invalid input. Please enter a valid day (1-31).");
            //    }
            //    while (true)
            //    {
            //        Console.Write("Enter Hire Date (Month): ");
            //        if (int.TryParse(Console.ReadLine(), out month) && month >= 1 && month <= 12) break;
            //        Console.WriteLine("Invalid input. Please enter a valid month (1-12).");
            //    }
            //    while (true)
            //    {
            //        Console.Write("Enter Hire Date (Year): ");
            //        if (int.TryParse(Console.ReadLine(), out year) && year > 1900 && year <= DateTime.Now.Year) break;
            //        Console.WriteLine("Invalid input. Please enter a valid year.");
            //    }

            //    HireDate hireDate = new HireDate(day, month, year);

            //    Gender gender;
            //    while (true)
            //    {
            //        Console.Write("Enter Gender (0 for Male, 1 for Female): ");
            //        if (int.TryParse(Console.ReadLine(), out int genderInput) &&
            //            Enum.IsDefined(typeof(Gender), genderInput))
            //        {
            //            gender = (Gender)genderInput;
            //            break;
            //        }
            //        Console.WriteLine("Invalid input. Please enter 0 or 1 for Gender.");
            //    }

            //    employees[i] = new Employee(id, name, position, salary, hireDate, gender);
            //}

            //Console.WriteLine("\nEmployee Details:");
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee.ToString());
            //}


            Array.Sort(employees);
            Console.WriteLine("\n Sorted Employee Details:");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}