using Company_Project;

Company company1 = new Company("Socar kbr");
Employee e = new Employee("vuqar", "semedov", 20);
company1.AddUser(e);
char option;
Console.WriteLine("1. Create a company");
Console.WriteLine("2. Create an employee");
Console.WriteLine("3. Delete employee");
Console.WriteLine("4. Update employee");
Console.WriteLine("5. See all employees");
Console.WriteLine("6. See employee");

do
{
    //e = new Employee("vugar", "sariyev", 20);
    Console.WriteLine("1, 2, 3, 4, 5, 6 or q");
    option = Convert.ToChar(Console.ReadLine());

    switch (option)
    {
        case '1':
            company1 = new Company("Socar kbr");
            Console.Write("Company name: ");
            company1.Name = Console.ReadLine();
            break;
        case '2':
            Employee a = new Employee("vuqar", "semedov", 20);
            company1.AddUser(a);
            Console.Write("Employee name: ");
            a.Name = Console.ReadLine();
            Console.Write("Employee surname: ");
            a.Surname = Console.ReadLine();
            Console.Write("Employee age: ");
            a.Age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Employee is created");
            break;
        case '3':
            
            break;
        case '4':
            Console.Write("Username: ");
            company1.UpdateUser(Console.ReadLine());
            break;
        case '5':
            company1.GetAllUser();
            break;
        case '6':
            Console.Write("Username: ");
            company1.GetUser(Console.ReadLine());
            break;
        default:
            Console.WriteLine("Choose from options");
            break;
    }
} while (option != 'q');
