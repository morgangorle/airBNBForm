using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airBNBForm
{

    class District
    {
        //Here I create all the variables for the District Class
        string districtName;
        int numOfnHoods;
        Neighborhood[] districtNhoods;
        public District()
        {

        }
        //Here are the getters for this class
        public string getDistrictName()
        {
            return districtName;
        }
        public int getNumOfnHoods()
        {
            return numOfnHoods;
        }

        //Here are the setters for this class
        public void setDistrictName(string newDistrictName)
        {
            districtName = newDistrictName;
        }
        public void setNumOfnHoods(int newNumOfnHoods)
        {
            numOfnHoods = newNumOfnHoods;
        }
    }
}
