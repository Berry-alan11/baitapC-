using System;

// Lớp trừu tượng Color với phương thức trừu tượng Fill
abstract class Color
{
    // Phương thức trừu tượng phải được các lớp dẫn xuất triển khai
    public abstract void Fill(string strColor);
}

// Lớp Blue kế thừa từ Color và triển khai phương thức Fill
class Blue : Color
{
    // Triển khai phương thức Fill cho Blue
    public override void Fill(string strColor)
    {
        // In ra thông báo chỉ ra màu sắc được sử dụng để tô
        Console.WriteLine("Fill me up with " + strColor);
    }
}

// Lớp Green kế thừa từ Color và triển khai phương thức Fill
class Green : Color
{
    // Triển khai phương thức Fill cho Green
    public override void Fill(string strColor)
    {
        // In ra thông báo chỉ ra màu sắc được sử dụng để tô
        Console.WriteLine("Fill me up with " + strColor);
    }
}

// Lớp để trình diễn việc sử dụng các lớp Blue và Green
class ColorDemo
{
    // Phương thức Main - điểm bắt đầu của chương trình
    static void Main()
    {
        // Tạo một đối tượng Blue và gọi phương thức Fill
        Blue b = new Blue();
        b.Fill("Blue"); // Kết quả: Fill me up with Blue

        // Tạo một đối tượng Green và gọi phương thức Fill
        Green g = new Green();
        g.Fill("Green"); // Kết quả: Fill me up with Green
    }
}
