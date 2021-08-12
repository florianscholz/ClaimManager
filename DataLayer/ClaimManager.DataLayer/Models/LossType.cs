using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClaimManager.DataLayer.Models
{
    public class LossType  
    {
        [Required]
        [Column("LossTypeId")]
        public int Id { get; set; }  
        
        [Required]
        [Display(Name = "Code")]
        [Column("LossTypeCode")]
        public string Code { get; set; }
        
        [Required]
        [Display(Name = "Description")]  
        [Column("LossTypeDescription")]
        public string Description { get; set; }
    } 
}