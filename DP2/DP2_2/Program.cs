
public interface IShape
{
    void Draw();
}

public interface IAttributeImplementor
{
    void Apply();
}

public class ColorAttribute : IAttributeImplementor
{
    private string color;

    public ColorAttribute(string color)
    {
        this.color = color;
    }

    public void Apply()
    {
        Console.WriteLine($"Applying color: {color}");
    }
}

public class SizeAttribute : IAttributeImplementor
{
    private string size;

    public SizeAttribute(string size)
    {
        this.size = size;
    }

    public void Apply()
    {
        Console.WriteLine($"Applying size: {size}");
    }
}

public class ShapeAttribute : IAttributeImplementor
{
    private string shape;

    public ShapeAttribute(string shape)
    {
        this.shape = shape;
    }

    public void Apply()
    {
        Console.WriteLine($"Applying shape: {shape}");
    }
}

public class Shape : IShape
{
    private IAttributeImplementor colorAttribute;
    private IAttributeImplementor sizeAttribute;
    private IAttributeImplementor shapeAttribute;

    public Shape(IAttributeImplementor colorAttribute, IAttributeImplementor sizeAttribute, IAttributeImplementor shapeAttribute)
    {
        this.colorAttribute = colorAttribute;
        this.sizeAttribute = sizeAttribute;
        this.shapeAttribute = shapeAttribute;
    }

    public void Draw()
    {
        Console.Write("Drawing ");
        colorAttribute.Apply();
        sizeAttribute.Apply();
        shapeAttribute.Apply();
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание фигур с разными атрибутами
        IAttributeImplementor redColor = new ColorAttribute("Red");
        IAttributeImplementor blueSize = new SizeAttribute("Big");
        IAttributeImplementor squareShape = new ShapeAttribute("Square");

        IShape redBigSquare = new Shape(redColor, blueSize, squareShape);


        IShape blueSmallCircle = new Shape(new ColorAttribute("Blue"), new SizeAttribute("Small"), new ShapeAttribute("Circle"));

        // Отрисовка фигур
        redBigSquare.Draw();
        blueSmallCircle.Draw();

        // Добавление новых атрибутов
        IAttributeImplementor greenColor = new ColorAttribute("Green");
        IAttributeImplementor mediumSize = new SizeAttribute("Medium");
        IAttributeImplementor anotherCircleShape = new ShapeAttribute("Circle");

        IShape greenMediumCircle = new Shape(greenColor, mediumSize, anotherCircleShape);
        greenMediumCircle.Draw();
    }
}
