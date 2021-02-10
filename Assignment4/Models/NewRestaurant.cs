using System;
using System.ComponentModel.DataAnnotations;
//this model will validate the user entries that they will put in.
namespace Assignment4.Models
{
    public class NewRestaurant
    {

        [Required(ErrorMessage = "Customer Name Required")]
        public string CustName { get; set; }

        [Required(ErrorMessage = "RestaurantName Required")]
        public string RestaurantName { get; set; }

        [Required]
        public string FavoriteDish { get; set; } = "It's all tasty!";


        [Required]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Entered phone format is not valid. (###-###-####)")]
        
        public string Phone { get; set; }
    }
}
