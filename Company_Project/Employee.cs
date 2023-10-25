using System.Xml.Linq;

namespace Company_Project;

public class Employee
{
    private string _name;
    private string _surName;
    private byte _age;
    private string _username;

    public Employee(string name, string surname, byte age)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Username = Name.ToUpper() + "_" + Surname.ToUpper();
    }

    public string Name
    {
        get => _name;
        set
        {
            _name = FormatName(value);
        }
    }

    public string Surname
    {
        get => _surName;
        set 
        {
            _surName = FormatName(value);
            _username = Name.ToUpper() + "_" + Surname.ToUpper();
        }
    }
    public string Username
    { 
        get => _username;
        set
        {
            _username = Name.ToUpper() + "_" + Surname.ToUpper();     
        }
    }

    public byte Age
    {
        get => _age;
        set
        {
            while (true)
            {
                if (value > 0)
                {
                    _age = value;
                    break;
                }
                else
                {
                    Console.WriteLine("duzgun eded daxil edin!");
                    Console.Write("Age: ");
                    value = Convert.ToByte(Console.ReadLine());
                }
            }

        }
    }


    public string FormatName(string name)
    {
        char[] charArray = name.ToCharArray();
        charArray[0] = Char.ToUpper(charArray[0]);
        return new string(charArray);
    }
}
