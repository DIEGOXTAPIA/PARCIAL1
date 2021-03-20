using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PARCIAL1.Models
{
    public class Class1
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "INGRESE ENTRE 3 A 30 CARACTERES")]
        public string Description { get; set; }
        [Required]
        public DataType Price { get; set; }
        public DataType LastBuy { get; set; }

    }
}