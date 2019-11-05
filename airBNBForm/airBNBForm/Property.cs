using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airBNBForm
{

    class Property
    {
        //Here I create all the variables for the Property Class
        string propertyID, propertyName, hostID, hostName,roomType;
        //I used double rather than single for the compatibility with math functions.
        double latitude, longitude,price;
        int numOfProperties,minNumOfNights,availiableDays;

        public Property()
        {

        }
        //The getters for the Property variables
        public string getPropertyID()
        {
            return propertyID;
        }
        public string getPropertyName()
        {
            return propertyName;
        }
        public string getHostID()
        {
            return hostID;
        }
        public string getHostName()
        {
            return hostName;
        }
        public string getRoomType()
        {
            return roomType;
        }
        public double getLatitude()
        {
            return latitude;
        }
        public double getLongitude()
        {
            return longitude;
        }
        public double getPrice()
        {
            return price;
        }
        public int getNumOfProperties()
        {
            return numOfProperties;
        }
        public int getMinNumOfNights()
        {
            return minNumOfNights;
        }
        public int getAvailiableDays()
        {
            return availiableDays;
        }
        //The Setters for the Property class will be written here.
        public void setPropertyID(string newPropertyID)
        {
            propertyID = newPropertyID;
        }
        public void setPropertyName(string newPropertyName)
        {
            propertyName = newPropertyName;
        }
        public void setHostID(string newHostID)
        {
            hostID = newHostID;
        }
        public void setHostName(string newHostName)
        {
            hostName = newHostName;
        }
        public void setRoomType(string newRoomType)
        {
            roomType = newRoomType;
        }
        public void setLatitude(double newLatitude)
        {
            latitude = newLatitude;
        }
        public void setLongitude(double newLongitude)
        {
            longitude = newLongitude;
        }
        public void setPrice(double newPrice)
        {
            price = newPrice;
        }
        public void setNumOfProperties(int newNumOfProperties)
        {
            numOfProperties = newNumOfProperties;
        }
        public void setMinNumOfNights(int newMinNumOfNights)
        {
            minNumOfNights = newMinNumOfNights;
        }
        public void setAvailiableDays(int newAvailiableDays)
        {
            availiableDays = newAvailiableDays;
        }

    }
}
