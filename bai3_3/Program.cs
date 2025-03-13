// Định nghĩa interface Calculation với phương thức Salary
public interface Calculation
{
    void Salary();
}

// Lớp Accounts triển khai interface Calculation
public class Accounts : Calculation
{
    private int basic = 6000;

    // Triển khai phương thức Salary
    public void Salary()
    {
        Console.WriteLine("Salary(basic * 5) = " + basic * 5);
    }
}

// Lớp HR triển khai interface Calculation
public class HR : Calculation
{
    private int basic = 4000;

    // Triển khai phương thức Salary
    public void Salary()
    {
        Console.WriteLine("Salary (basic * 2) = " + basic * 2);
    }
}

// Lớp InterfaceDemo chứa phương thức Main để chạy chương trình
public class InterfaceDemo
{
    public static void Main()
    {
        // Tạo đối tượng Accounts và gọi phương thức Salary
        Accounts objacc = new Accounts();
        Console.WriteLine("Accounts Department");
        objacc.Salary();
        Console.WriteLine();

        // Tạo đối tượng HR và gọi phương thức Salary
        HR objhr = new HR();
        Console.WriteLine("HR department");
        objhr.Salary();
    }
}
