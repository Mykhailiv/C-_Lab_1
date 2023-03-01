using System;

class Room
{
    private double area; // метраж кімнати
    private double height; // висота стелі кімнати
    private int windows; // кількість вікон в кімнаті

    // конструктор з перевіркою допустимості значень полів
    public Room(double area, double height, int windows)
    {
        if (area <= 0)
            throw new ArgumentException("The square footage of the room must be greater than zero\r\n.");
        if (height <= 0)
            throw new ArgumentException("The ceiling height of the room should be greater than zero.");
        if (windows < 0)
            throw new ArgumentException("The number of windows in the room should not be less than zero.");

        this.area = area;
        this.height = height;
        this.windows = windows;
    }

    // метод для обчислення площі кімнати
    public double CalculateArea()
    {
        return area;
    }

    // метод для обчислення об’єму кімнати
    public double CalculateVolume()
    {
        return area * height;
    }

    // властивість для отримання стану об’єкта
    public string State
    {
        get
        {
            return $"Meterage: {area} m²," +
                $" Ceiling height\r\n: {height}m,"+
                $" Number of windows: {windows}";
        }
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Room myRoom = new Room(20.5, 2.75, 3);
            Console.WriteLine($"Area of the room: {myRoom.CalculateArea()} m²");
            Console.WriteLine($"Volume of the room: {myRoom.CalculateVolume()} m³");
            Console.WriteLine($"Room condition\r\n: {myRoom.State}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}