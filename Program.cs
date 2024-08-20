internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Как Вас зовут: ");
        var name = Console.ReadLine();
        Console.Write("Укажите Ваш возраст: ");
        var age = checked((byte)int.Parse(Console.ReadLine()));
        Console.Write("Укажите Вашу дату рождения в формате дд.мм.гггг: ");
        var date = Console.ReadLine();

//        Console.Write("What is your favorite day of week? ");
//        day_of_week dt = (day_of_week)int.Parse(Console.ReadLine());
//        Console.Write("Your favorite day of week is {0}", dt);
        
        Console.WriteLine($"Вас зовут {name} и Вам {age} лет");
        Console.WriteLine($"Вы родились {date}");
        Console.ReadKey();
    }
}

enum day_of_week : byte
{ понедельник = 1, вторник, среда, четверг, пятница, суббота, воскресенье }
