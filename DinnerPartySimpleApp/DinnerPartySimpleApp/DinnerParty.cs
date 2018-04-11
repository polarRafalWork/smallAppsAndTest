using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerPartySimpleApp
{
    class DinnerParty
    {
        // FIELDS
        private const decimal costOfFoodPerPerson = 25M;
        private int numberOfPeople;
        private decimal costOfBeveragesPerPerson;
        private decimal costOfDecorations;
        private bool discount = false;

        // CONSTRUCTORS

        // SETTERS AND GETTERES

        public void SetNumberOfPeople(int numberOfPeople)
        {
            this.numberOfPeople = numberOfPeople;
        }
        public int GetNumberOfPeople()
        {
            return numberOfPeople;
        }

        // METHODS
        public void SetHealthyOption(bool isChecked)
        {
            if (isChecked)
            {
                costOfBeveragesPerPerson = 5M;
                discount = true;
            }
            else
            {
                costOfBeveragesPerPerson = 20M;
                discount = false;
            }
        }

        public void CalculateCostOfDecorations(bool isChecked)
        {
            if (isChecked)
            {
                costOfDecorations = numberOfPeople * 15M + 50;
            }
            else
            {
                costOfDecorations = numberOfPeople * 7.5M + 30;
            }

            return;
        }

        public decimal CalculateCost()
        {
            decimal totalCost = numberOfPeople * (costOfBeveragesPerPerson + costOfFoodPerPerson) + costOfDecorations;
            if (discount)
            {
                totalCost *= 0.95M;
            }
            return totalCost;
        }

    }
}
