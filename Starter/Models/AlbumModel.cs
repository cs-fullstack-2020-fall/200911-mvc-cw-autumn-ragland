// add required model annotations
using System.ComponentModel.DataAnnotations;

namespace Starter.Models
{
    public class AlbumModel
    {
        [Key]
        public int id{get;set;}
        [Display(Name = "Band ID")]
        public int bandID{get;set;}
        [Required]
        [StringLength(50)]
        [Display(Name = "Album Title")]
        public string title{get;set;}
        [Range(1960,2020)]
        [Display(Name = "Year Realeased")]
        public int yearReleased{get;set;}
    }
}