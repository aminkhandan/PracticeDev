using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard.Models;

public class Contact
{
    [Required(ErrorMessage = "فیلد اجباری")]
    [MaxLength(100,ErrorMessage = "حداکثر نام وارد شده ۱۰۰ کاراکتر می باشد")]
    public string Name { get; set; }
    [Required(ErrorMessage = "فیلد اجباری")]
    [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نیست")]
    public string Email { get; set; }
    public string Message { get; set; }
    public int Service { get; set; }
    public SelectList Services { get; set; }
}