using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mockhollywoodbets.Models
{
    public class SportTree
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }

        public SportTree(long id, string name, string logo)
        {
            this.Id = id;
            this.Name = name;
            this.Logo = logo;
        }

    }
}
