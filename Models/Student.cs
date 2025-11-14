using System.ComponentModel.DataAnnotations;

namespace ltweb_th1.Models
{
    public class Student
    {
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 4)]
        [Required(ErrorMessage = "Tên bắt buộc phải được nhập")]
        public string? Name { get; set; }
        [Required(ErrorMessage="Email bắt buộc phải được nhập")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@gmail.com",
            ErrorMessage = "Email phải đúng định dạng và kết thúc bằng gmail.com")]
        public string? Email { get; set; }
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Mật khẩu phải dài ít nhất 8 kí tự")]
        //start of string, one lowercase in string, one uppercase in string, one number in string, one character
        //NOT a lowercase / uppercase / number, takes the whole string, end
        [Required(ErrorMessage = "Mật khẩu bắt buộc phải được nhập")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^A-Za-z\d\s]).+$",
            ErrorMessage = "Mật khẩu phải chứa chũ hoa, chữ thường, số và kí tự đặc biệt")]
        public string? Password { get; set; }
        [Required]
        public Branch? Branch { get; set; }
        [Required(ErrorMessage = "Giới tính bắt buộc phải chọn")]
        public Gender? Gender { get; set; }
        public bool IsRegular { get; set; }
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Địa chỉ bắt buộc phải được nhập")]
        public string? Address { get; set; }
        [Range(typeof(DateTime), "1/1/1963", "12/31/2005")]
        [Required(ErrorMessage = "Giá trị không hợp lệ")]
        [DataType(DataType.Date)]
        //make the field nullable so that required runs before conversion
        public DateTime? DateOfBirth { get; set; }
        [Required(ErrorMessage = "Điểm bắt buộc phải được nhập")]
        [Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong khoảng từ 0 đến 10.0")]
        public float Grade { get; set; }
    }
}
