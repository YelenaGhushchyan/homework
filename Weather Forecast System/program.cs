public class WeatherReport
{
    public float temperature;
    public int humidity;
    public string weatherCondition;

    public WeatherReport(float temperature, int humidity, string weatherCondition)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.weatherCondition = weatherCondition;
    }

    public void WeatherReportInfo()
    {
        Console.WriteLine("temperature: " + temperature);
        Console.WriteLine("humidity: " + humidity);
        Console.WriteLine("weatherCondition: " + weatherCondition);
    }
}

class Program
{
    static void Main(string[] args)
    {
        WeatherReport[] reports = new WeatherReport[3];
        reports[0] = new WeatherReport(22.5f, 60, "Sunny");
        reports[1] = new WeatherReport(15.3f, 80, "Rainy");
        reports[2] = new WeatherReport(30, 50, "Cloudy");
        foreach (WeatherReport report in reports)
        {
            report.WeatherReportInfo();
        }
        
    }
}
