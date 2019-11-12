using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airBNBForm
{
    class Neighborhood
    {
        //Here I create all the variables for the Neighborhood class
        string nHoodName;
        int numOfProperties;
        Property[] nhoodProperties;
        public Neighborhood(string initialNHoodName, int initialNumOfProperties, Property[] InitialProperties)
        {
            nHoodName = initialNHoodName;
            numOfProperties = initialNumOfProperties;
            nhoodProperties = InitialProperties;

        }
        public Neighborhood(string initialNHoodName)
        {
            nHoodName = initialNHoodName;
            numOfProperties = 0;
            nhoodProperties = new Property[0];

        }
        //The getters for the variables in this class
        public string getnHoodName()
        {
            return nHoodName;
        }
        public int getNumOfProperties()
        {
            return numOfProperties;
        }

        // The setters for the variables in this class
        public void setnHoodName(string newnHoodName)
        {
            nHoodName = newnHoodName;
        }
        public void setNumOfProperties(int newNumOfProperties)
        {
            numOfProperties = newNumOfProperties;
        }

    }
}
