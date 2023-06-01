using System.ComponentModel.DataAnnotations;
using Xunit.Sdk;

namespace flyplaza.Domain
{
    public class AllTableReservation
    {
        [Required(ErrorMessage = "Это поле должно быть заполнено")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Это поле должно быть заполнено")]
        [Display(Name = "Номер столика")]
        [Range(1, 10, ErrorMessage = "От 1 до 10")]
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
        [Phone(ErrorMessage = "Номер телефона введен неверно")]
        [Display(Name = "Номер телефона")]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Это поле должно быть заполнено")]
        [Display(Name = "Выберите дату и время")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Reservation { get; set; }

        [Display(Name = "Пожелания")]
        public string? Note { get; set; }
    }
}
