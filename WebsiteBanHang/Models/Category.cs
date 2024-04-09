using System.ComponentModel.DataAnnotations;

namespace WebsiteBanHang.Models
{
    public class Category
    {
        [Key] 
        public int CategoryId { get; set; }

        [StringLength(100)]
        public string CategoryName { get; set; }

        [StringLength(100)]
        public string CategoryImage { get; set; }

        public int CategoryOrder { get; set; }
    }
}
