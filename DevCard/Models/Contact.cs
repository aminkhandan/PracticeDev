using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevCard.Models;

public class Contact
{
    [Required(ErrorMessage = "فیلد اجباری")]
    [MaxLength(ErrorMessage = "حداکثر نام وارد شده ۱۰۰ کاراکتر می باشد")]
    public string Name { get; set; }
    [Required(ErrorMessage = "فیلد اجباری")]
    [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نیست")]
    public string Email { get; set; }
    public string Message { get; set; }
    public string Service { get; set; }
}