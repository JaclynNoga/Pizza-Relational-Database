using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pizza_Relationship_Database_5_5.Models
{
    public class ToppingsModel
    {
        [Key]
        public int ToppingID { get; set; }
        public string ToppingName { get; set; }

        //foreign key for pizza
        public string PizzaID { get; set; }
        public PizzaModel Pizza { get; set; }
    }
}