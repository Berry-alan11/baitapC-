using System;

class Employee
{
    private string name;
    private int age;
    // hàm tạo mặc định
    public Employee()
    {
        name = "Mark";
        age = 25;
    }
    // hàm tạo có tham số
    public Employee(string varName, int varAge)
    {
       name = varName;
        age = varAge;
    }
    public void ShowData()
    {
        Console.WriteLine("Name = " + name );
        Console.WriteLine("Age = " + age);
    }
    static void Main()
    {
        Employee objEmpOne = new Employee();
        Employee objEmpTwo = new Employee("Allen",30);
        objEmpOne.ShowData();
        Console.WriteLine();
        objEmpTwo.ShowData();
    }
}
