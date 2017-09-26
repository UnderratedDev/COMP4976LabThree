using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LabThree.Models
{
    public class City
    {
        [Display(Name = "City")]
        public String    CityName     { get; set; }
        public int       CityId       { get; set; }
        public int       Population   { get; set; }

        [Display(Name = "Province Code")]
        public String    ProvinceCode { get; set; }

        public Province  Province     { get; set; }
    }
}