using System;
using System.ComponentModel.DataAnnotations;

namespace TranThiLua0681.Models
{
    public class PersonTTL0681
    {
        [Key]
        [StringLength(20, MinimumLength = 3)]
        public int PersonId { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string PersonName { get; set; }

    }
}