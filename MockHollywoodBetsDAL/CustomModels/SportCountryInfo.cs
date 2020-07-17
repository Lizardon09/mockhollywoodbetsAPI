using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MockHollywoodBetsDAL.CustomModels
{
    public class SportCountryInfo
    {
        [Key]
        public int Id { get; set; }
        public int SportId { get; set; }
        public string SportName { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
    }
}
