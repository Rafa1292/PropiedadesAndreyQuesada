using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DA.Cantons
{
    public class Canton
    {
        [Key]
        public int CantonId { get; set; }

        public string Name { get; set; }

        public bool Deleted { get; set; }
    }
}
