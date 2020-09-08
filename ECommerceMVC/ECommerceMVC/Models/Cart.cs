using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceMVC.Models
{
    public class Cart
    {
        [Key]
        public int CartID { get; set; }
     
        public int ProductID { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Price { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Quantity { get; set; }
    }
}
