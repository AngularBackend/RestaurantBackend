using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AngularProjesiData.DbModels
{
   public class Item
    {
        [Key]
        public int ItemId { get; set; }
        
        public string Name { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
