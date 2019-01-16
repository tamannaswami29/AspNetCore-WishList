using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WishList.Models
{
    public class Item
    {
        public int Id { get; set; }
        //adding attributes
        [Required]
        [MaxLength(6)]                         //validations on description attribute
        public string Description { get; set; }
        public bool IsSelected { get; internal set; }
    }
}
