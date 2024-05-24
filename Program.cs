namespace ConsoleApplication2
{
    class Without_metod
    {
        static void Main()
        {
            Console.Write("Coordinate X1 - ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Coordinate Y1 - ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nCoordinate X2 - ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Coordinate Y2 - ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Distance - {O:F}", result);

            Console.ReadKey();
        }
    }
}
