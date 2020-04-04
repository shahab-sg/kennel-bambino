using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace kennel_bambino.web.Models
{
    public class Pattern
    {
        [Key]
        public int PatternId { get; set; }

        [required]
        [StringLength(120)]
        public string Name { get; set; }

        #region Relations - Navigation Properties

        public ICollection<Pet> Pets { get; set; }

        #endregion
    }

    internal class requiredAttribute : Attribute
    {
    }
}