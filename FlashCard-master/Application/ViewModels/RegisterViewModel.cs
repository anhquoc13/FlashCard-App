using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Tài khoản không được phép để trống")]
        [RegularExpression(@".{5,}", ErrorMessage = "Tài khoản ít nhất 5 ký tự")]
        public string id { get; set; }
        [Required(ErrorMessage = "Biệt danh không được phép để trống")]
        [RegularExpression(@".{5,}", ErrorMessage = "Biệt danh ít nhất 5 ký tự")]
        public string Tagname { get; set; }
        [Required(ErrorMessage = "Email không được phép để trống")]
        [RegularExpression(@"[a-zA-Z0-9\-_]+@+[a-zA-Z]+\.+[a-z]+$", ErrorMessage = "Email sai định dạng")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Mật khẩu không được phép để trống")]
        [RegularExpression(@".{5,}", ErrorMessage = "Mật khẩu ít nhất 5 ký tự")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Xác minh mật khẩu không được phép để trống")]
        [RegularExpression(@".{5,}", ErrorMessage = "Mật khẩu ít nhất 5 ký tự")]
        public string ConfirmPassword { get; set; }
    }
}