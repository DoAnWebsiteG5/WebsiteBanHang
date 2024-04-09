using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebsiteBanHang.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [StringLength(50)]
        public string? ProductName { get; set; }

        [StringLength(1000)]
        public string? ProductDescription { get; set;}

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public Category? Category { get; set; }

        [Column(TypeName ="decimal(8,2)")]
        public decimal? ProductPrice { get; set; }

        [Column(TypeName = "decimal(2,2)")]
        public decimal? ProductDiscount { get; set;}

        [StringLength(100)]
        public string? ProductImage { get; set; }

        [ForeignKey("Color")]
        public int ColorId {  get; set; }
        
        public Color? Color { get; set; }

        public bool IsTrandy {  get; set; }

        public bool IsArrived { get; set; }

    }
}
