namespace StaticExercise;
//The class should have at least 2 methods, one called FahrenheitToCelsius that will require a double as a parameter
//and return a double, the other CelsiusToFahrenheit which will also require a double as a parameter and return a double.
// Fill out these methods and call them in your Program.cs file. Make sure they’re accurate!
 
public static class TempConverter
{
    public static double FahrenheitToCelsius(double degreesFahrenheit)
    {
       //c=(f-32)*5/9
       var celsius = (degreesFahrenheit - 32) * 5.0 / 9.0;
       return celsius;
    }

    public static double CelsiusToFahrenheit(double degreesCelsius)
    {
      //f=(9/5)c + 32
      var fahrenheit = 9.0 / 5.0 * degreesCelsius + 32;
      return fahrenheit;
    }
}