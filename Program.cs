using System;

public class Rectangle
{
    // Các thuộc tính
    double width, height;

    // Phương thức khởi tạo không tham số
    public Rectangle()
    {
    }

    // Phương thức khởi tạo có tham số
    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    // Phương thức tính diện tích
    public double GetArea()
    {
        return this.width * this.height;
    }

    // Phương thức tính chu vi
    public double GetPerimeter()
    {
        return (this.width + this.height) * 2;
    }

    // Phương thức hiển thị thông tin hình chữ nhật
    public string Display()
    {
        return "Rectangle{" + "width=" + width + ", height=" + height + "}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Nhập chiều rộng và chiều cao từ người dùng
        Console.WriteLine("Enter the width:");
        double width = Double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height:");
        double height = Double.Parse(Console.ReadLine());

        // Tạo đối tượng hình chữ nhật với các giá trị nhập vào
        Rectangle rectangle = new Rectangle(width, height);

        // Hiển thị thông tin, chu vi và diện tích của hình chữ nhật
        Console.WriteLine("Your Rectangle \n" + rectangle.Display());
        Console.WriteLine("Perimeter of the Rectangle: " + rectangle.GetPerimeter());
        Console.WriteLine("Area of the Rectangle: " + rectangle.GetArea());
    }
}
