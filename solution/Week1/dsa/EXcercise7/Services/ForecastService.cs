using Exercise7_FinancialForecasting.Models;

namespace Exercise7_FinancialForecasting.Services
{
    public class ForecastService
    {
        // Recursive Method
        public double CalculateFutureValue(Forecast forecast)
        {
            return Predict(
                forecast.CurrentValue,
                forecast.GrowthRate,
                forecast.Years);
        }

        private double Predict(double value, double growthRate, int years)
        {
            // Base Case
            if (years == 0)
            {
                return value;
            }

            // Recursive Call
            return Predict(
                value * (1 + growthRate),
                growthRate,
                years - 1);
        }
    }
}