/*
Создайте два базовых абстрактных класса: Den и Beast (логово и зверь). Из логова постоянно лезут звери.

Из логова медведей постоянно лезут медведи.
Из логова дракона постоянно лезут драконы.
Из логова слизняков постоянно лезут слизняки.

У логова есть метод, порождающий экземпляр класса зверя. Создайте необходимые классы и методы, пропишите их.

В Main проверьте, что порождающий метод работает. Что это за паттерн? - Абстрактная фабрика
*/
public abstract class Beast
{
    public Beast()
    {
        Console.Write("Вылез зверь");
    }
}

public abstract class Den
{
    public abstract Beast CreateBeast(); //Порождающий метод
}

public class MedvedDen : Den
{
    public override Beast CreateBeast()
    {
        return new Medved(); 
    }
}

public class Medved : Beast
{
    public Medved(): base()
    {
        Console.WriteLine(" - медведь!");
    }
}


public class DragonDen : Den
{
    public override Beast CreateBeast()
    {
        return new Dragon(); 
    }
}

public class Dragon : Beast
{
    public Dragon(): base()
    {
        Console.WriteLine(" - дракон!");
    }
}

public class SliznyakDen : Den
{
    public override Beast CreateBeast()
    {
        return new Sliznyak(); 
    }
}

public class Sliznyak : Beast
{
    public Sliznyak(): base()
    {
        Console.WriteLine(" - слизняк");
    }
}

class Program
{
    static void Main()
    {
        MedvedDen medvedDen = new MedvedDen();
        Beast medved = medvedDen.CreateBeast();

        DragonDen dragonDen = new DragonDen();
        Beast dragon = dragonDen.CreateBeast();

        SliznyakDen sliznyakDen = new SliznyakDen();
        Beast sliznyak = sliznyakDen.CreateBeast();
    }
}
