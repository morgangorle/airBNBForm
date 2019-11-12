﻿using System;
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
        public District(string initialDistrictName, int initialNumOfNHoods, Neighborhood[] initialNHoods)
        {
            districtName = initialDistrictName;
            numOfnHoods = initialNumOfNHoods;
            districtNhoods = initialNHoods;

        }
        public District(string initialDistrictName)
        {
            districtName = initialDistrictName;
            numOfnHoods = 0;
            districtNhoods = new Neighborhood[0];

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
