using System;

// Định nghĩa lớp AppWindow
public class AppWindow
{
    // Các thành viên được bảo vệ
    protected int top;
    protected int left;

    // Constructor nhận hai số nguyên để xác định vị trí trên console
    public AppWindow(int top, int left)
    {
        this.top = top;
        this.left = left;
    }

    // Phương thức mô phỏng việc vẽ cửa sổ
    public virtual void CreateWindow()
    {
        Console.WriteLine("Window: drawing Window at {0}, {1}", top, left);
    }
}

// Lớp ListBox kế thừa từ AppWindow
public class ListBox : AppWindow
{
    private string listBoxContents;

    // Constructor thêm một tham số và gọi constructor của lớp cơ sở
    public ListBox(int top, int left, string contents) : base(top, left)
    {
        listBoxContents = contents;
    }

    // Ghi đè phương thức CreateWindow
    public override void CreateWindow()
    {
        base.CreateWindow(); // gọi phương thức của lớp cơ sở
        Console.WriteLine("Writing string to the listbox: {0}", listBoxContents);
    }
}

// Lớp Button kế thừa từ AppWindow
public class Button : AppWindow
{
    public Button(int top, int left) : base(top, left)
    {
    }

    // Ghi đè phương thức CreateWindow
    public override void CreateWindow()
    {
        Console.WriteLine("Drawing a button at {0}, {1}\n", top, left);
    }
}

// Lớp Tester chứa phương thức Main để chạy chương trình
public class Tester
{
    public static void Main()
    {
        // Tạo đối tượng AppWindow và gọi phương thức CreateWindow
        AppWindow win = new AppWindow(-110, -0);
        win.CreateWindow();

        // Tạo đối tượng ListBox và gọi phương thức CreateWindow
        win = new ListBox(3, 4, "This is a list box");
        win.CreateWindow();

        // Tạo đối tượng Button và gọi phương thức CreateWindow
        win = new Button(5, 6);
        win.CreateWindow();
    }
}
