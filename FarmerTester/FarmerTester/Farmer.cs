using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerTester
{
    class Farmer
    {
        // FIELDS
        private int feedMultiplier;
        private int numberOfCows;

        // CONSTRUCTORS

        public Farmer(int numberOfCows, int feedMultiplier)
        {
            this.feedMultiplier = feedMultiplier;
            NumberOfCows = numberOfCows;
        }

        // PROPS
        public int BagsOfFeed { get; private set; }
        public int FeedMultiplier { get { return feedMultiplier; } }

        // SETTERS AND GETTERS

        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * feedMultiplier;
            }
        }

        // METHODS


    }
}
