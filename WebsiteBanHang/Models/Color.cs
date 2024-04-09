using System.ComponentModel.DataAnnotations;

namespace WebsiteBanHang.Models
{
    public class Color
    {
        [Key]
        public int ColorId {  get; set; }

        public string ColorName { get; set; }
    }
}
