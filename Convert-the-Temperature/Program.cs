public class Solution {
    public double[] ConvertTemperature(double celsius)
    {
        return new double[] { CalculateKelvin(celsius), calculateFahrenheit(celsius)};
    }
    
    double CalculateKelvin(double celcius){
        return (celcius + 273.15);
    }

    double calculateFahrenheit(double celsius){
        return (celsius * 1.80 + 32.00);
    }
}