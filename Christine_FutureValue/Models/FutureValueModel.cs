using System.Runtime.Serialization.Formatters;

namespace Christine_FutureValue.Models
{
    public class FutureValueModel
    {
        public decimal MonthlyInvestment { get; set; }
        public decimal  YearlyInterestRate { get; set; }
        public int Years { get; set; }

        public decimal CalculateFutureValue()
        {
            int months = Years * 12;
            decimal monthlyInetredtRate = YearlyInterestRate / 12 / 100;

            decimal futureValue = 0;

            for (int i = 0; i < months; i++)
                futureValue = (futureValue + MonthlyInvestment);

     

        }
}
}
