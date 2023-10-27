using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace homework5.Models
{
    public class Cart
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "商品id必填")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "1-20个字符")]
        [Display(Name = "商品id")]
        public string? Product_id { get; set; } // 商品id
        [Required(ErrorMessage = "创建时间必填")]
        [Display(Name = "创建时间")]
        [DataType(DataType.Date)]
        public DateTime Createtime { get; set; } //创建时间
        [Required(ErrorMessage = "用户id必填")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "2-10个字符以内")]
        [Display(Name = "用户id")]
        public string? User_id { get; set; } //用户id
        [Required(ErrorMessage = "商品价格必填")]
        [Range(1, 10000, ErrorMessage = "1-10000之间")]
        [Display(Name = "商品价格")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
