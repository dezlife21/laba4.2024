using System;

class TabletOwner
{
    public string Name;
    public string PhoneNumber;
    public string Price;
    public string Email;
    public DateTime SubscriptionStartDate;
    public bool IsActive;
    public int Age;
    public double GetYearsWithTablet()
    {
        return (DateTime.Now - SubscriptionStartDate).TotalDays / 365;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введiть iм'я власника планшета: ");
        string name = Console.ReadLine();
        Console.Write("Введiть номер телефону: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Введiть цiну планшена: ");
        string Price = Console.ReadLine();
        Console.Write("Введiть електронну пошту: ");
        string email = Console.ReadLine();
        Console.Write("Введiть дату придбання планшета (у форматi yyyy-mm-dd): ");
        DateTime subscriptionStartDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Планшет активний? (y-так, n-ні): ");
        bool isActive = Console.ReadKey().Key == ConsoleKey.Y;
        Console.WriteLine();
        Console.Write("Введiть вiк власника планшета: ");
        int age = int.Parse(Console.ReadLine());

        TabletOwner tabletOwner = new TabletOwner();
        tabletOwner.Name = name;
        tabletOwner.PhoneNumber = phoneNumber;
        tabletOwner.Price = Price;
        tabletOwner.Email = email;
        tabletOwner.SubscriptionStartDate = subscriptionStartDate;
        tabletOwner.IsActive = isActive;
        tabletOwner.Age = age;

        double yearsWithTablet = tabletOwner.GetYearsWithTablet();

        Console.WriteLine();
        Console.WriteLine("Інформацiя про власника планшета:");
        Console.WriteLine($"iм'я: {tabletOwner.Name}");
        Console.WriteLine($"Номер телефону: {tabletOwner.PhoneNumber}");
        Console.WriteLine($"Адреса: {tabletOwner.Price}");
        Console.WriteLine($"Електронна пошта: {tabletOwner.Email}");
        Console.WriteLine($"Дата придбання планшета: {tabletOwner.SubscriptionStartDate.ToShortDateString()}");
        Console.WriteLine($"Статус: {(tabletOwner.IsActive ? "Активний" : "Неактивний")}");
        Console.WriteLine($"Стаж використання планшета: {yearsWithTablet:F1} рокiв");
        Console.WriteLine($"Вiк власника планшета: {tabletOwner.Age} рокiв");

        Console.ReadKey();
    }
}