using System;
using System.ComponentModel.DataAnnotations;

namespace kennel_bambino.web.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [required]
        [StringLength(12)]
        public string PhoneNumber { get; set; }

        [required]
        [StringLength(120)]
        public string Title { get; set; }

        [required]
        [StringLength(750)]
        public string Description { get; set; }

        public bool IsChecked { get; set; }

        public DateTime SubmitDate { get; set; }

    }
}
