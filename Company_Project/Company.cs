namespace Company_Project;

public class Company
{
    string _name;
    public string Name
    {
        get
        {
            return this.Name;
        }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                value = value.Trim();
                this._name = value.ToUpper()[0] + value.Substring(1);
            }
        }
    }
    public Employee[] Employees; //new Employee[0]

    public Company(string name)
    {
        Name = name;
        Employees = new Employee[0];
    }

    public void AddUser(Employee employee)
    {
        Array.Resize(ref Employees, Employees.Length + 1);
        Employees[Employees.Length - 1] = employee;
    }
    public Employee GetUser(string username)
    {
        foreach (Employee emp in Employees)
        {
            if (emp.Username == username) 
                {
                    Console.WriteLine(emp.Name);
                    Console.WriteLine(emp.Surname);
                    Console.WriteLine(emp.Username);
                    Console.WriteLine(emp.Age);
                    return emp; 
                }
        }
        Console.WriteLine("Employee with given username not found");
        return null;
    }

    public void GetAllUser()
    {
        foreach (Employee item in Employees)
        {
            Console.WriteLine($"{item.Username}:");
            Console.WriteLine($"\t{item.Name}");
            Console.WriteLine($"\t{item.Surname}");
            Console.WriteLine($"\t{item.Age}");
        }
    }
    public void UpdateUser(string username)
    {
        char updateOption = '0';
            foreach (Employee emp in Employees)
            {
                if (emp.Username == username)
                {
                do
                {
                    Console.WriteLine("a. Update Name \nb. Update Surname \nc. Update Age");
                    updateOption = Convert.ToChar(Console.ReadLine());
                    if (updateOption == 'a')
                    {
                        Console.Write("Name: ");
                        emp.Name = Console.ReadLine();
                    }
                    if (updateOption == 'b')
                    {
                        Console.Write("Surname: ");
                        emp.Surname = Console.ReadLine();
                    }
                    if (updateOption == 'c')
                    {
                        Console.Write("Age: ");
                        emp.Age = Convert.ToByte(Console.ReadLine());
                    }
                }
                while (updateOption != 'q');
            }
        }
    }

    //public Employee RemoveUser(string username)
    //{
    //    foreach (Employee emp in Employees)
    //    {
    //        if (emp.Username == username)
    //        {
    //            return Employees.
    //        }
    //    }

    //}
}
