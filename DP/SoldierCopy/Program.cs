

public class Soldier : ICloneable
{
    public int Health { get; set; }
    public string Rank { get; set; }
    public double Salary { get; set; }

    public object Clone()
    {
        return new Soldier { Health = Health, Rank = Rank, Salary = Salary };
    }

    public override string ToString()
    {
        return $"Солдат: Здоровье={Health}, Звание={Rank}, Зарплата={Salary} ₽";
    }
}

class Program
{
    static void Main()
    {
        List<Soldier> soldiersGallery = new List<Soldier>
        {
            new (){ Health=100, Rank = "Сержант", Salary = 30000},
        };
        Random random = new Random();
        int countSoldiers = random.Next(5, 10);
        var ranks = new[] { "Сержант", "Лейтентант", "Генерал","Майор" };
        for (int i = 0; i < countSoldiers; i++)
        {
            soldiersGallery.Add(new Soldier() { Health = random.Next(50, 200), Rank = ranks[random.Next(ranks.Length)], Salary = random.Next(30000, 150000) });
        }
        Console.WriteLine("Выберите солдат: (пример: 1 3 5)");
        int j = 1;
        foreach (var soldier in soldiersGallery)
        {
            Console.WriteLine($"{j++}: {soldier}");
        }
        List<int> soldiersChoosen = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var Army = new List<Soldier>();
        foreach (var soldierNumber in soldiersChoosen)
        {
            Army.Add((Soldier)soldiersGallery[soldierNumber-1].Clone());
        }
        Console.WriteLine("Армия солдат:");
        foreach (var soldier in Army)
        {
            Console.WriteLine($"{soldier}");
        }
    }
}
