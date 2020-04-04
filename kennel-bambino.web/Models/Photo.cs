using System.ComponentModel.DataAnnotations;

namespace kennel_bambino.web.Models
{
    public class Photo
    {
        [Key]
        public int PhotoId { get; set; }

        [required]
        [StringLength(75)]
        public string PhotoName { get; set; }

        [required]
        public int PetId { get; set; }

        #region Relations - Navigation Properties

        public Pet Pet { get; set; }

        #endregion
    }
}