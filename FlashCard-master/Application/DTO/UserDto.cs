using System;
using System.ComponentModel.DataAnnotations;

namespace Application.DTO
{
    public class UserDto
    {
        [Key]
        [StringLength(30, MinimumLength = 5)]
        [Required]
        public string ID { get; set; }
        [StringLength(30, MinimumLength = 5)]
        [Required]
        public string tagname { get; set; }
        [RegularExpression(@"[a-zA-Z0-9\-_]+@+[a-zA-Z]+\.+[a-z]+$")]
        public string email { get; set; }
        public string contry { get; set; }
        [Required]
        public string avatar { get; set; }
    }
}