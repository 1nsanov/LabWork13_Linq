class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        var rnd = new Random();
        var listMain = new List<int>();
        var n = Convert.ToInt32(Console.ReadLine());
        var a = Convert.ToInt32(Console.ReadLine());
        var b = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            listMain.Add(rnd.Next(a, b));
        }
        Print(listMain);
        Console.WriteLine();
        var list1 = listMain.Where(x => x % 3 == 0 && x < 0).OrderByDescending(x => x).ToList();
        Console.WriteLine("список из отрицательных элементов, кратных 3");
        Print(list1);
        var sum = listMain.Where(x => x < 0 && x % 5 == 0).Sum();
        Console.WriteLine("Найти сумму отрицательных элементов, значения которых кратны 5 = " + sum);
        var count = listMain.Where(x => x < 100 && x > 9 || x > -100 && x < -9).Count();
        Console.WriteLine("количество двузначных чисел = " + count);
        var max = listMain.Where(x => x % 2 == 0).Max();
        Console.WriteLine("Найти максимальный четный элемент = " + max);
        var boolPositive = listMain.Any(x => x % 4 == 0 & x > 0);
        Console.WriteLine("есть ли положительные элементы, кратные 4. :" + boolPositive);
        int? fisrtPositive = listMain.FirstOrDefault(x => x % 2 == 0 && x > 0);
        Console.WriteLine("первый положительного четный элемент");
        if (fisrtPositive != null)
            Console.WriteLine(fisrtPositive);
        else
            Console.WriteLine("Положительный четный элемент НЕ найден.");

    }

    static void Print(List<int> list)
    {
        foreach (var item in list)
        {
            Console.Write(item + "\t");
        }
        Console.WriteLine();
    }
}