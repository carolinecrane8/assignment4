using System;
using System.Collections.Generic;
//temp storage is how we work with displaying entries and lists.
namespace Assignment4.Models

{
    public static class TempStorage
    {
        private static List<NewRestaurant> applications = new List<NewRestaurant>();

        public static IEnumerable<NewRestaurant> Applications => applications;

        public static void AddApplication(NewRestaurant application)
        {
            applications.Add(application);
        }
    }
}

