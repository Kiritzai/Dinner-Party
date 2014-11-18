using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinner_Party
{
    class DinnerParty
    {
        private const int CostOfFoodPerPerson = 25;
        private int NumberOfPeople;
        private decimal CostOfBeveragesPerPerson;
        private decimal CostOfDecorations;

        public void SetPartyOptions(int people, bool fancy)
        {
            NumberOfPeople = people;
            CalculateCostOfDecorations(fancy);
        }

        public int GetNumberOfPeople()
        {
            return NumberOfPeople;
        }

        public void SetHealthyOption(bool HealthOption)
        {
            if (HealthOption)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50.00M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30.00M;
            }
        }

        public decimal CalculateCost()
        {
            decimal subtotal = ((NumberOfPeople * CostOfBeveragesPerPerson) + CostOfFoodPerPerson) + CostOfDecorations;
            decimal total = subtotal - (subtotal / 100 * 5);
            return total;
        }
    }
}
