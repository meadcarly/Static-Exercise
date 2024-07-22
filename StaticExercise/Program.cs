namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The temperature is {TempConverter.FahrenheitToCelsius(40)} degrees Celsius");
            Console.WriteLine();
            Console.WriteLine($"The temperature is {TempConverter.CelsiusToFahrenheit(11)} degrees Fahrenheit");
        }
    }
}
