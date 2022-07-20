using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EC_MVC.Models
{
    public class ExampleOrder
    {
        [Key]
        public int id { get; set; }
        [Display(Name ="Size of shirt")]
        public string size { get; set; }

        [Display(Name = "Color of the shirt")]
        public string color { get; set; }

        [Display(Name = "Is this a custom designed shirt?")]
        public string customDesign { get; set; }

        [Display(Name = "Front, Back, or Front and Back side of shirt?")]
        public string side { get; set; }

        [Display(Name = "Material of the shirt")]
        public string material { get; set; }

        [Display(Name = "Cost of this example shirt")]
        public double cost { get; set; }
    }
}