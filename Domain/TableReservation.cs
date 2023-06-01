using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace flyplaza.Domain
{
    public class TableReservation
    {
        [Required(ErrorMessage = "Это поле должно быть заполнено")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Это поле должно быть заполнено")]
        [Display(Name ="Номер столика")]
        [Range(1,10, ErrorMessage = "От 1 до 10")]
        public int TableNumber { get; set; }

        [Required(ErrorMessage = "Это поле должно быть заполнено")]
        [Display(Name = "Имя")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Это поле должно быть заполнено")]
        [Display(Name = "Фамилия")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Это поле должно быть заполнено")]
        [Display(Name = "E-mail")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Это поле должно быть заполнено")]
        [Display(Name = "Номер телефона")]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Это поле должно быть заполнено")]
        [Display(Name = "Выберите дату и время")]
        public DateTime Reservation { get; set; }

        [Display(Name = "Пожелания")]
        public string? Note { get; set; }
    }
}
