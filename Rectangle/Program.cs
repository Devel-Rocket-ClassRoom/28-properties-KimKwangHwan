using System;

Rectangle rect1 = new Rectangle
{
    Width = 10, Height = 5
};
Console.WriteLine("=== 사각형 1 ===");
Console.WriteLine($"가로: {rect1.Width}, 세로: {rect1.Height}");
Console.WriteLine($"넓이: {rect1.Area}");
Console.WriteLine($"둘레: {rect1.Perimeter}");
Console.WriteLine($"정사각형: {rect1.IsSquare}");

Rectangle rect2 = new Rectangle
{
    Width = 7,
    Height = 7
};
Console.WriteLine("=== 사각형 1 ===");
Console.WriteLine($"가로: {rect2.Width}, 세로: {rect2.Height}");
Console.WriteLine($"넓이: {rect2.Area}");
Console.WriteLine($"둘레: {rect2.Perimeter}");
Console.WriteLine($"정사각형: {rect2.IsSquare}");

Rectangle rect3 = new Rectangle
{
    Width = 1,
    Height = 1
};
Console.WriteLine("=== 사각형 1 ===");
Console.WriteLine($"가로: {rect3.Width}, 세로: {rect3.Height}");
Console.WriteLine($"넓이: {rect3.Area}");
Console.WriteLine($"둘레: {rect3.Perimeter}");
Console.WriteLine($"정사각형: {rect3.IsSquare}");

class Rectangle
{
    public int Width { get; set; } = 1;
    public int Height { get; set; } = 1;
    public int Area
    {
        get { return Width * Height; }
    }
    public int Perimeter
    {
        get { return 2 * (Width + Height); }
    }
    public bool IsSquare
    {
        get { return (Width == Height); }
    }
}