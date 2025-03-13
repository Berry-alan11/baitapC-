class Vehicle
{
    // Khởi tạo các trường không cho phép null với giá trị mặc định (string.Empty)
    public string strType { get; set; } = string.Empty;
    public string strColor { get; set; } = string.Empty;
    public double dblSpeed { get; set; }
    public string strBrand { get; set; } = string.Empty;

    // Phương thức Run hiển thị thông báo rằng phương tiện đang chạy
    public void Run()
    {
        Console.WriteLine(strType + " : I am running");
    }

    // Phương thức Display hiển thị thông tin chi tiết của phương tiện
    public void Display()
    {
        Console.WriteLine("Type : " + strType);
        Console.WriteLine("Color : " + strColor);
        Console.WriteLine("Speed : " + dblSpeed);
        Console.WriteLine("Brand : " + strBrand);
    }
}


class Car : Vehicle
{
    public Car(Vehicle objVehicle)
    {
        strType = objVehicle.strType;
        strColor = objVehicle.strColor;
        dblSpeed = objVehicle.dblSpeed;
        strBrand = objVehicle.strBrand;
    }
}

class Inherit
{
    static void Main()
    {
        Vehicle objVehicle = new Vehicle();
        objVehicle.strType = "Car";
        objVehicle.strColor = "Red";
        objVehicle.dblSpeed = 100.2;
        objVehicle.strBrand = "BMW";
        Car objCar = new Car(objVehicle);
        objCar.Run();
        objCar.Display();
    }
}