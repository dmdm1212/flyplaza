using System.ComponentModel.DataAnnotations;

namespace flyplaza.Domain
{
    public class ArchiveReservation
    {
        [Required]
        public Guid Id { get; set; }
        public int TableNumber { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime Reservation { get; set; }
        public string? Note { get; set; }
    }
}
