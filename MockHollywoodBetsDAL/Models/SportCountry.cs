using System;
using System.Collections.Generic;

namespace MockHollywoodBetsDAL.Models
{
    public partial class SportCountry
    {
        public int SportCountryId { get; set; }
        public int? SportId { get; set; }
        public int? CountryId { get; set; }

        public virtual Country Country { get; set; }
        public virtual SportTree Sport { get; set; }
    }
}
