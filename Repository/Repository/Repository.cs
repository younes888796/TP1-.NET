using Formation.Models;
using System;
using System.Collections.Generic;

namespace Formation.Repository
{
    public class Repository
    {
        public static Repository _instance;
        private Repository()
        {

        }
        public List<Restaurant> Restaurants { get; set; } = new List<Restaurant>(){
            new Restaurant{Id=Guid.NewGuid().ToString(), Name="R1",Address="Hay Ryad1",PhoneNumber="0604125873"},
            new Restaurant{Id=Guid.NewGuid().ToString(),Name="R2" ,Address="Hay Ryad2" ,PhoneNumber="0694198900"},
            new Restaurant{Id=Guid.NewGuid().ToString(), Name="R3",Address="Hay Ryad3",PhoneNumber="0684025821"},
            };

        public static Repository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Repository();
            }
            return _instance;
        }
    }
}
