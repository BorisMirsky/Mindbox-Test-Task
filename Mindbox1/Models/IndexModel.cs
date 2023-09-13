using Mindbox1.Models;
using System.ComponentModel.DataAnnotations;


namespace Mindbox1.Models
{
    public class IndexModel
    {
        [Required(ErrorMessage = "Нельзя отправлять пустое поле")]
        [MaxLength(8)]
        [MinLength(1)]
        [RegularExpression("^\\s*(?=.*[1-9])\\d*(?:\\.\\d{1,3})?\\s*$", ErrorMessage = "Только числа больше нуля, три знака после точки")]
        public string? TriangleSide1 { get; set; }

        [Required(ErrorMessage = "Нельзя отправлять пустое поле")]
        [MaxLength(8)]
        [MinLength(1)]
        [RegularExpression("^\\s*(?=.*[1-9])\\d*(?:\\.\\d{1,3})?\\s*$", ErrorMessage = "Только числа больше нуля, три знака после точки")]
        public string? TriangleSide2 { get; set; }

        [Required(ErrorMessage = "Нельзя отправлять пустое поле")]
        [MaxLength(8)]
        [MinLength(1)]
        [RegularExpression("^\\s*(?=.*[1-9])\\d*(?:\\.\\d{1,3})?\\s*$", ErrorMessage = "Только числа больше нуля, три знака после точки")]
        public string? TriangleSide3 { get; set; }

        [Required(ErrorMessage ="Нельзя отправлять пустое поле")]
        [MaxLength(8)]
        [MinLength(1)]
        [RegularExpression("^\\s*(?=.*[1-9])\\d*(?:\\.\\d{1,3})?\\s*$", ErrorMessage = "Только числа больше нуля, три знака после точки")]
        public string? CircleRadius { get; set; }
    }
}
