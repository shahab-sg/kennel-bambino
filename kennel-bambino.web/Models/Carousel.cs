using System.ComponentModel.DataAnnotations;

namespace kennel_bambino.web.Models
{
    public class Carousel
    {
        [Key]
        public int CarouselId { get; set; }

        [required]
        [StringLength(75)]
        public string ImageName { get; set; }  

        [required]
        [StringLength(75)]
        public string Alt { get; set; }

        [required]
        [StringLength(75)]
        public byte Number { get; set; }

    }
}
