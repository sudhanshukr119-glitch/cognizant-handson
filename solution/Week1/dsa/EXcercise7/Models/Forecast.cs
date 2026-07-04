namespace Exercise7_FinancialForecasting.Models
{
    public class Forecast
    {
        public double CurrentValue { get; set; }

        public double GrowthRate { get; set; }

        public int Years { get; set; }

        public Forecast(double currentValue, double growthRate, int years)
        {
            CurrentValue = currentValue;
            GrowthRate = growthRate;
            Years = years;
        }

        public override string ToString()
        {
            return $"Current Value: ₹{CurrentValue}, Growth Rate: {GrowthRate * 100}%, Years: {Years}";
        }
    }
}