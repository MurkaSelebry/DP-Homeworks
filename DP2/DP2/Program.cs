//Сторонний класс Kvadrat
public class Kvadrat
{
    public double Ploschad { get; set; }
    public double Perimetr { get; set; }

    public void Pechatat()
    {
        Console.WriteLine($"Kvadrat\nПлощадь = {Ploschad}, Периметр ={Perimetr}");
    }
}
public interface IShape
{
    double Area { get; }
    double Perimeter { get; }
    void Print();
}

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double Area => Width * Height;
    public double Perimeter => 2 * (Width + Height);

    public void Print()
    {
        Console.WriteLine($"Rectangle\nПлощадь = {Area}, Периметр = {Perimeter}");
    }
}

public class Circle : IShape
{
    public double Radius { get; set; }

    public double Area => Math.PI * Radius * Radius;
    public double Perimeter => 2 * Math.PI * Radius;

    public void Print()
    {
        Console.WriteLine($"Circle\nПлощадь = {Area}, Периметр = {Perimeter}");
    }
}

public class KvadratAdapter : IShape
{
    private Kvadrat kvadrat;

    public KvadratAdapter(Kvadrat kvadrat)
    {
        this.kvadrat = kvadrat;
    }

    public double Area => kvadrat.Ploschad;
    public double Perimeter => kvadrat.Perimetr;

    public void Print()
    {
        kvadrat.Pechatat();
    }
}



class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle { Width = 5, Height = 4 };
        Circle circle = new Circle { Radius = 3 };
        Kvadrat kvadrat = new Kvadrat { Ploschad = 16, Perimetr = 16 };
        IShape kvadratAdapter = new KvadratAdapter(kvadrat);
        rectangle.Print();
        circle.Print();
        kvadratAdapter.Print();
    }
}
