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
        public Neighborhood()
        {

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
