using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabThree.Models
{
    public class Province
    {
        [Key]
        [Required]
        [Display(Name = "Province Code")]
        public String ProvinceCode { get; set; }

        [Required]
        [Display(Name = "Province")]
        public String ProvinceName { get; set; }
        public List<City> cities { get; set; }
    }
}