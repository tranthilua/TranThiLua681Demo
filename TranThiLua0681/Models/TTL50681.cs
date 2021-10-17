using System;
using System.ComponentModel.DataAnnotations;

namespace TranThiLua0681.Models
{
    public class TTL50681
    {
        [Key]
        public int TTLId { get; set; }
         [Display(Name = "Tên")]
        public string TTLName { get; set; }
         [Display(Name = "Giới Tính")] //doi ten tieu de
        public string TTLGender { get; set; }
    }
}
