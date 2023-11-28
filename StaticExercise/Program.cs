namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(60);
            var fr = TempConverter.CelsiusToFahrenheit(60);

            Console.WriteLine("Here are the following conversions.");
            Console.WriteLine($"Fahrenheit to Celsius: {celsius}");
            Console.WriteLine($"Celsius to Fahrenheit: {fr}");
        }
    }
}
