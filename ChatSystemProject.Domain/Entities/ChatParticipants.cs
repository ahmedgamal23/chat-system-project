using ChatSystemProject.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatSystemProject.Domain.Entities
{
    public class ChatParticipants
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        public Guid ChatId { get; set; }
        [ForeignKey(nameof(ChatId))]
        public Chat Chat { get; set; }
        
        public UserRole Role { get; set; }
        public DateTime JoinedAt { get; set; }

        public bool IsMuted { get; set; }
        public bool IsArchived { get; set; }
    }
}
