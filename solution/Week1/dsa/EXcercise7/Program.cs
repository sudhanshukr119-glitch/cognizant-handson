using System;
using Exercise7_FinancialForecasting.Models;
using Exercise7_FinancialForecasting.Services;

namespace Exercise7_FinancialForecasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Forecast forecast = new Forecast(
                10000,   // Current Value
                0.10,    // 10% Growth Rate
                5        // Years
            );

            ForecastService service = new ForecastService();

            Console.WriteLine("========== FINANCIAL FORECAST ==========");

            Console.WriteLine(forecast);

            double futureValue = service.CalculateFutureValue(forecast);

            Console.WriteLine($"\nPredicted Future Value: ₹{futureValue:F2}");
        }
    }
}