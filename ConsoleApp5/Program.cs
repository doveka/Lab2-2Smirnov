class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine("Введите размеры прямоугольника a, b:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите размеры прямоугольника c, d:");
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());

        // Проверяем, можно ли разместить прямоугольник со сторонами a, b в прямоугольнике со сторонами c, d
        if ((a <= c && b <= d) || (a <= d && b <= c))
        {
            Console.WriteLine(
                "Прямоугольник со сторонами a, b можно поместить внутрь прямоугольника со сторонами c, d");
        }
        else if ((c <= a && d <= b) || (c <= b && d <= a))
        {
            Console.WriteLine(
                "Прямоугольник со сторонами c, d можно поместить внутрь прямоугольника со сторонами a, b");
        }
        else
        {
            Console.WriteLine("Прямоугольники нельзя разместить друг в друге");
        }
    }
}
