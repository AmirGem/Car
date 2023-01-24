namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            while (true)
            {
                string op = Car.GetOp();

                switch (op)
                {
                    case "+":
                        Console.Clear();
                        Console.WriteLine(car.SpeedUp());
                        break;

                    case "-":
                        Console.Clear();
                        Console.WriteLine(car.SpeedDown());
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine(car.TurnOff());
                        break;
                }
            }
        }
    }
}