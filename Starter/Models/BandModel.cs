using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
// add required model annotations
namespace Starter.Models
{
    public class BandModel
    {
        [Key]
        public int id{get;set;}
        [Required]
        [StringLength(50)]
        [Display(Name = "Band Name")]
        public string bandName{get;set;}
        [Range(1960,2020)]
        [Display(Name = "Year Formed")]
        public int yearFormed{get;set;}
        [EmailAddress]
        [Display(Name = "Contact Email")]
        public string contactEmail{get;set;}
        [Display(Name = "Active")]
        public bool isActive{get;set;}
        public List<AlbumModel> albums{get;set;}
    }
}
