using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pizza_Relationship_Database_5_5.Models
{
    public class PizzaModel
    {
        [Key]
        public int PizzaID { get; set; }
        public string PizzaName { get; set; }
    }
}