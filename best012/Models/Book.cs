using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace best012.Models
{
    public class Book
    {
        [DisplayName("รหัสหนังสือ")]
        public int Id { get; set; }
        [DisplayName("ชื่อหนังสือ")]
        [displayFormat(NullDisplayText = "ไม่มี")]
        [Required(ErrorMessage = "ต้องระบุชื่อหนังสือ")]
        public string Name { get; set; }
        [DisplayName("ราคาหนังสือ")]
        [displayFormat(DataFormatString = "{0:C4}")]
        [Range(1, 1000, ErrorMessage = "ราคาต้องอยู่ระหว่าง {1} กับ {2}")]
        [Required(ErrorMessage ="ต้องการระบุราคาหนังสือ")]
        
        public decimal Price { get; set; }
    }
}
