using System.ComponentModel.DataAnnotations.Schema;

namespace ChatSystemProject.Domain.Entities
{
    public class UserSettings
    {
        public int Id { get; set; }

        public Guid UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }

        public bool IsDarkMode { get; set; } = false;
        public bool IsNotificationEnabled { get; set; } = true;
        public string Language { get; set; } = "en";
        public DateTime CreatedAt { get; set; }
    }
}
