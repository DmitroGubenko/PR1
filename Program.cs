using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        while (true)
        {
            Console.WriteLine("Виберіть завдання: \n1. Інтервал \n2. Трикутник \n3. Масив \n4. З масиву \n5. Стоп");
            int one = int.Parse(Console.ReadLine());

            if (one == 1)
            {
                ProgramOne myInterval = new ProgramOne();
                myInterval.Interval();
            }

            if (one == 2)
            {
                ProgramTwo myTriangle = new ProgramTwo();
                myTriangle.Triangle();
            }

            if (one == 3)
            {
                ProgramThree myThree = new ProgramThree();
                myThree.Three();
            }

            if (one == 4)
            {
                ProgramFour myFour = new ProgramFour();
                myFour.Four();
            }

            if (one == 5) 
            {
                break;
            }
        }
    }
}

public class ProgramOne
{
    public void Interval()
    {
        Console.WriteLine("Введіть перше ціле число: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть друге ціле число: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть третє ціле число: ");
        int c = int.Parse(Console.ReadLine());

        if (a >= 1 && a <= 22)
            Console.WriteLine($"Число {a}, належить інтервалу [1,22].");
        if (b >= 1 && b <= 22)
            Console.WriteLine($"Число {b}, належить інтервалу [1,22].");
        if (c >= 1 && c <= 22)
            Console.WriteLine($"Число {c}, належить інтервалу [1,22].");
    }
}

class ProgramTwo
{
    public void Triangle()
    {
        try
        {

            // Введення сторін трикутника
            Console.WriteLine("Введіть довжину сторони a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть довжину сторони b:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть довжину сторони c:");
            double c = Convert.ToDouble(Console.ReadLine());

            // Перевірка на дійсність трикутника
            if (IsValidTriangle(a, b, c))
            {
                double perimeter = a + b + c;
                double area = CalculateArea(a, b, c);
                string triangleType = DetermineTriangleType(a, b, c);

                Console.WriteLine($"Периметр трикутника: {perimeter}");
                Console.WriteLine($"Площа трикутника: {area}");
                Console.WriteLine($"Тип трикутника: {triangleType}");
            }
            else
            {
                Console.WriteLine("Сторони не утворюють дійсний трикутник.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Будь ласка, введіть коректні числові значення.");
        }
    }

    static bool IsValidTriangle(double a, double b, double c)
    {
        // Умови існування трикутника
        return (a + b > c) && (a + c > b) && (b + c > a);
    }

    static double CalculateArea(double a, double b, double c)
    {
        // Формула Герона для обчислення площі
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    static string DetermineTriangleType(double a, double b, double c)
    {
        if (a == b && b == c)
        {
            return "Рівносторонній";
        }
        else if (a == b || b == c || a == c)
        {
            return "Рівнобедрений";
        }
        else
        {
            return "Різносторонній";
        }
    }
}

class ProgramThree
{
    public void Three()
    {
        int[] X = new int[12];

        // Заполнение массива случайными числами для примера
        Random rand = new Random();
        for (int i = 0; i < X.Length; i++)
        {
            X[i] = rand.Next(1, 101); // Генерация случайных чисел от 1 до 100
        }

        // Поиск минимального и максимального значений
        int minValue = X[0];
        int maxValue = X[0];
        for (int i = 1; i < X.Length; i++)
        {
            if (X[i] < minValue)
            {
                minValue = X[i];
            }
            if (X[i] > maxValue)
            {
                maxValue = X[i];
            }
        }

        // Вывод массива
        Console.WriteLine("Массив X:");
        foreach (int value in X)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
        
        // Вывод минимального и максимального значений
        Console.WriteLine("Минимальное значение: " + minValue);
        Console.WriteLine("Максимальное значение: " + maxValue);

    }

}

class ProgramFour
{
    public void Four()
    {
        int[] X = new int[12] { -5, 3, 0, -8, 10, 7, -3, 2, -1, 6, -4, 8 };
        int M = 4; // Задане число М

        List<int> Y = new List<int>();

        // Формування нового масиву Y
        foreach (int element in X)
        {
            if (Math.Abs(element) > M)
            {
                Y.Add(element);
            }
        }

        // Виведення на екран числа М та масивів X і Y
        Console.WriteLine("Задане число M: " + M);

        Console.WriteLine("Масив X:");
        foreach (int value in X)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Масив Y:");
        foreach (int value in Y)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }
}