using System;
using System.ComponentModel.DataAnnotations;
//the restaurants model is where we are creating the top 5 places to be displayed. if the link is null it will have an autofill.
namespace Assignment4.Models
{
    public class Restaurants
    {
        public Restaurants(int rank)
        {
            Rank = rank;
        }

        [Required(ErrorMessage = "Rank Required")]
        public int Rank { get; }


        [Required(ErrorMessage = "Restaurant Name Required")]
        public string RestaurantName { get; set; }


        public string? FavoriteDish { get; set; } 


        [Required(ErrorMessage = "Address Required")]
        public string Address { get; set; }


        [Phone]
        public string Phone { get; set; }


        public string? Link { get; set; } = "Coming Soon!";

       

        public static Restaurants[] GetRestaurants()
        {
            Restaurants r1 = new Restaurants(1)
            {
                //Rank = 1,
                RestaurantName = "Chick-Fil-A",
                //FavoriteDish = ,
                Address = "484 Bulldog Ln",
                Phone = "8013742697",
                //Link = "https://www.chick-fil-a.com/cougarandstate"
            };

            Restaurants r2 = new Restaurants(2)
            {
                //Rank = 2,
                RestaurantName = "Zao Asian Cafe",
                FavoriteDish = "Spicy Chicken Bowl",
                Address = "1352 State St",
                Phone = "8012240030",
                Link = "http://www.zaoasiancafe.com/"
            };

            Restaurants r3 = new Restaurants(3)
            {
                //Rank = 3,
                RestaurantName = "Cubby's",
                FavoriteDish = "Steak Salad",
                Address = "1258 N State St",
                Phone = "8019193023",
                Link = "http://cubbys.co/"
            };

            Restaurants r4 = new Restaurants(4)
            {
                //Rank = 4,
                RestaurantName = "In-N-Out",
                FavoriteDish = "Double-Double",
                Address = "350 E University Pkwy",
                Phone = "8012240030",
                //Link = "http://www.zaoasiancafe.com/"
            };

            Restaurants r5 = new Restaurants(5)
            {
                //Rank = 5,
                RestaurantName = "Cafe Rio",
                FavoriteDish = "Pork Tostada",
                Address = "2244 N University Pkwy",
                Phone = "8013755133",
                Link = "http://www.caferio.com/"
            };

            return new Restaurants[] { r1, r2, r3, r4, r5};
        }

    }
}
